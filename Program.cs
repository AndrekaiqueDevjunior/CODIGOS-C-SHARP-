using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class ContaBancaria
    {
        private string titular;
        private double saldo;

        public ContaBancaria(string titular)
        {
            this.titular = titular;
            saldo = 0;
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
            }
        }
    }

    internal class Program
    {
        private static bool SairPrograma()
        {
            Console.WriteLine("Saindo do programa...");
            return true; // Retorna true para indicar que o programa deve sair
        }

        public static void Main(string[] args)
        {
            bool sair = false;
            string nomeTitular = "";
            ContaBancaria conta = null;

            Console.WriteLine("Bem-Vindo!!!");
            Console.WriteLine("1- Cadastrar usuário\n2- Sacar\n3- Depositar\n4- Sair");

            while (!sair)
            {
                int option = int.Parse(Console.ReadLine()); // Lê a opção escolhida pelo usuário

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do Titular:");
                        nomeTitular = Console.ReadLine();
                        conta = new ContaBancaria(nomeTitular);
                        Console.WriteLine($"Usuário {nomeTitular} cadastrado.");
                        break;
                    case 2:
                        if (conta != null)
                        {
                            Console.WriteLine("Digite o Valor que Deseja Sacar:");
                            double valorSaque = double.Parse(Console.ReadLine());
                            conta.Sacar(valorSaque);
                        }
                        else
                        {
                            Console.WriteLine("Crie uma conta antes de realizar saques.");
                        }
                        break;
                    case 3:
                        if (conta != null)
                        {
                            Console.WriteLine("Digite o Valor que Deseja Depositar:");
                            double valorDeposito = double.Parse(Console.ReadLine());
                            conta.Depositar(valorDeposito);
                        }
                        else
                        {
                            Console.WriteLine("Crie uma conta antes de realizar depósitos.");
                        }
                        break;
                    case 4:
                        sair = SairPrograma();
                        Console.WriteLine("Saindo....");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
