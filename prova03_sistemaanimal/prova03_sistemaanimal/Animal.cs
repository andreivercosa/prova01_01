using System;
namespace prova03_sistemaanimal
{
    public class Animal
    {
        private string raca; 
        private string nome;

        public void pegarRaca(string raca)
        {
            this.raca = raca;
        }

        public void pegarNome(string nome){
            this.nome = nome;
        }

        public string devolveRaca(){
            return raca;
        }

        public string devolveNome()
        {
            return nome;
        }
        public Animal()
        {
        }
    }
}
