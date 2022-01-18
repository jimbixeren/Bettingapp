using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bettingapp
{
    internal class Prep
    {
        public string? hometeam;
        public string? awayteam;
        public string? resutat;
        public String? Betbeløb { get; set; }





        // tilføjer hold
        public void Tilføjhold()
        {
            
            Console.WriteLine("Enter Hometeam");
            hometeam = Console.ReadLine();

           
            Console.WriteLine("Enter Awayteam");
            awayteam = Console.ReadLine();


        }
        public void Tilføjresutat()
        {
            Console.WriteLine("Tilføj bet beløb");
            Betbeløb = Console.ReadLine();


        }

        public void Visheader()
        {
            Console.WriteLine(hometeam.ToUpper() + " " + "VS" + " " + awayteam.ToUpper() + ":" + " " + resutat + " " + Betbeløb + "Kr." );

        }

        public void Showlist()
        {

            // Henter static list
            Spiller spiller = new Spiller();


            Console.WriteLine("Angiv resutat");
            resutat = Console.ReadLine();

            Visheader();

            foreach (var Spiller in spiller.GetList())
            {

                

                if (resutat == Spiller.BetResult)
                {
                    Console.WriteLine(Spiller.Name + ":" + " " + "won" + ":" + Betbeløb + "Kr.");


                }
                else
                {

                    Console.WriteLine(Spiller.Name + ":" + " " + "Lost" + ":" + Betbeløb + "Kr.");
                }

            }


        }

       






    }
}
