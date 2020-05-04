using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Funcoes {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            int resultado2 = Maior(123, 598, 1056);

            Console.WriteLine("Maiores = " + resultado + " e " + resultado2);
            Console.WriteLine("----------------------");



            double x = 1.0;
            while (x != 0) {
                Console.Write("Digite um número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("----------------------");



            Console.Write("Quantos números inteiros você vai digitar? ");
            int numint = int.Parse(Console.ReadLine());
            int res = 0;

            for (int cond = 1; cond != (numint + 1); cond++) {
                Console.Write("Valor #" + cond + ": ");
                int som = int.Parse(Console.ReadLine());
                res += som;
            }

            Console.WriteLine("SOMA = " + res);
            Console.WriteLine("----------------------");




        }

        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;

        }
    }
}
