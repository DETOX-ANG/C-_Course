using System;
using System.Collections.Generic;
using System.Text;

namespace Curso {
    class Conta {
        enum TipoConta { Conta_corrente, ContaPoupanca };

        public string nome { get; private set;} //uma maneira de controlar se o atributo pode ser lido/alterado fora da classe
        double saldo;
        int idade;

        public Conta(double saldo) {
            this.saldo = saldo;
        }

        public Conta(double saldo, string nome) {
            this.saldo = saldo;
            this.nome = nome;
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

    }
}
