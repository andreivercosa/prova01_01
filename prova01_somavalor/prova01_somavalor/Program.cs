using System;

namespace prova01_somavalor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1o numero");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o 2o numero");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
        }
    }
}
