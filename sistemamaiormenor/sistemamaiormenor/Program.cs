using System;

namespace sistemamaiormenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0, test, numero=0, maior=0, menor=9999999;

            Console.WriteLine("Informe a quantidade: ");
            test = Int32.Parse(Console.ReadLine());

            while(quantidade < test){
                Console.WriteLine("\nInforme um numero: ");
                numero = Int32.Parse(Console.ReadLine());

                if(numero > maior){
                    maior = numero;
                }
                if (numero < menor ){
                    menor = numero;
                }
                quantidade++;
            }
            Console.WriteLine("\nMaior: {0}\nMenor: {1}\nSoma: {2}", maior, menor, (maior+menor));
        }
    }
}
