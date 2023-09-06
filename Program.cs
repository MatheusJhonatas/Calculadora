using System;
using System.Numerics;
namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Seja Bem vindo a Calculadora Maths");
            Console.WriteLine("Digite o que deseja fazer seguindo as opções a baixo: ");
            Console.WriteLine("Opção 1 - Somar");
            Console.WriteLine("Opção 2 - Subtrair");
            Console.WriteLine("Opção 3 - Dividir");
            Console.WriteLine("Opção 4 - Multiplicar");
            Console.WriteLine("Opção 5 - Sair");
            Console.WriteLine("---------------------------------------------------------");
            short ResultadoMenu = short.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (ResultadoMenu)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); Console.WriteLine("Precisa selecionar uma das opções para seguir "); break;

            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Vamos somar dois números? ");
            Console.WriteLine("Digite o primeiro número para à soma : ");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine("");
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Vamos agora subtrair");
            Console.WriteLine("Digite o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número para subtração : ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float subtrair = v1 - v2;
            Console.WriteLine($"A subtração dos números é : {subtrair}");
            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Vamos agora dividir");
            Console.WriteLine("Digite o primeiro valor para a divisão : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Digite o segundo número : ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float divisao = v1 / v2;
            Console.WriteLine("A divisão dos números é : " + divisao);
            Console.WriteLine("Digite Enter para voltar ao menu ;)");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Vamos agora multiplicar");
            Console.WriteLine("Digite o primeiro número para multiplicar: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float multiplicacao = v1 * v2;
            Console.WriteLine($"O resultado da Multiplicação é: {multiplicacao}");
            Console.WriteLine("Digite ENTER para voltar ao menu");
            Console.ReadKey();
            Menu();
        }
    }

}