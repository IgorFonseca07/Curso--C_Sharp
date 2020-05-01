using System;

namespace Operadores {
    class Program {
        static void Main(string[] args) {

            double n1 = (double)10 / 8;
            double n2 = 10.0 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine("-----");


            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            double alternativo = (-b + Math.Sqrt(Math.Pow(b, 2.0) - 4.0 * a * c)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(alternativo);
            Console.WriteLine("-----");

            a += 2;
            Console.WriteLine(a);

            a *= 9;
            Console.WriteLine(a);

            string u = "ABC";
            Console.WriteLine(u);

            u += "DEF";
            Console.WriteLine(u);

            a++;
            Console.WriteLine(a);
            Console.WriteLine("-----");

            a = 10;
            b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 10;
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("-----");

            double m;
            float n;

            n = 5.1f;
            m = n;

            Console.WriteLine(n + " e " + m);

            m = 5.1;
            n = (float)m;

            Console.WriteLine(m + " e " + n);

            int o = 5;
            int p = 2;
            double resultado = (double)o / p;

            Console.WriteLine(resultado);




        }
    }
}
