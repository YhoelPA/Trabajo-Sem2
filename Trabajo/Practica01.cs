using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trabajo
{
    internal class Practica01
    {

        static void Main(string[] args)
        {
            string nomb;
            double pre, igv, mon, total;

            mon = 0.18;

            Console.WriteLine("Ingrese el nombre del producto: ");
            nomb = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto: ");
            pre = double.Parse(Console.ReadLine());

            igv = pre * mon;
            total = pre + igv;

            Console.WriteLine("Producto: " + nomb);
            Console.WriteLine("Precio base: S/ " + pre.ToString("F2"));
            Console.WriteLine("IGV (18%): S/ " + igv.ToString("F2"));
            Console.WriteLine("Total a pagar: S/ " + total.ToString("F2"));
        }
    }
}