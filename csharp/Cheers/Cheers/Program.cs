using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("What's your name?");

            name = Console.ReadLine();

            string birthday;

            Console.WriteLine("When is your birthday?");

            birthday = Console.ReadLine();

            char[] array = name.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];

                var str = "halfnorsemix";
                if (str.Contains(letter))
                {
                    Console.WriteLine("Give me an: " + letter);
           
                }
                else
                {
                    Console.WriteLine("Give me a: " + letter);
                }
                
                
            }
            Console.WriteLine(name + " is awesome!");

            Console.Read();
        }
    }
}
