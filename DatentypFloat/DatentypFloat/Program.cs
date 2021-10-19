using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatentypFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14F;
            Console.WriteLine("Unser pi hat den Wert: {0}", pi);
            float pi2 = 0.0314e2F; // 0,0314 * 10 hoch 2
            Console.WriteLine("Unser pi2 hat den Wert: {0}", pi2);

            float max = float.MaxValue;
            Console.WriteLine("Ein float hat auf diesem Rechner den maximal Wert (ohne :F): {0}", max);
            Console.WriteLine("Ein float hat auf diesem Rechner den maximal Wert (mit :F): {0:F}", max); // :F heißt dass man nicht den exponentiallen Wert sieht, sondern den richtigen Zahl

            // Einen Float hat genau 10 Stellen genauigkeit nach den Kommazahl!!
            float a = 123456789.01F;
            float b = 123456789.02F;
            Console.WriteLine("a hat den Wert: {0}", a);
            Console.WriteLine("b hat den Wert: {0}", b);

            // Einen double hat 16 Stellen genauigkeit
            Console.ReadLine();
        }
    }
}
