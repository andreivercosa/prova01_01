using System;

namespace prova02_concatenar
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            for (int i = 1; i <= 3; i++ ){
                Console.WriteLine("Informe nome ou sobrenome");
                nome += Console.ReadLine() + " ";
            }

            Console.WriteLine(nome);
        }
    }
}
