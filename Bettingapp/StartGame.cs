using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bettingapp
{
    internal class StartGame
    {
        public string? homeTeam;
        public string? awayTeam;
        public string? resutat;
        public String? Betbeløb { get; set; }





        // tilføjer hold
        public void TilføjHold()
        {
            
            Console.WriteLine("Enter Hometeam");
            homeTeam = Console.ReadLine();

           
            Console.WriteLine("Enter Awayteam");
            awayTeam = Console.ReadLine();


        }
        public void TilføjResutat()
        {
            Console.WriteLine("Tilføj bet beløb");
            Betbeløb = Console.ReadLine();


        }

        public void VisHeader()
        {
            
            Console.WriteLine($"{homeTeam.ToUpper()} VS { awayTeam.ToUpper()}: {resutat} {Betbeløb} Kr.");
        }

        public void Showlist()
        {

            // Henter static list
            Spiller spiller = new Spiller();


            Console.WriteLine("Angiv resutat");
            resutat = Console.ReadLine();

            VisHeader();

            foreach (var Spiller in spiller.GetList())
            {

                

                if (resutat == Spiller.betResutat)
                {
                    Console.WriteLine(Spiller.name + ":" + " " + "won" + ":" + Betbeløb + "Kr.");


                }
                else
                {

                    Console.WriteLine(Spiller.name + ":" + " " + "Lost" + ":" + Betbeløb + "Kr.");
                }

            }


        }

       






    }
}
