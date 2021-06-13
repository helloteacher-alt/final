using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            // ข้อ 3
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            {
                string mode = Console.ReadLine();
                do
                {
                    if (mode == "FindMax")
                    {
                        if (n1 > n2 && n1 > n3)
                        {
                            Console.WriteLine(n1);
                        }
                        else if (n2 > n1 && n2 > n3)
                        {
                            Console.WriteLine(n2);
                        }
                        else if (n3 > n1 && n3 > n2)
                        {
                            Console.WriteLine(n3);
                        }
                    }
                    else if (mode == "FindMin")
                    {
                        if (n1 < n2 && n1 < n3)
                        {
                            Console.WriteLine(n1);
                        }
                        else if (n2 < n1 && n2 < n3)
                        {
                            Console.WriteLine(n2);
                        }
                        else if (n3 < n1 && n3 < n1)
                        {
                            Console.WriteLine(n3);
                        }
                    }
                    else if (mode == "FindMean")
                    {
                        int n;
                        n = n1 + n2 + n3;
                        n = n / 3;
                        Console.WriteLine(n);
                    }

                } while (mode != "FindMax" && mode != "FindMin" && mode != "FindMean"); Console.WriteLine("Invalid mode");

            }



        }
    }
}

