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
        public int resutat;


        public Prep(/*string aHometeam, string aAwayteam, int aResutat*/)

        {
            //hometeam = aHometeam;
            //awayteam = aAwayteam;
            //resutat = aResutat;


            


            Console.WriteLine("Enter Hometeam");
            hometeam = Console.ReadLine();

            



            Console.WriteLine("Enter Awayteam");
            awayteam = Console.ReadLine();

            Console.WriteLine(hometeam.ToUpper() + " " + "VS" + " " + awayteam.ToUpper());


            





            Console.ReadLine();

        }


    }
}
