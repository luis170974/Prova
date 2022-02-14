using System;

/* 
  
  Para construir um triângulo é necessário que a medida de qualquer um dos lados seja menor que a
soma dos outros dois lados

 a) Crie uma aplicação Console Application que receba três valores X, Y, Z, escrever uma mensagem
informando se é um triângulo eqüilátero, isósceles ou escaleno. Abaixo segue as possibilidades possíveis:

• Eqüilátero: Todos os lados iguais
• Isósceles: Dois lados iguais
• Escaleno: Todos os lados diferentes

b) Caso algum comprimento dos lados do triângulo for inválido, escrever a mensagem “Triângulo
Inválido”
c) O usuário poderá verificar vários triângulos, ou seja, crie um menu de opções que possibilite isso.*/

namespace Prova.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {

                
                
                Console.WriteLine("##############################");
                Console.WriteLine("Bem vindo!");
                Console.WriteLine("1. para calcular um triangulo!");
                Console.WriteLine("s. para sair!");
                Console.WriteLine("##############################");

                opcao = Console.ReadLine();

                

                if (opcao != "1" && opcao != "s")
                {
                    Console.WriteLine("opção invalida!");
                    continue;
                }
                 if(opcao == "s") {

                    break;
                }

                Console.WriteLine("Digite um valor para X: ");

                int valorX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite um valor para Y: ");

                int valorY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite um valor para Z: ");

                int valorZ = Convert.ToInt32(Console.ReadLine());

                if (valorX > (valorY + valorZ) || valorY > (valorZ + valorX) || valorZ > (valorX + valorY))
                {
                    
                    Console.WriteLine("Triangulo Inválido");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (valorX == valorY && valorY == valorZ)
                {

                    Console.WriteLine("Triangulo Eqüilátero");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (valorX == valorY || valorY == valorZ)
                {

                    Console.WriteLine("Triangulo Isósceles");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (valorX != valorY && valorY != valorZ)
                {

                    Console.WriteLine("Triangulo Escaleno");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            while (opcao == "1");
        
        }
    }
}
