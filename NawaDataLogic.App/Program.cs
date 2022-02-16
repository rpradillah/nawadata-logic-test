using System;

namespace NawaDataLogic.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";

            while (answer.ToUpper() == "Y")
            {
                try
                {
                    Console.WriteLine("Please enter test number : ");
                    Console.WriteLine("1. Sorting Character");
                    Console.WriteLine("2. PSBB (Pembatasan Sosial Berskala Besar)");
                    Console.WriteLine("\n");
                    int iTest = int.Parse(Console.ReadLine());

                    switch (iTest)
                    {
                        case 1:
                            Test01 test01 = new Test01();
                            break;
                        case 2:
                            Test02 test02 = new Test02();
                            break;
                        default:
                            Console.WriteLine("Test is not available.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Continue ? (y/n)");
                answer = Console.ReadLine();
            }
        }
    }
}
