using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mojDom = new Dom("Activ 1","aktívny","nie", 3, 30.9f, 15.7f);
            mojDom.PoskytniInformacie();
            Console.Write("Percento zastavanej plochy je: {0}\n\n", mojDom.ZistiVyuzitelnostZastavanejPlochy());

            Dom susedovDom = new Dom("Activ 2", "aktívny", "nie", 3, 130.9f, 80.7f);
            susedovDom.PoskytniInformacie();
            Console.Write("Percento zastavanej plochy je: {0}\n\n", susedovDom.ZistiVyuzitelnostZastavanejPlochy());

            Chata chata = new Chata("Chata 1", "pasívny", "nie", 6, 1500, 220, "áno veľká");
            chata.PoskytniInformacie();
            chata.PopisChaty();

            Console.ReadLine();

        }
    }
}
