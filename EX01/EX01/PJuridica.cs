using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class PJuridica : Contribuinte
    {
        private string cnpj { get; set; }

        public PJuridica(string cnpj, string nome, double rendaBruta)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.rendaBruta = rendaBruta;
        }

        public override double calculaImposto()
        {
            return base.calculaImposto() * 0.1;
        }
    }
}
