using System;

using System;
namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatype[] identifier = 
            string[] names = { "Ben", "Kelvin", "Gary", "Mick", "Adam", "Scott", "Sam", "Poonam" };
            //Array.Sort();
            //foreach(string i in ()
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Mick")
                {
                    Console.WriteLine($"The Value of Mick is found in location {i}");
                }
            }


            Array.Reverse(names);
            
            foreach (string team in names)
            {
                Console.WriteLine(team);
            }

            names[3] = "Arya";
            Console.WriteLine(names[3]);

            Array.Sort(names);

            foreach (string team in names)
            {
                Console.WriteLine(team);
            }
        }
    }
}

