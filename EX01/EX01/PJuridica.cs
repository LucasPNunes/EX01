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
            return rendaBruta * 0.1;
        }
        public override string getDadosContribuinte()
        {
            return "\nTipo: Pessoa Juridica" + base.getDadosContribuinte() + "\nCNPJ: " + cnpj;
        }

        public override double calculaJuros(double valorEmprestimo)
        {
            return base.calculaJuros(valorEmprestimo) * 0.1;
        }

    }
}
