using System;

namespace If_only_that_were_true
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a++;
            a += 1;
            a= a + 1;

            int b = 0;
            b--;
            b -= 1;
            b= b - 1;

            if(a == 3 && b == -3)
            {
                Console.Clear();
                Console.WriteLine("Getal a is", a);
                Console.WriteLine("Getal b is", b);
                Console.WriteLine("Goed gedaan!");
            }
            
            else if(a == 3 || b == -3)
            {
                Console.Clear();
                Console.WriteLine("Getal a is", a);
                Console.WriteLine("Getal b is", b);
                Console.WriteLine("Bijna! Maar niet helemaal!");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Getal a is", a);
                Console.WriteLine("Getal b is", b);
                Console.WriteLine("Jammer!");
            }

        }
    }
}
