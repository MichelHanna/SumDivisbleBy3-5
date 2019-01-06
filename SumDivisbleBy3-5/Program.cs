using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SumDivisbleBy3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter max number to calculate sum of divisibles of 3 & 5 or exit to quit");
            try
            {
                string maxNumber = Console.ReadLine();

                while (maxNumber != "exit")
                {
                    //Calculate divisibles by 3 & 5 
                    decimal sum = CalculateDivisbles(Convert.ToDecimal(maxNumber));
                    Console.WriteLine(sum);
                    maxNumber = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int CalculateDivisbles(decimal maxNumber)
        {
            int Sum = 0;
            try
            {
                for (int counter = 1; counter < maxNumber; counter++)
                    Sum += counter % 3 == 0 || counter % 5 == 0 ? counter : 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Sum;
        }
    }
}
