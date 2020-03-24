using System;

namespace ClassWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number one : ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // קליטת מס' שייקבע את אורך המערך

            Console.WriteLine("Enter a number two : "); 
            int num2 = Convert.ToInt32(Console.ReadLine()); // קליטת מס' שייקבע בכמה להכפיל את האינדקס

            int[] arr1 = new int[num1]; // הגדרת מערך
            Console.WriteLine($"Size of array: {num1}\nMultiply the array: {num2}"); // פלט שמציין את גודל המערך ומכפלתו,כפי שהגדיר המשתמש

            for (int i = 0; i < num1; i++) 
            {
                arr1[i] = i * num2;
                Console.Write(arr1[i]+",");
            }

            Console.ReadKey();
        }
    }
}
