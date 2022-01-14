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
        public String? BetResult { get; set;}

        

        public void Addspiller()
        {

            List<Spiller> Spillerlist = new List<Spiller>();



            Console.WriteLine("Skriv: Navn" + " " + "Resutat" + " " + "Bet");


            Spillerlist.Add(new Spiller
            {
               

                
                Name = Console.ReadLine(),                
                BetResult = Console.ReadLine(),
                Bet = Convert.ToInt16(Console.ReadLine()),



            });

            foreach(var Spiller in Spillerlist)
            {


                Console.WriteLine("Name" + " " + Spiller.Name);
                Console.WriteLine("Resutat" + " " + Spiller.BetResult);
                Console.WriteLine("Bet" + " " + Spiller.Bet + "Kr.");
                Console.WriteLine("********************");

            }


        }
    }
}
