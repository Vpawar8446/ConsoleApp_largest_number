using System;

namespace ConsoleApp_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("Find the largest of three number :\n");
            Console.Write("Enter 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("The first number is the greater than three");
                }
                else
                {
                    Console.WriteLine("The thrid number is the greater than three");

                }
            }
            else if(num2>num3)
            {
                Console.WriteLine("The second number is the greater than three");

            }
            else
            {
                Console.WriteLine("The third number is the greater than three");

            }

        }
    }
}
