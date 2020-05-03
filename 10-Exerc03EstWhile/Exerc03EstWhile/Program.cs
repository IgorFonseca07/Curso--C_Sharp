using System;

namespace Exerc03EstWhile {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a senha: ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002) {                
                Console.Write("SENHA INVÁLIDA! Insira novamente a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("ACESSO PERMITIDO!");
            Console.WriteLine("--------------------------------------------");



            int x = 1;
            int y = 1;
            while (x != 0 && y != 0) {
                Console.Write("Coordenada X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Coordenada Y: ");
                y = int.Parse(Console.ReadLine());
                if (x > 0 && y > 0) {
                    Console.WriteLine("PRIMEIRO");
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("SEGUNDO");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("TERCEIRO");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("QUARTO");
                }
                else {
                    Console.WriteLine("SE ENCONTRA EM UM DOS EIXOS OU NA ORIGEM");
                }             
            }
            Console.WriteLine("--------------------------------------------");



            int comb = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (comb != 4) {
                Console.Write("Qual o código do combustível abastecido? ");
                comb = int.Parse(Console.ReadLine());
                if (comb == 1) {
                    alcool++;
                }
                else if (comb == 2) {
                    gasolina++;
                }
                else if (comb == 3) {
                    diesel++;
                }
                else if (comb != 4) {
                    Console.WriteLine("CÓDIGO INVÁLIDO! Insira o combustível abaixo ou digite 4 para sair:");
                }
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);


        }
    }
}
