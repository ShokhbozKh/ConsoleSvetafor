using System.Drawing;
using System.IO;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console svetafor yaratish ranglar bilan
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter color (1:Red, 2:Green, 3:Yellow):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch(n)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Color: "  +Color.Red);
                    Console.WriteLine(" Stop....");
                    Timer();
                    Console.ResetColor();
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(Color.Yellow);
                    Console.WriteLine("Color: " + Color.Red);
                    Console.WriteLine(" Get Ready....");
                    Timer();
                    Console.ResetColor();
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(Color.Green);
                    Console.WriteLine("Color: " + Color.Green);
                    Console.WriteLine(" Let's Gooo...");
                    Timer();
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("xatolik bor"); break;
            }
            Console.Clear();
            Main(args);

        }
        static void Timer()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    enum Color
    {
        Red,
        Yellow,
        Green
    }

}