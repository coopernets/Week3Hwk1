using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ck;
            //The below array is used to track selections made by the user for drinks
            //It will increment the selections display on the fly
            int[] selections = new int[3];
            Console.WriteLine("Welcome to the Simple Drinks Machine");
            Console.WriteLine("");
            Console.WriteLine("Please select as many options as you would like below:");
            Console.WriteLine("");
            Console.WriteLine("1 – Tea, milk and sugar");
            Console.WriteLine("");
            Console.WriteLine("2 – Tea, milk only");
            Console.WriteLine("");
            Console.WriteLine("3 – Tea, sugar only");
            Console.WriteLine("");
            Console.WriteLine("4 – Finish Selections");
            Console.WriteLine("");
            //Using Console.ReadKey() I can let the use create selections and update automatically the selection list
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Selection Name          | Amount");
            Console.WriteLine("1 - Tea, milk and sugar | " + selections[0].ToString());
            Console.WriteLine("2 – Tea, milk only      | " + selections[1].ToString());
            Console.WriteLine("3 – Tea, sugar only     | " + selections[2].ToString());
            Console.WriteLine("--------------------------------------");
            ck = Console.ReadKey(true); //The existance of the true in this statement makes the keypress invisble in the console           
            do
            {
                switch (ck.Key)//Switch statement below has duplicates to handle both numpad and keyboard key presses
                {
                    case ConsoleKey.D1:
                        selections[0] = selections[0] + 1;
                        break;
                    case ConsoleKey.D2:
                        selections[1] = selections[1] + 1;
                        break;
                    case ConsoleKey.D3:
                        selections[2] = selections[2] + 1;
                        break;
                    case ConsoleKey.NumPad1:
                        selections[0] = selections[0] + 1;
                        break;
                    case ConsoleKey.NumPad2:
                        selections[1] = selections[1] + 1;
                        break;
                    case ConsoleKey.NumPad3:
                        selections[2] = selections[2] + 1;
                        break;
                }
                for (int i = 0; i < 4; )
                {
                    ClearLine();
                    i++;
                }
                Console.WriteLine("1 - Tea, milk and sugar | " + selections[0].ToString());
                Console.WriteLine("2 – Tea, milk only      | " + selections[1].ToString());
                Console.WriteLine("3 – Tea, sugar only     | " + selections[2].ToString());
                Console.WriteLine("--------------------------------------");
                ck = Console.ReadKey(true);
            } while (ck.Key != ConsoleKey.D4);
            Console.ReadLine();
        }
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
