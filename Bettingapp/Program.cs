//See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Bettingapp
{

    internal class Program
    {
        static void Main(string[] args)
        {

            StartGame prep = new StartGame();
            prep.TilføjHold();
            prep.TilføjResutat();
            prep.VisHeader();


            Spiller spiller = new Spiller();            
            spiller.AddSpiller();                      
            prep.Showlist();

          








            Console.ReadLine();

        }


    }

}