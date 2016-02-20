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

            DateTime dt = Convert.ToDateTime(birthday);

            //Console.WriteLine("Month: {0}, Day: {1}", dt.Month, dt.Day);

            DateTime localDate = DateTime.Now;

            //Console.WriteLine("Month Today: {0}, Day Today: {1}", localDate.Month, localDate.Day);
            TimeSpan t = localDate - dt;
            //Console.WriteLine("Days until your birthday " + t.TotalDays);
            if (t.TotalDays >= 0 && t.TotalDays < 1)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else
            {
                Console.WriteLine("Days until your birthday: " + Math.Abs(t.TotalDays));
            }


            Console.Read();
        }
    }
}
