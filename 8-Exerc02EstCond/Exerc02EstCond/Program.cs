using System;
using System.Globalization;

namespace Exerc02EstCond {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira o número inteiro A: ");
            int multia = int.Parse(Console.ReadLine());
            Console.Write("Insira o número inteiro B: ");
            int multib = int.Parse(Console.ReadLine());
            if (multia >= multib) {
                if (multia % multib == 0) {
                    Console.WriteLine("SÃO MULTIPLOS!");
                }
                else {
                    Console.WriteLine("NÃO SÃO MULTIPLOS!");
                }
            }
            else if (multib > multia) {
                if (multib % multia == 0) {
                    Console.WriteLine("SÃO MULTIPLOS!");
                }
                else {
                    Console.WriteLine("NÃO SÃO MULTIPLOS!");
                }
            }
            Console.WriteLine("----------------------------------");


            Console.Write("Hora inicial do jogo: ");
            int horaini = int.Parse(Console.ReadLine());
            Console.Write("Hora final do jogo: ");
            int horafin = int.Parse(Console.ReadLine());
            int horares;
            if (horaini < horafin) {
                horares = horafin - horaini;
                Console.WriteLine("O JOGO DUROU " + horares + " HORA(S)");
            }
            else {
                horares = 24 - (horaini - horafin);
                Console.WriteLine("O JOGO DUROU " + horares + " HORA(S)");
            }
            Console.WriteLine("----------------------------------");


            Console.Write("Insira o código do seu produto ");
            int codigop = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade consumida deste item: ");
            int quantp = int.Parse(Console.ReadLine());
            double valorp = 0.0;
            if (codigop == 1) {
                valorp = quantp * 4.00;
                Console.WriteLine("TOTAL: R$ " + valorp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigop == 2) {
                valorp = quantp * 4.50;
                Console.WriteLine("TOTAL: R$ " + valorp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigop == 3) {
                valorp = quantp * 5.00;
                Console.WriteLine("TOTAL: R$ " + valorp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigop == 4) {
                valorp = quantp * 2.00;
                Console.WriteLine("TOTAL: R$ " + valorp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigop == 5) {
                valorp = quantp * 1.50;
                Console.WriteLine("TOTAL: R$ " + valorp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("CÓDIGO INVÁLIDO!");
            }
            Console.WriteLine("----------------------------------");



        }
    }
}
