using System;
using System.Globalization;

namespace Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com Número da Conta: ");
            int nconta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Nome do Titular: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n) ?");
            char opcao = char.Parse(Console.ReadLine());

            conta = new Conta(nconta, nome);

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre com o valor de déposito inicial: ");
                double dpInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Depositar(dpInicial);

                Console.WriteLine("\nDados da Conta:\nConta: {0}", conta);

                Console.Write("\nEntre com um valor de Depósito: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Depositar(saldo);

                Console.WriteLine("Dados da conta Atualizado:");
                Console.Write("Conta: {0}\n", conta);

                Console.Write("\nEntre com um valor para saque: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Sacar(saldo);

                Console.WriteLine("Dados da conta Atualizado:");
                Console.Write("Conta: {0}\n", conta);

            }
            else if (opcao == 'n' || opcao == 'N')
            {

                Console.WriteLine("\nDados da Conta:\nConta: {0}", conta);

                Console.Write("\nEntre com um valor de Depósito: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Depositar(saldo);

                Console.WriteLine("Dados da conta Atualizado:");
                Console.Write("Conta: {0}\n", conta);

                Console.Write("\nEntre com um valor para saque: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Sacar(saldo);

                Console.WriteLine("Dados da conta Atualizado:");
                Console.Write("Conta: {0}\n", conta);
            }
            else
            {
                Console.WriteLine("Opção Invalida!!");
            }

        }
    }
}
