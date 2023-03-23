using System;


namespace CalculadoraDoCURSO
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
        static void Main(string[] args)
        {


            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário não escolher sair  //exiba o MENU
            {
                Console.WriteLine("Seja Bem-Vindo!");

                Console.WriteLine("CALCULADORA CRIADA POR ANDRÉ KAIQUE DELL ISOLA!");
                Console.WriteLine("Selecione Uma opção!");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair Do Menu");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Divisao:
                        divisao();
                        break;

                    case Menu.Multiplicacao:
                        multiplicacao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;



                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }



                Console.Clear();
            }


        }

        static void Soma()
        {
            Console.WriteLine("Soma de Dois números");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado de {a} + {b} é: {resultado} ");
            Console.WriteLine("\nObrigado por usar meu Software");
            Console.WriteLine("\n+=============================+");
            Console.WriteLine("Aperte [ENTER] Para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtracao de Dois números");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado de {a} - {b} é: {resultado} ");
            Console.WriteLine("\nObrigado por usar meu Software");
            Console.WriteLine("\n+=============================+");
            Console.WriteLine("Aperte [ENTER] Para voltar ao menu");
            Console.ReadLine();
        }

        static void divisao()
        {
            Console.WriteLine("divisao de Dois números");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado de {a} / {b} é: {resultado} ");
            Console.WriteLine("\nObrigado por usar meu Software");
            Console.WriteLine("\n+=============================+");
            Console.WriteLine("Aperte [ENTER] Para voltar ao menu");
            Console.ReadLine();
        }
        static void multiplicacao()
        {
            Console.WriteLine("VOCÊ ESCOLHEU multiplicacao");
            Console.WriteLine("multiplicacao de Dois números");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            int b = int.Parse(Console.ReadLine());
            float resultado = a * b;
            Console.WriteLine($"O resultado de {a} X {b} é: {resultado} ");
            Console.WriteLine("\nObrigado por usar meu Software");
            Console.WriteLine("\n+=============================+");
            Console.WriteLine("Aperte [ENTER] Para voltar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("VOCÊ ESCOLHEU Raiz");
            Console.WriteLine("A raiz de um numero");
            Console.WriteLine("Digite o numero:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"A raiz de {""}  é: {resultado} ");
            Console.WriteLine("\nObrigado por usar meu Software");
            Console.WriteLine("\n+=============================+");
            Console.WriteLine("Aperte [ENTER] Para voltar ao menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("VOCÊ ESCOLHEU Potência");
            Console.WriteLine("Digite a  Base");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"o Resultado é {""}  é: {resultado} ");
            Console.WriteLine("\nObrigado por usar meu Software");
            Console.WriteLine("\n+=============================+");
            Console.WriteLine("Aperte [ENTER] Para voltar ao menu");
            Console.ReadLine();
        }
    }
}





