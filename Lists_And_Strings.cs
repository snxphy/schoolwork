using System;
using System.Collections.Generic;

namespace stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = new int[3];
            //myArray[0] = 1;
            //myArray[1] = 11;
            //myArray[2] = 22;

            //int[] anotherArray = {20,40,60,80};

            List<string> myStrings = new List<string>();   //list
            myStrings.Add("\nBulbasaur");
            myStrings.Add("Ivysaur");
            myStrings.Add("Venusaur");
            myStrings.Add("\nPichu");
            myStrings.Add("Oak");

            //foreach (var item in myStrings)
            //{
            //    Console.WriteLine(item);
            //}

            myStrings.Add("Pikachu");
            myStrings.Add("Raichu");
            myStrings.Add("\nCharmander");
            myStrings.Add("Charmeleon");
            //foreach (var item in myStrings)
            //{
            //    Console.WriteLine(item);
            //}

            myStrings.Remove("Oak");  //remove from string

            myStrings.Add("Charizard");  //add items to string
            myStrings.Add("\nSquirtle");
            myStrings.Add("Wartortle");
            myStrings.Add("Blastoise");

            foreach (var item in myStrings)   //for items in string do:
            {
                Console.WriteLine(item);  //print string
            }
        }
    }
}