using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        enum TipoConta { Conta_corrente, ContaPoupanca };

        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do saldo inicial: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta(valor);

            conta.CheckSaldo();

            Console.ReadKey();
            

            
            
            


        }
    }
}
