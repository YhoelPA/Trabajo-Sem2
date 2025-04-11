using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo
{
    internal class Practica03
    {
        static void Main(string[] args)
        {
            double sue_bru, desc, sue_net, por_desc;

            Console.WriteLine("Ingrese el sueldo bruto del trabajador: ");
            sue_bru = double.Parse(Console.ReadLine());
        
            if (sue_bru > 3000)
            {
                por_desc = 0.13;
            }
            else
            {
                por_desc = 0.11;
            }

            desc = sue_bru * por_desc;
            sue_net = sue_bru - desc;

            Console.WriteLine("El porcentaje de descuento aplicado es: " + por_desc * 100 + "%");
            Console.WriteLine("El monto descontado por AFP es: S/ " + desc.ToString("F2"));
            Console.WriteLine("El sueldo neto del trabajador es: S/ "+ sue_net.ToString("F2"));
    }
    }
}
