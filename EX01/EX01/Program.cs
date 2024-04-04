using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controladoria control = new Controladoria();

            Dictionary<int, Contribuinte> contribuintes = new Dictionary<int, Contribuinte>();
            contribuintes.Add(1, new PFisica("123", "Cassio", 5000));
            contribuintes.Add(2, new PFisica("345", "Lucas", 1000));
            contribuintes.Add(3, new PFisica("123", "Victor", 3600));
            contribuintes.Add(4, new PFisica("123", "Daniel", 2400.01));
            contribuintes.Add(5, new PFisica("123", "Otavio", 8000));
            contribuintes.Add(6, new PJuridica("1111111", "Apple", 10000));
            contribuintes.Add(7, new PJuridica("2222222", "naiki", 4000));
            contribuintes.Add(8, new PJuridica("3333333", "ualdisni", 8000));
            contribuintes.Add(9, new PJuridica("4444444", "googoo", 9000));
            contribuintes.Add(10, new PJuridica("5555555", "nvidia", 100100));

            foreach(KeyValuePair<int, Contribuinte> c in contribuintes)
            {              
                Console.WriteLine("\nID = {0}, {1}", c.Key, c.Value.getDadosContribuinte());
                Console.WriteLine("Valor Imposto: " + c.Value.calculaImposto());
                Console.WriteLine("Valor do juros: " + c.Value.calculaJuros(100));
                control.gerenciaImpostos(c.Value);
            }

            Console.WriteLine("\nTotal de Imposto Pessoa fisica: " + control.totalImpostosPF);
            Console.WriteLine("\nTotal de Imposto Pessoa juridica: " + control.totalImpostosPJ);
            Console.WriteLine("\nTotal de Impostos pagos: " + control.totalizaImpostos());
        }

    }
}
