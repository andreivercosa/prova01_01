using System;

namespace prova06_sistemacliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Manaus");

            Console.Write("Informe seu Nome: ");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("{0} eh de {1}", cliente.nome, cliente.Cidadeinicializada());
        }
    }
}
