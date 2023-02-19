using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[15];
            string temp;
            int num;

            for(int i = 0; i < 15; i++)
            {
                do
                {
                    Console.Write("Enter an integer number: ");
                    temp = Console.ReadLine();

                } while (int.TryParse(temp,out num)==false);
                
                number[i] = num;
            }

            Console.WriteLine();
            for(int i=0; i < 15; i++)
            {

                if((number[i] % 2) == 0)
                {
                    Console.WriteLine(number[i]);
                }
               
            }

            Console.ReadKey();
        }
    }
}
