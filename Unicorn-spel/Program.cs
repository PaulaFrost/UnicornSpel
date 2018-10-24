using System;
using Unicorn_spel.Domän;

namespace Unicorn_spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rnd = random.Next(1, 50);

            Unit[] units =                              //Array av units
            {
                new CombatUnicorn("InsaneMajBritt"),
                new Soilder("JOE")
            };
            
            //Lek, go Apeshit!

        }
    }
}
