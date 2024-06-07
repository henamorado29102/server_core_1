using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.App
{
    public class AppFactory
    {
        public CoreDbContext coreDbContext;

        public AppFactory(CoreDbContext _coreDbContext)
        {
            coreDbContext = _coreDbContext;
        }

        public void NotTrakingEntities()
        {
            //chage made in this entities don apply on DB
            var teams = coreDbContext.Teams.AsNoTracking();

            var team = coreDbContext.Teams.FirstOrDefault(t => t.Id == 1);

            if (team != null)
            {
                coreDbContext.Entry(team).State = EntityState.Detached;
                System.Console.WriteLine(team.Name);
                team.Name = "Team 1111";
                System.Console.WriteLine(team.Name);
                coreDbContext.SaveChanges();

            }
        }


        // Groping 
        public void GroupTeams()
        {
            var teamsGrouped = coreDbContext.Teams.GroupBy(g => g.CreatedBy);
            foreach (var teamGroup in teamsGrouped)
            {
                System.Console.WriteLine(teamGroup.Key);
                foreach (var team in teamGroup)
                {
                    System.Console.WriteLine(team.Name);
                }
            }                               // .Where();
        }


        //Ordering 
        public void OrderTeams()
        {
            var teamOrdered = coreDbContext.Teams.OrderBy(g => g.CreatedBy).ToList();
            foreach (var team in teamOrdered)
            {
                System.Console.WriteLine(team.Name);
            }
            teamOrdered = coreDbContext.Teams.OrderByDescending(g => g.CreatedBy).ToList();
            foreach (var team in teamOrdered)
            {
                System.Console.WriteLine(team.Name);
            }
            System.Console.WriteLine("-------");
            var maxByDescending = coreDbContext.Teams.OrderByDescending(g => g.Id).FirstOrDefault();
            //var teamMax = coreDbContext.Teams.Max();
            if (maxByDescending != null)
            {
                System.Console.WriteLine(maxByDescending.Name);
            }
            try
            {
                var teamMin = coreDbContext.Teams.Min(g => g.Name);
                if (teamMin != null)
                {
                    System.Console.WriteLine(teamMin);
                }
                else
                {
                    System.Console.WriteLine("No teams found.");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"An error occurred: {ex.Message}");
                System.Console.WriteLine(ex.StackTrace);
            }


        }
    }
}