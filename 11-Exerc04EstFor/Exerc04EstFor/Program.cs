using System;
using System.Globalization;

namespace Exerc04EstFor {
    class Program {
        static void Main(string[] args) {

            Console.Write("Até qual número iremos contar os ímpares? ");
            int x = int.Parse(Console.ReadLine());
            int contador = 0;
            for (int i = 1; i <= x; i += 2) {
                Console.WriteLine(i);
                contador++;
            }
            Console.WriteLine("A contagem teve um total de " + contador + " números ímpares");
            Console.WriteLine("------------------------------------------------------------");



            Console.Write("Quantos valores inteiros serão lidos? ");
            int quantvalint = int.Parse(Console.ReadLine());
            int[] valint = new int[quantvalint];
            int numin = 0;
            int numout = 0;
            for (int i = 0; i < quantvalint; i++) {
                Console.Write("Valor inteiro #" + (i + 1) + ": ");
                valint[i] = int.Parse(Console.ReadLine());
                if (valint[i] > 10 && valint[i] < 20) {
                    numin++;
                }
                else if (valint[i] < 10 || valint[i] > 20) {
                    numout++;
                }
            }
            Console.WriteLine(numin + "in");
            Console.WriteLine(numout + "out");
            Console.WriteLine("------------------------------------------------------------");



            Console.Write("Quantos casos de teste serão feitos? ");
            int numcastes = int.Parse(Console.ReadLine());
            double[] resfin = new double[numcastes];
            for (int i = 0; i < numcastes; i++) {
                double[] castes = new double[3];
                Console.WriteLine("Insira os 3 valores deste teste de caso, em ordem: ");
                castes[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                castes[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                castes[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                resfin[i] = ((castes[0] * 2) + (castes[1] * 3) + (castes[2] * 5)) / 10;
            }
            for (int i = 0; i < numcastes; i++) {
                Console.WriteLine("Média ponderada #" + i + ": " + resfin[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("------------------------------------------------------------");



            Console.Write("Quantos pares de números serão lidos? ");
            int numpares = int.Parse(Console.ReadLine());
            string[] resdivi = new string[numpares];
            for (int i = 0; i < numpares; i++) {
                Console.Write("Insira os dois números da divisão: ");
                string[] pares = Console.ReadLine().Split(' ');
                double n1 = double.Parse(pares[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(pares[1], CultureInfo.InvariantCulture);
                if (n2 == 0) {
                    resdivi[i] = "divisão impossível";
                }
                else {                                        
                    resdivi[i] = (n1 / n2).ToString(CultureInfo.InvariantCulture);
                }
            }
            for (int i = 0; i < numpares; i++) {
                Console.WriteLine("E o resultado #" + (i + 1) + " foi: " + resdivi[i], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("------------------------------------------------------------");



            Console.Write("Iremos calcular o fatorial de qual número? ");
            int fatorial = int.Parse(Console.ReadLine());
            int resfatorial = fatorial;
            if (fatorial == 1 || fatorial == 0) {
                Console.WriteLine("FATORIAL: 1");
            }
            else {
                for (int i = 0; i < fatorial; i++) {
                    resfatorial = resfatorial * (fatorial - 1);
                    fatorial -= 1;
                }
                Console.WriteLine("FATORIAL: " + resfatorial);
            }
            Console.WriteLine("------------------------------------------------------------");



            Console.Write("Insira um número e iremos mostrar todos os seus divisores abaixo: ");
            int div = int.Parse(Console.ReadLine());
            for (int i = 1; i <= div; i++) {
                if ((div % i) == 0) {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("------------------------------------------------------------");



            Console.Write("Insira um número! Será feito o quadrado e o cubo dele e de sua contagem regressiva: ");
            int quadcubo = int.Parse(Console.ReadLine());
            int[] contreg = new int[quadcubo];
            double[] quad = new double[quadcubo];
            double[] cubo = new double[quadcubo];
            int a = quadcubo;
            for (int i = 0; i < quadcubo; i++) {
                contreg[i] = a;
                a -= 1;
            }            
            for (int i = 0; i < quadcubo; i++) {
                quad[i] = Math.Pow(contreg[i], 2.0);
            }
            for (int i = 0; i < quadcubo; i++) {
                cubo[i] = Math.Pow(contreg[i], 3.0);
            }
            for (int i = (quadcubo - 1); i != -1; i--) {
                Console.WriteLine($"{contreg[i]} {quad[i]} {cubo[i]}");
            }

        }
    }
}
