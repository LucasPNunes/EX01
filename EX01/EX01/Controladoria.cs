using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Controladoria
    {
        public double totalImpostos { get; set; }
        public double totalImpostosPF { get; set; }
        public double totalImpostosPJ { get; set; }

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
        }

        public double totalizaImpostos()
        {
            totalImpostos = totalImpostosPJ + totalImpostosPF;
            return totalImpostos;
        }

    }
}
