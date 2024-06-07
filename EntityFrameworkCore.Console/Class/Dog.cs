using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Console.Class
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Barks");
        }
    }
}