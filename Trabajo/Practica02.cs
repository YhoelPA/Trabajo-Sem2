using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo
{
    internal class Practica02
    {
        static void Main(string[] args)
        {
            double cos_com, pre, mar_gan;

            mar_gan = 0.30;

            Console.WriteLine("Ingrese el costo de compra del producto: ");
            cos_com = double.Parse(Console.ReadLine());

            pre = cos_com + (cos_com * mar_gan);

            Console.WriteLine("El precio de venta del producto es: S/ " + pre.ToString("F2"));
        }
    }
}
