// See https://aka.ms/new-console-template for more information
using EntityFrameworkCore.App;
using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;



//Skip and Take, paginated 

AppFactory appFactory = new AppFactory(new CoreDbContext());

void Main()
{
    var teams = appFactory.coreDbContext.Teams.FirstOrDefault(t => t.Id == 1);
    var coach = appFactory.coreDbContext.Coaches.FirstOrDefault(t => t.Id == 1);
    var league = appFactory.coreDbContext.Leagues.FirstOrDefault(t => t.Id == 1);   
   

    if (teams != null && coach != null && league != null)
    {
        Team t = new Team();
        t.Coach = coach;
        t.League = league;
        t.Name = "Team 11";
        t.CreatedBy = "System";
        t.CreatedDate = DateTime.Now;
        t.ModifiedDate = DateTime.Now;
        /* appFactory.coreDbContext.Entry(teams).State = EntityState.Added;
        Console.WriteLine(teams.Name);
        teams.Name = "Team 1111";
        Console.WriteLine(teams.Name); */
        appFactory.coreDbContext.Teams.Add(t);
        appFactory.coreDbContext.SaveChanges();

    }

    

}

Main();