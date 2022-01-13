using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bettingapp
{
    internal class Spiller
    {
        public string? Name {get; set;}
        public int? Bet {get; set;}
        public int BetResult { get; set;}

        List<Spiller> Spillerlist = new List<Spiller>();

        public void Addspiller()
        {
            Spillerlist.Add(new Spiller
            {
                Name = Console.ReadLine(),
                Bet = Convert.ToInt16( Console.ReadLine()),
                BetResult = Convert.ToInt16(Console.ReadLine()),



            });

            foreach(var Spiller in Spillerlist)
            {
                Console.WriteLine(Name + " " + BetResult + " " + Bet);

            }


        }
    }
}
