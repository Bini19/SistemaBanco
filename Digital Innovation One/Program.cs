using System;
using System.Collections.Generic;

namespace Digital_Innovation_One
{
    class Program : ProgramBase1
    {

        static List<Conta> listContas = new List<Conta>();

        private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado a conta: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);

        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser tranferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaDestino].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void InserirContas()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite ' para Conta Fisica ou 2 para Juridica:");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                                    saldo: entradaSaldo,
                                                    credito: entradaCredito,
                                                    nome: entradaNome);
            listContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");
            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; 1 < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} . ", i);
                Console.WriteLine(conta);
            }
        }

        private static string ObterOpcaoUsuario()
        {
            {
                Console.WriteLine();
                Console.WriteLine("Dio Bank a seu dispor!!!");
                Console.WriteLine("Informe a opcao desejada");

                Console.WriteLine("1- Listar contas");
                Console.WriteLine("2- Inserir nova conta");
                Console.WriteLine("3- Transferir");
                Console.WriteLine("4- Sacar");
                Console.WriteLine("5- Depositar");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string OpcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return OpcaoUsuario;
            }
        }
    }
}
