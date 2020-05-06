using System;

namespace Class_Task_05_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine(car1.Speed);

            Console.WriteLine("Do you want to increase speed? If so, how many?");

            car1.AccelerationSpeed(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(car1.Speed);

            car1.LoweringSpeed(2);
            Console.WriteLine(car1.Speed);

            car1.StopCar();
            Console.WriteLine(car1.Speed);
        }
    }
}
