//Programmer: Brian Lee
//Date: 04/15/2024

//Title: Lecture Note 3

using System.Diagnostics.CodeAnalysis;

namespace CSI_120_Lecture_3_Notes
{
    internal class Program
    {
        static void Main(string[] args)S
        {
            IntegralVariableandMath();
            ParsingNumber();

            int number = 543;
            double length = Math.Floor(Math.Log10(number) + 1);
            int sumNum = 0;
            int newNum = number;

            for(int i = 0; i <length; i++)
            {
                sumNum = sumNum + newNum % 10;
                Console.WriteLine($"the sum is {sumNum}");

                newNum = newNum / 10;


            }

        }//end of main
        public static void IntegralVariableandMath()
        {
            byte e1a = 5;
            byte e1b = 3;

            byte e1sum = (byte)(e1a + e1b);

            Console.WriteLine($"{e1a} + {e1b} = {e1sum}");

            byte[,] num = { { 5, 3 }, { 10, 4 }, { 6, 2 }, { 12, 7 }, { 20, 9 }, { 4, 5 } };

            int i = 0;

            while (i < 6)
            {
                Console.WriteLine($"{num[i, 0]} + {num[i, 1]} = {num[i, 0] + num[i, 1]}");
                i = i + 1;
            }
        }//end of IntegralVariableandMath
        public static void ParsingNumber()
        {
            Console.WriteLine("Pleaser Enter you First Number");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

        }//end of ParsingNumber
    }//end of class
}// end of namespace
