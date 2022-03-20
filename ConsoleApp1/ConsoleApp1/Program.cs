using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Scored number: " + ArrayMaxResult());
            //Console.WriteLine("Enter Year");
            //int Year = Convert.ToInt32(Console.ReadLine());

            //if (IsLeapYear(Year) == true)
            //    Console.WriteLine("Is Leap Year");
            //else
            //    Console.WriteLine("Isnt Leap Year");
            //int[] arr = { 1, 3, 2 };
            //Console.WriteLine(PerfectSequence(arr)); 
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[] myArray2 = SumOfRows(myArray);
            for (int i = 0; i < myArray2.Length; i++)
                Console.WriteLine(myArray2[i]);
           


        }
        static  int ArrayMaxResult()
        {
            int[] arr = new int[5];
            int count = 0;
           for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter 5 numbers between 1-10:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 1 || n > 10)
                {
                    Console.WriteLine("number in NOT between 1 and 10");
                    i--;
                    continue;
                }

                arr[i] = n;                
            }
             int numrep = 0;
            Console.WriteLine("Enter score number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    numrep++;
            }

            return numrep * num;
        }
        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                return true;
            else if (year % 4 == 0 && year % 100 == 0)
                return false;
            else if (year % 4 == 0)
                return true;
            else
                return false;
        }
        static string PerfectSequence(int[] arr)
        {
            int sum = 0;
            int multiply = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                

                sum += arr[i];
                multiply *= arr[i];
            }

            if (sum == multiply)
                return "YES";
            else
            return "NO";
        }
        static int[] SumOfRows(int[,] myArray)
        {
            int[] result = new int[myArray.GetLength(0)];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    result[i] += myArray[i, j];
                }
            }

            return result;
        }
    }
}
