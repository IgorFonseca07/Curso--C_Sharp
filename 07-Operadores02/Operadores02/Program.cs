using System;
using System.Globalization;

namespace Operadores02 {
    class Program {
        static void Main(string[] args) {

            bool c1 = 2 > 3 && 4 != 5;
            bool c2 = 2 > 3 || 4 != 5;
            bool c3 = !(2 > 3 || 4 != 5);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("----------");


            Console.Write("Insira as horas a seguir, desconsiderando minutos e segundos: ");
            int horas = int.Parse(Console.ReadLine());

            if (horas <= 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (horas <= 18) {
                Console.WriteLine("Boa tarde!");
            }
            else if (horas <= 24) {
                Console.WriteLine("Boa noite!");
            }
            else {
                Console.WriteLine("Hora inválida!");
            }
            Console.WriteLine("----------");


            Console.Write("Insira o número para verificar se o mesmo é par ou ímpar: ");
            double parimpar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (parimpar % 2.0 == 0.0) {
                Console.WriteLine("PAR!");
            }
            else {
                Console.WriteLine("ÍMPAR!");
            }




        }
    }
}
