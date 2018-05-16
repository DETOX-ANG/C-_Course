using System;
using System.Collections.Generic;
using System.Text;

namespace Curso {
    class Conta {
        enum TipoConta { Conta_corrente, ContaPoupanca };

        public string Nome { get; private set;} //uma maneira de controlar se o atributo pode ser lido/alterado fora da classe
        double saldo;
        int idade;
        int[] qtdeSaque;
        Pessoa Pessoa = new Pessoa();

        public Conta(double saldo) {
            this.saldo = saldo;
        }

        public Conta(double saldo, string nome) {
            this.saldo = saldo;
            this.Nome = nome;
        }


        public void CheckSaldo() {
            Console.WriteLine($"Seu saldo é: {saldo}");
        }

        public void Saque(double value) {
            //value = int.Parse(Console.ReadLine());
            saldo = this.saldo - value;
        }

        public void Deposito(double value) {
            //value = int.Parse(Console.ReadLine());
            saldo = this.saldo + value;
        }

        public void TesteArray(int qtde) {
            this.qtdeSaque = new int[qtde];

            for (int i = 0; i < qtde; i++) {
                Console.Write("SeqNum");
                this.qtdeSaque[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < qtde; i++) {
                Console.WriteLine($"Numero: {this.qtdeSaque[i]}");

            }
                


        }




    }
}
