using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculoo.br.com.gft.model

{
    public class Carro : Veiculo
    {
        public string marca { get; private set; }
        public int portas { get; private set;  }
        public int ano { get; private set; }

        public Carro(string modelo, int velocidade, int passageiros, int combustivel, string marca, int portas, int ano) : base(modelo, velocidade, passageiros, combustivel)
        {
        }

   

    }
}
