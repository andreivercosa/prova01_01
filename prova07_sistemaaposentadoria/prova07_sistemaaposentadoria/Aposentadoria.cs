using System;
namespace prova07_sistemaaposentadoria
{
    public class Aposentadoria
    {
        private int opsexo;

        public int sexo { get; set; }
        public int idade { get; set; }


        public void dadosTela(){
            Console.WriteLine("Informe uma Opcao:\n1 - Masculino\n2 - Feminino");
            opsexo = Convert.ToInt32(Console.ReadLine());

            switch(opsexo){
                case 1:
                    sexo = opsexo;
                    Console.WriteLine("Informe a idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    resultado();
                    break;
                case 2:
                    sexo = opsexo;
                    Console.WriteLine("Informe a idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    resultado();
                    break;
                default:
                    Console.WriteLine("\nOpcao incorreta");
                    break;
            }



        }


        public void resultado(){
            if(sexo == 1 & idade >=65){
                Console.WriteLine("\nAPTO para receber o beneficio.");
            }else if(sexo == 2 & idade >=60){
                Console.WriteLine("\nAPTO para receber o beneficio.");
            }else{
                Console.WriteLine("\nINAPTO  para receber o beneficio.");
            }
        }

        public Aposentadoria()
        {
        }
    }
}
