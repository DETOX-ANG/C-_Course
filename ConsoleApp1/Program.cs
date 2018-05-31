using System;
using System.Globalization;

namespace CursoUdemyC {
    class Program
    {
        enum TipoConta { Conta_corrente, ContaPoupanca };

        static void Main(string[] args)
        {
            //Console.WriteLine("Insira o valor do saldo inicial: ");
            //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Conta conta = new Conta(valor);

            //conta.CheckSaldo();

            //Console.Write("Insira uma quantidade: ");
            //int qtde = int.Parse(Console.ReadLine());

            //conta.TesteArray(qtde);



            //Console.ReadKey();

            Lancamentos lcto = new Lancamentos();

            //lcto.InserirCredt();
            //lcto.ExibirLcto();
            //lcto.InserirDebt();
            //lcto.Extrato();

            Pessoa pessoa = new Pessoa("Angelo", "ang@gmail.com", 25);
            Utilities.AppInfo();

            Console.ReadKey();

            

            
            
            


        }
    }
}
