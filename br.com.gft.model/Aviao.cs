using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculoo.br.com.gft.model
{
    public class Aviao : Veiculo
    {
        public string tipo { get; private set; }
        public string uso { get; private set; }
        public Aviao(string modelo, int velocidade, int passageiros, int combustivel, string tipo, string uso) : base(modelo, velocidade, passageiros, combustivel)
        {
        }
    }
}
