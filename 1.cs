using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            // ข้อ 1
            int i, j;
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());
            int n8 = int.Parse(Console.ReadLine());
            int n9 = int.Parse(Console.ReadLine());
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("");
                }
            }
            int n10 = int.Parse(Console.ReadLine());

            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            char[,] number = new char[w, h];
            for(int i = 0; i < h; i++)
            {
                for(int j = 0;j < w; j++)
                {
                    number[j, i] = char.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(number[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            }




        }
    }
}

