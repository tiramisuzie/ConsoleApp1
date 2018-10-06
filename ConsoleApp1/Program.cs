using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MaxResult();
            LeapYear();
            PerfectSequence();
            SumOfRows();
            
        }

        //Problem 1: Array Max Result
        public static void MaxResult()
        {
            int[] numbers = { 6, 4, 4, 1, 3 };
            Console.Write("[ ");
            Console.Write(string.Join(",", numbers));

            Console.WriteLine(" ]");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number. 1 - 10");
                int selectedNumber = Int32.Parse(Console.ReadLine());
                int result = 0;
                foreach (var num in numbers)
                {
                    if (num == selectedNumber)
                    {
                        if (result == 0)
                        {
                            result = num;
                        }
                        else
                        {
                            result *= num;
                        }
                    }
                }
                Console.WriteLine("score " + result);
            }

            Console.WriteLine("End");
            Console.ReadLine();

        }

        public static void LeapYear()
        {

            Console.WriteLine("Please enter a year.");
            int year = Int32.Parse(Console.ReadLine());
            Boolean isLeapYear = false;
            if (year % 4 == 0)
            {
                isLeapYear = true;
                if (year % 100 == 0)
                {
                    isLeapYear = false;
                    if (year % 200 == 0)
                    {

                        isLeapYear = true;
                    }
                }
            }


            Console.WriteLine(isLeapYear);


            Console.WriteLine("End");
            Console.ReadLine();

        }

        public static void PerfectSequence()
        {

            int[] numbers = { 1, 3, 2 };
            Console.Write("Given Array: [ ");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine(" ]");
            int sumResult = 0;
            int productResult = 1;
            bool isNegative = false;
            foreach (var num in numbers)
            {
                sumResult += num;
                productResult *= num;
                if (num < 0)
                {
                    isNegative = true;
                }
            }
            Console.WriteLine(!isNegative && sumResult == productResult);
            Console.ReadLine();

        }
        public static void SumOfRows()
        {
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[] result = new int[myArray.GetLength(0)];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    result[i] += myArray[i, j];
                }
            }
            Console.Write("[ ");
            Console.Write(string.Join(",", result));

            Console.WriteLine(" ]");
            Console.ReadLine();

        }
    }
}


