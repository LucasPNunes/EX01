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
            PJuridica pj1 = new PJuridica("1111111", "Apple", 10000);
            PJuridica pj2 = new PJuridica("2222222", "naiki", 4000);
            PJuridica pj3 = new PJuridica("3333333", "ualdisni", 8000);
            PJuridica pj4 = new PJuridica("4444444", "googoo", 9000);
            PJuridica pj5 = new PJuridica("5555555", "nvidia", 100100);

            PFisica pf1 = new PFisica("123", "Cassio", 5000);
            PFisica pf2 = new PFisica("345", "Lucas", 1000);
            PFisica pf3 = new PFisica("123", "Victor", 3600);
            PFisica pf4 = new PFisica("123", "Daniel", 2400.01);
            PFisica pf5 = new PFisica("123", "Otavio", 8000);

            Controladoria control = new Controladoria();

            Dictionary<int, Contribuinte> contribuintes = new Dictionary<int, Contribuinte>();
            contribuintes.Add(1, pf1);
            contribuintes.Add(2, pf2);
            contribuintes.Add(3, pf3);
            contribuintes.Add(4, pf4);
            contribuintes.Add(5, pf5);
            contribuintes.Add(6, pj1);
            contribuintes.Add(7, pj2);
            contribuintes.Add(8, pj3);
            contribuintes.Add(9, pj4);
            contribuintes.Add(10, pj5);

            foreach(KeyValuePair<int, Contribuinte> c in contribuintes)
            {
                
                Console.WriteLine("ID = {0}, Contribuinte = {1}", c.Key, c.Value);
                Console.WriteLine("Valor Imposto: " + c.Value.calculaImposto());
                control.gerenciaImpostos(c.Value);
            }
        }

    }
}
