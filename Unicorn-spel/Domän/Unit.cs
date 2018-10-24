using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn_spel.Domän
{
    abstract class Unit
    {
        private int Health { get; set; }
        private int DamageDealt { get; set; } 

        public Unit(int health, int damageDealt)
        {
            Health = health;
            DamageDealt = damageDealt;
        }

        public void Attack(Unit unit)
        {
            unit.Defend(DamageDealt);
        }

        public void Defend(int damageDealt)
        {
            Health -= damageDealt;
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public abstract void WarScream(); //Andra objekt kan skriva sitt unika beteende.

        public virtual void PrintStatus()
        {
            Console.WriteLine($"Health: {Health}");


            if (IsAlive)
            {
                Console.WriteLine("I´m alive!");
            }
            else
            {
                Console.WriteLine("KIA");
            }

        }
    }
}
