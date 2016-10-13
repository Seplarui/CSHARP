using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            suma s1 = new suma();
            Double V1=2, V2=2, V3=3, R1;
            /*  R1 = V1 + V2 + V3;
              Console.WriteLine("La suma es: " + R1);
              Console.ReadLine();
              */

            s1.sumita();
            Console.ReadLine();
        }

    }
    class suma
    {
        public void sumita()
        {
            Console.WriteLine("Esto es un método de la clase");
        }
    }
}
