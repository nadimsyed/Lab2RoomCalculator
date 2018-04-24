using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Grand Circus Room Detail Generator!");

                Console.Write("Please put the Length of the room that you want to evaluate: ");
                double Length = double.Parse(Console.ReadLine());

                Console.Write("Please put the Width of the room that you want to evaluate: ");
                double Width = double.Parse(Console.ReadLine());

                Console.Write("Please put the Height of the room that you want to evaluate: ");
                double Height = double.Parse(Console.ReadLine());

                double Area = Length * Width;
                Console.WriteLine("Area : {0}", Area);

                double Perimeter = 2 * (Length + Width);
                Console.WriteLine("Perimeter : {0}", Perimeter);

                double Volume = Length * Width * Height;
                Console.WriteLine("Volume: {0}", Volume);

                Console.WriteLine("Continue? (y/n): \n");
                char check = Console.ReadKey().KeyChar;
                if (check == 'N' || check == 'n')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            
            
        }


    }
}
