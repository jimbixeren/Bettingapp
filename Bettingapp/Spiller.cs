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

        //Prep prep = new Prep();
        //prep.Visheader();




        

        public void Addspiller()
        {

            



            List<Spiller> Spillerlist = new List<Spiller>();

            
           

            bool moreplayers = true;

            while (moreplayers)
            {
                Console.WriteLine("Skriv: Navn" + " " + "Resutat" + " " + "Bet");


                Spillerlist.Add(new Spiller
                {

                    Name = Console.ReadLine(),
                    BetResult = Console.ReadLine(),
                    Bet = Convert.ToInt16(Console.ReadLine()),

                });



                Console.WriteLine("Tilføj flere spillere? skriv '1' for ja, '2' for nej.");
                string? userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    moreplayers = true;
                }
                else break;


            }


            
            

            foreach (var Spiller in Spillerlist)
            {
                


                Console.WriteLine("Name" + " " + Spiller.Name);
                Console.WriteLine("Resutat" + " " + Spiller.BetResult);
                Console.WriteLine("Bet" + " " + Spiller.Bet + "Kr.");
                Console.WriteLine("********************");

            }


        }
    }
}
