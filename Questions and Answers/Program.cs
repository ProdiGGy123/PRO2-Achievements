using System;

namespace Questions_and_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string s;
            Console.WriteLine("What's your favorite story?");
            s = Console.ReadLine();

            Console.Clear();

            string s2;
            Console.WriteLine("Are you a boy, a girl... or perhaps something else?");
            s2 = Console.ReadLine();

            Console.Clear();

            string s3;
            Console.WriteLine("What's your favorite game?");
            s3 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("So your favorite story is {0}", s); 

            Console.WriteLine("Ah ok so you are a {0}", s2);

            Console.WriteLine("Your favorite game is {0}? Interesting...", s3);
        }
    }
}
