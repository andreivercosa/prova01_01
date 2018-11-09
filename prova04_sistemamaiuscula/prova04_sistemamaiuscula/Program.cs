using System;

namespace prova04_sistemamaiuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome completo: ");
            string fullname = Console.ReadLine().ToUpper();

            Console.Clear();

            Console.WriteLine("O nome informado foi: {0}", fullname);
        }
    }
}
