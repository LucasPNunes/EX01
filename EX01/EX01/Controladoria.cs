using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Controladoria
    {
        private double totalImpostos { get; set; }   
        private double totalImpostosPF { get; set; }

        private double totalImpostosPJ { get; set; }

        public Controladoria()
        {
        }

        public void gerenciaImpostos(Contribuinte c)
        {
            if (c.GetType() == typeof(PFisica))
            {
                totalImpostosPF += c.calculaImposto();
            }
            else
            {
                totalImpostosPJ += c.calculaImposto();
            }
            totalImpostos += c.calculaImposto();
        }


    }
}
