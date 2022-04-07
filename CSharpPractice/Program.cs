using System;

namespace CSharpPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConvertToSeconds(5);
            //Console.WriteLine("to find area of traingle");
            //Console.Write("enter side");
            //float side = Convert.ToSingle(Console.ReadLine());
            // Console.Write("enter height");
            // float height = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine($"Area of triangle with side {side} and height {height} is");
            // IsSumLessThanHundred(10, 50);
            // IsSumLessThanHundred(52, 0);
            // IsSumLessThanHundred(100, 1);
            //NameShuffle("sai ram");
            //NameShuffle("lord shiva");

            int num = 0;
            do
            {
                num =Convert.ToInt16(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("to calculate fact ");
                    }

            }
            while (num < 0);
            Console.WriteLine($"{num}! = {factorial(num)}");
}
        static double AreaofTriangle(float side, float height)
        {
            return (double)(side * height / 2);

        }
        static void IsSumLessThanHundred(int num, int num2)
        {
            if (num +num2 <100)
                Console.WriteLine($"sum of {num}  + { num2} is less than 100");
                   
        }
        /// <param name="fullName"></Param>
        static void NameShuffle(string fullname)
        {
            string[] nameArray = fullname.Split(' ');
            Console.WriteLine($"{fullname}\" --> {nameArray[1]} {nameArray[0]}");
        } 
        static long factorial(int num)
        {
            long factorial = 1;
            for(int i=num;i>0;i--)
            {
                factorial *= i;
            }
            return factorial;

            //recursive way
            if (num > 0)
                return num * factorial(num - 1);
            
             return 1;
        }
    }
}
