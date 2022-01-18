using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bettingapp
{
    internal class Spiller 
    {
        public string? name {get; set;}
        public String? betResutat { get; set;}
        public string? resutat { get; set;}

       
        // laver en static list som kan bruge i andre class
        static List<Spiller> Spillerlist = new List<Spiller>();


        // metode der bruges til at vise list i andre class
        public List<Spiller> GetList()
        {
            return Spillerlist;
        }


       
        // tilføjer spiller
        public void AddSpiller()
        {

           

            
            bool morePlayers = true;

            while (morePlayers)
            {
                Console.WriteLine("Skriv: Navn" + " " + "Resutat");



                Spillerlist.Add(new Spiller
                {

                    name = Console.ReadLine(),
                    betResutat = Console.ReadLine(),
                    //Bet = Convert.ToInt16(Console.ReadLine()),
                    

                   

                });
               
                Console.WriteLine("Tilføj flere spillere? skriv '1' for ja, '2' for nej.");
                string? userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    morePlayers = true;
                }
                else break;


            }


            




            // loper igennem list 
            foreach (var Spiller in Spillerlist)
            {
               


                Console.WriteLine("Name" + " " + Spiller.name);
                Console.WriteLine("Resutat" + " " + Spiller.betResutat);
                //Console.WriteLine("Bet" + " " + Spiller.Bet + "Kr.");               
                Console.WriteLine("********************");

            }


            
        }
       
    }
}
