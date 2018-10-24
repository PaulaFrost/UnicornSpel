using System;

namespace Unicorn_spel.Domän
{
    class Soilder : Unit
    {
        public string Name { get; }

        public Soilder(string name) : base(100, 15)
        {
            Name = name;
        }
        public override void WarScream()
        {
            Console.WriteLine("Victory for Sylvanas!!!");
        }
        public override void PrintStatus()
        {
            Console.WriteLine("Doing swell");
        }
    }
}