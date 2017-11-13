using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvutustabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Multiplication Tables");
            Console.WriteLine("X \t 1 \t 2 \t 3 \t 4 \t 5 \t 6 ");
            Console.Write("1");

            for (int i = 1; i <= 6; i++)
            {
                int j = 1;
                {
                    Console.Write(" \t " + i * j);
                }
            }
            Console.WriteLine();
            Console.Write("2");
            for (int i = 1; i <= 6; i++)
            {
                int j = 2;
                {
                    Console.Write(" \t " + i * j);
                }
            }
            Console.WriteLine();
            Console.Write("3");
            for (int i = 1; i <= 6; i++)
            {
                int j = 3;
                {
                    Console.Write(" \t " + i * j);
                }
            }
            Console.WriteLine();
            Console.Write("4");
            for (int i = 1; i <= 6; i++)
            {
                int j = 4;
                {
                    Console.Write(" \t " + i * j);
                }
            }
            Console.WriteLine();
            Console.Write("5");
            for (int i = 1; i <= 6; i++)
            {
                int j = 5;
                {
                    Console.Write(" \t " + i * j);
                }
            }
            Console.WriteLine();
            Console.Write("6");
            for (int i = 1; i <= 6; i++)
            {
                int j = 6;
                {
                    Console.Write(" \t " + i * j);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Uus tabel");
            

            for (int i = 0; i <= 6; i++)
            {
                Console.Write(i + "\t");

                for (int j = 1; j <= 6; j++)
                {
                    if (i > 0)
                        Console.Write(i * j + "\t");
                    else
                        Console.Write(j + "\t");

                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
