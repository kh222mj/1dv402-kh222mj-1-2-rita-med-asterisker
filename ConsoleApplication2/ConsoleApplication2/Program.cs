using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 25; row++)
            {
                //Färgsättning på rader
                switch(row % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                
                //Skjuter in raden
                if (row % 2 == 1)
                {
                    Console.Write(" ");
                }

                //Skriv ut *
                for (int col = 0; col < 39; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }  

        }
    }
}