using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfFruit
{
    class Program
    {
        /// <summary>
        /// Fruit Array
        /// </summary>
        public enum Fruit
        {
            none,
            Orange,
            Apple,
            Watermelon,
            Pineapple,
            Necturine,
            Grapes,
        }
        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[3];
            string userInput;

            for (int i = 0; i < fruits.Count(); i++)
            {
                Console.Write($"Enter fruit {i+1}: ");
                userInput = Console.ReadLine();
                Enum.TryParse(userInput, out fruits[i]);
            }
            Console.WriteLine();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
