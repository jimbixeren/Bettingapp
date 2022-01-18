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


       


        public void Tilføjhold(/*string aHometeam, string aAwayteam, int aResutat*/)
        {
            //hometeam = aHometeam;
            //awayteam = aAwayteam;
            //resutat = aResutat;


            Console.WriteLine("Enter Hometeam");
            hometeam = Console.ReadLine();

           
            Console.WriteLine("Enter Awayteam");
            awayteam = Console.ReadLine();

           


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

            }


        }

        //public void Betbeløb()
        //{
        //    Spiller spiller = new Spiller();

        //    foreach (var Spiller in spiller.GetList())
        //    {

        //        //Spiller.BetResult

        //        if (Spiller.Bet != Spiller.Bet)
        //        {

        //            Console.WriteLine("bet beløb skal være det samme");

        //        }
               

        //    }

        //}






    }
}
