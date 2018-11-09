using System;
namespace soma
{
    public class Soma
    {
        public int resultado { set; get; }

        public Soma(int num1, int num2)
        {
            resultado = num1 + num2;
        }

        public Soma(int num1, int num2, int num3)
        {
            resultado = num1 + num2 + num3;
        }

        public Soma(int num1, int num2, int num3, int num4)
        {
            resultado = num1 + num2 + num3 + num4;
        }
    }
}
