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


        //Spiller spiller = new Spiller();


        public void Tilføjhold(/*string aHometeam, string aAwayteam, int aResutat*/)
        {
            //hometeam = aHometeam;
            //awayteam = aAwayteam;
            //resutat = aResutat;


            Console.WriteLine("Enter Hometeam");
            hometeam = Console.ReadLine();

           
            Console.WriteLine("Enter Awayteam");
            awayteam = Console.ReadLine();

            //Console.WriteLine(hometeam.ToUpper() + " " + "VS" + " " + awayteam.ToUpper());


        }

        public void Visheader()
        {
            Console.WriteLine(hometeam.ToUpper() + " " + "VS" + " " + awayteam.ToUpper() + ":" + " " + resutat);

        }


       

        public void Showlist()
        {
            Spiller spiller = new Spiller();


            Console.WriteLine("Angiv resutat");
            resutat = Console.ReadLine();

            Visheader();

            foreach (var Spiller in spiller.GetList())
            {

                //Spiller.BetResult

                if (resutat == Spiller.BetResult)
                {
                    Console.WriteLine(Spiller.Name + ":" + " " + "won" + " " + Spiller.Bet);


                }
                else
                {

                    Console.WriteLine(Spiller.Name + ":" + " " + "Lost" + " " + Spiller.Bet);
                }

                //Console.WriteLine("Name" + " " + Spiller.Name);
                //Console.WriteLine("Resutat" + " " + Spiller.BetResult);
                //Console.WriteLine("Bet" + " " + Spiller.Bet + "Kr.");
                //Console.WriteLine("********************");

            }


        }






    }
}
