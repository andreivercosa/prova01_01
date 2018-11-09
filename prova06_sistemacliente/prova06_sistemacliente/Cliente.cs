using System;
namespace prova06_sistemacliente
{
    public class Cliente
    {
        string cidade;

        public Cliente(string cidade)
        {
            this.cidade = cidade;
        }

            public string nome { get; set; }
        public string Cidadeinicializada(){
            return cidade;
        }
    }
}

