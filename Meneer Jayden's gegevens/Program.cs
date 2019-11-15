using System;

namespace Meneer_Jayden_s_gegevens
{
    using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();

            string s;
            Console.WriteLine("What's your name?");
            s = Console.ReadLine();

            Console.Clear();

            string s2;
            Console.WriteLine("How old are you?");
            s2 = Console.ReadLine();

            Console.Clear();

            string s3;
            Console.WriteLine("What color of eyes do you have?");
            s3 = Console.ReadLine();

            Console.Clear();

            string s4;
            Console.WriteLine("What's your postal code?");
            s4 = Console.ReadLine();

            Console.Clear();

            string s5;
            Console.WriteLine("In what place do you live?");
            s5 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Hallo {0}", s); 

            Console.WriteLine("So your name is {0}", s2);

            Console.WriteLine("From {0}", s3);

            Console.WriteLine("Your postal code is {0}", s4);

            Console.WriteLine("And you live in {0}", s5);

        

        }
    }
}
