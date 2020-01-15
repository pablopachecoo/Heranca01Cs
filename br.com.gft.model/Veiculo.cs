using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculoo.br.com.gft.model
{
    public class Veiculo
    {
        public string modelo { get; private set; }
        public int velocidade {get; private set; }
        public int passageiros { get; private set; }
        public int combustivel { get; private set; }

    public Veiculo(string modelo, int velocidade, int passageiros, int combustivel)
        {
            this.modelo = modelo;
            this.velocidade = velocidade;
            this.passageiros = passageiros;
            this.combustivel = combustivel;
        }

       

    }
}
