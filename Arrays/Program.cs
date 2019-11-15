using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"Kingdom Hearts", "Super Mario Strikers", "Final Fantasy XIV: Stormbringers", "Okami", 
            "Megaman Zero", "Pokemon Heartgold", "Legend of Zelda: Twilight Princess", "Metal Gear Solid 3: Snake Eater", "Splatoon 2", 
            "Monster Hunter Tri Ultimate"};

            Console.Clear();

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
