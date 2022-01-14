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

        Spiller spil = new Spiller();


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
            Console.WriteLine(hometeam.ToUpper() + " " + "VS" + " " + awayteam.ToUpper());

        }


        public void Spilend()
        {

            Console.WriteLine("Angiv resutat");
            resutat = Console.ReadLine();

            if (resutat == spil.BetResult)
            {
                Console.WriteLine($"You have won " +  spil.Name);


            }else
            {

                Console.WriteLine($"you have lost" +  spil.Name);
            }



        }




    }
}
