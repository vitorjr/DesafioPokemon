using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Entities
{
    class Card
    {
        public string Nome { get; set; }
        //public string Expansao { get; set; }

        //public string Numeracao { get; set; }

        public string url_imagem { get; set; }

        public Card(string url_imagem)
        {
            this.url_imagem = url_imagem;
        }

        public override string ToString()
        {
            return "Nome: "+Nome;
        }
    }
}
