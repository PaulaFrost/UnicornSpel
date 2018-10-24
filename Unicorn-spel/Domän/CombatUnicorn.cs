using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn_spel.Domän
{
    class CombatUnicorn : Unit
    {
        public string RegristationNumber { get; set; }

        public CombatUnicorn(string regristationNumber) : base(200, 25)
        {
            RegristationNumber = regristationNumber;
        }
        public override void WarScream() //När Unit warScream är abstract så får man lov att ändra och göra unika ändringar för just den uniten. I det här fallet Unicorn.
        {                                //Detta sker när Unicorn ärver metoder från Unit som r basen. Soilder som är felstavat ärver ocks metoder från Unit.
            Console.WriteLine("Gnägg!!!");
        }
        public override void PrintStatus()
        {
            Console.WriteLine("Phrrrrh");
        }
    }
}
