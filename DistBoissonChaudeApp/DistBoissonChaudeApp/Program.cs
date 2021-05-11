using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaude
{
    class Program
    {
        static void Main(string[] args)
        {
            BoissonChaude boissonChaude = new BoissonChaude();

            Console.WriteLine("Distributeur automatique de boisson chaude : ");
            Console.WriteLine("-- Prix Expresso = {0}", boissonChaude.prix(eBoissonChaude.Expresso));
            Console.WriteLine("-- Prix Allonge = {0}", boissonChaude.prix(eBoissonChaude.Allonge));
            Console.WriteLine("-- Prix Chocolat = {0}", boissonChaude.prix(eBoissonChaude.Chocolat));
            Console.WriteLine("-- Prix Capucino = {0}", boissonChaude.prix(eBoissonChaude.Capucino));
            Console.WriteLine("-- Prix The = {0}", boissonChaude.prix(eBoissonChaude.The));
            Console.ReadLine();
        }
    }
}
