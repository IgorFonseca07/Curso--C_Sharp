using System;
using System.Globalization;

namespace Exerc01EstSeq {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira o primeiro número da soma: ");
            int soma1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número da soma: ");
            int soma2 = int.Parse(Console.ReadLine());
            Console.WriteLine("SOMA = " + (soma1 + soma2));
            Console.WriteLine("------------------------------------");


            Console.Write("Qual o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * (Math.Pow(raio, 2.0));
            Console.WriteLine("ÁREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------");


            Console.Write("Insira o valor inteiro A: ");
            int valora = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor inteiro B: ");
            int valorb = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor inteiro C: ");
            int valorc = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor inteiro D: ");
            int valord = int.Parse(Console.ReadLine());
            int diferenca = valora * valorb - valorc * valord;
            Console.WriteLine("DIFERENÇA = " + diferenca);
            Console.WriteLine("------------------------------------");


            Console.Write("Qual o número do funcionário? ");
            int numfunc = int.Parse(Console.ReadLine());
            Console.Write("Qual o total de horas trabalhadas no mês? ");
            int horast = int.Parse(Console.ReadLine());
            Console.Write("Qual o valor que recebe por hora? ");
            double valorh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horast * valorh;
            Console.WriteLine("NUMBER = " + numfunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------");


            Console.Write("Código do produto 1: ");
            int codprod1 = int.Parse(Console.ReadLine());
            Console.Write("Número de peças do produto 1: ");
            int quantprod1 = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário de cada produto 1: ");
            double valunitprod1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Código do produto 2: ");
            int codprod2 = int.Parse(Console.ReadLine());
            Console.Write("Número de peças do produto 2: ");
            int quantprod2 = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário de cada produto 2: ");
            double valunitprod2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valpagar = quantprod1 * valunitprod1 + quantprod2 * valunitprod2;
            Console.WriteLine("VALOR A PAGAR: R$ " + valpagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------");


            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areatriret = (a * c) / 2;
            double areacirc = pi * (Math.Pow(c, 2.0));
            double areatrap = ((a + b) * c) / 2;
            double areaquad = Math.Pow(b, 2.0);
            double arearet = a * b;
            Console.WriteLine("TRIANGULO: " + areatriret.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areacirc.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areatrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaquad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + arearet.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
