using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            // ข้อ 4
            int namecity = Convert.ToInt32(Console.ReadLine());
            int[] numberCity = new int[namecity];
            int numbercityAROUND = int.Parse(Console.ReadLine());
            int numbercityAROUND2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCity.Length; i++)
            {
                if (numberCity[i] == numbercityAROUND2)
                {
                    Console.WriteLine("Invalid ID");
                }
            }



        }
    }
}

