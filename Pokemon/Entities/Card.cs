using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Entities
{
    class Card
    {
        public string Nome { get; set; }
        public string Expansao { get; set; }

        public int Numeracao { get; set; }

        public string url_imagem { get; set; }
    }
}
