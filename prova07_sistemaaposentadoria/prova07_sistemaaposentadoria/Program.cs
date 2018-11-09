using System;

namespace prova07_sistemaaposentadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            do
            {
                Aposentadoria aposentadoria = new Aposentadoria();

                aposentadoria.dadosTela();


                Console.WriteLine("\nDeseja Continuar\n1 - SIM\n2 - NAO");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

            } while (op == 1);


        }
    }
}
