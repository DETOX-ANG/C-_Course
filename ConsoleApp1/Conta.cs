using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyC {
    abstract class Conta {

        
        //Propriedade
        public string Nome { get; private set;} //uma maneira de controlar se o atributo pode ser lido/alterado fora da classe
        public double saldo;// Field
        public double limite;
        int idade;
        int[] qtdeSaque;//Array
        public Pessoa Pessoa { get; private set; } // Propriedade

        public Conta(double saldo, Pessoa pessoa) {
            this.saldo = saldo;
        }

        public Conta(double saldo, string nome) {
            this.saldo = saldo;
            this.Nome = nome;
        }

        

        public void CheckSaldo() {
            Console.WriteLine($"Seu saldo é: {saldo}");
        }

        public abstract void Saque(double value);

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
