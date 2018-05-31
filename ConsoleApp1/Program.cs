using System;
using System.Globalization;

namespace CursoUdemyC {
    class Program
    {
        enum TipoConta { Conta_corrente, ContaPoupanca };

        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do saldo inicial: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new ContaCorrente(valor, "Angelo");
             

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

            //Tratando uma excessão
            try {
                conta.Saque(250.00);
            }
            catch (Operacao e) {

                Console.WriteLine(e.Message); 
            }
            
            Console.ReadKey();

            

            
            
            


        }
    }
}
