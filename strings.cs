using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatype[] identifier = 

            string[] formula1Teams = {"Mercedes","Red Bull","Mclaren","Racing Point","Renault","Alpha Tauri","Alfa Romeo","Haas","Williams"};

            //Array.Sort();

            //foreach(string i in ()
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < formula1Teams.Length; i++)
            {
               if(formula1Teams[i] == "Mclaren")
               {
                   Console.WriteLine($"The Index of Mclaren is {i}");
               }
            }

            Array.Sort(formula1Teams);

            foreach(string team in formula1Teams)
            {
                Console.WriteLine(team);
            }
        }
    }
}