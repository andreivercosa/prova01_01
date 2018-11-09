using System;

namespace prova03_sistemaanimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.WriteLine("Informe a Raca do animal");
            animal.pegarRaca(Console.ReadLine());

            Console.WriteLine("Informe o nome do animal");
            animal.pegarNome(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("O animal com o nome {0} eh da raca {1}",
                              animal.devolveNome(), animal.devolveRaca());
        }
    }
}
