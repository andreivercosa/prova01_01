using System;
namespace testandostring
{
    public class Separarnome
    {
        //public string nome {get;set;}
        string nome = "";

        public void separar()
        {
            Console.WriteLine("Informe seu nome completo: ");
            nome = Console.ReadLine();


            string[] partes = nome.Split(" ");

            int posicao = 0;
            foreach (var i in partes)
            {
                Console.WriteLine("Posicao: {0} Valor: {1} ", posicao, i);
                posicao++;
            }
        }
    }
}
