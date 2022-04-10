using Lab2.Controller;
using System;

namespace Lab.View.ConsoleApp
{
    internal class Program
    {
        private static SumController controller = new SumController();
        static void Main(string[] args)
        {
            var aString = Console.ReadLine();
            var bString = Console.ReadLine(); 

            var a = double.Parse(aString);  
            var b = double.Parse(bString); 

            controller.ParamsModel.A = a;
            controller.ParamsModel.B = b; 
            controller.CalculateSum();

            Console.WriteLine($"{a} + {b} = {controller.SumModel.Sum}");

        }
    }
}
