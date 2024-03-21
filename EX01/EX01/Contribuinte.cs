using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Contribuinte
    {
        protected string nome { get; set; }

        protected double rendaBruta { get; set; }

        public Contribuinte()
        {

        }

        public Contribuinte(string nome, double rendaBruta)
        {
            this.nome = nome;
            this.rendaBruta = rendaBruta;
        }

        public virtual double calculaImposto()
        {
            return this.rendaBruta;
        }
    }
}
