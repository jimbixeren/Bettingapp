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

            Prep prep = new Prep();
            prep.Tilføjhold();
            prep.Tilføjresutat();
            prep.Visheader();

            Spiller spiller = new Spiller();
            
            spiller.Addspiller();
            
            

            prep.Showlist();

          








            Console.ReadLine();

        }


    }

}