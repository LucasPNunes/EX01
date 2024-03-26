using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class PFisica : Contribuinte
    {
        private string cpf { get; set; }

        public PFisica(string cpf, string nome, double rendaBruta)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.rendaBruta = rendaBruta;

        }

        public override double calculaImposto()
        {
            if(rendaBruta > 3600)
            {
                return (rendaBruta)*0.3;
            }
            if(rendaBruta > 2800)
            {
                return rendaBruta * 0.25;
            }
            if(rendaBruta > 2100)
            {
                return rendaBruta * 0.15;
            }             
            if (rendaBruta > 1400)
            {
                return rendaBruta * 0.1;
            }          
            return rendaBruta * 0;
        }
    }
}
