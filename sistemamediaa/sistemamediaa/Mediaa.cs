using System;
namespace sistemamediaa
{
    public class Mediaa
    {
        private double valor = 0;
        private int qtd;

        public void mediaaritimetica (){
            Console.WriteLine("Informe uma quantidade: ");
            qtd = Int32.Parse(Console.ReadLine());

            for(int a = 1; a <= qtd; a++ ){
                Console.WriteLine("\nInforme um valor: ");
                valor += Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("A media aritimetica eh: " + Math.Round((valor/qtd),2));
        }


            public Mediaa()
        {
        }
    }
}
