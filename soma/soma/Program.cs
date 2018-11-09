using System;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 1, numero2 = 2, numero3 = 3, numero4 = 4;

            Soma soma = new Soma(numero1, numero2);
            Soma soma2 = new Soma(numero1, numero2, numero3);
            Soma soma3 = new Soma(numero1, numero2, numero3, numero4);

            Console.WriteLine("Soma: {0}\nSoma2: {1}\nSoma3: {2}", soma.resultado, soma2.resultado,soma3.resultado);
        }
    }
}
