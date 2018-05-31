using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyC
    {
    class ContaCorrente : Conta {
        // Quando você herdar uma classe abstrata você tem que definir todos os métodos abstratos nela incluso

        //Quando criar um contrutor que herda de uma classe que possui um contrutor com parâmetros, os mesmos deverão ser informados no cosntru
        public ContaCorrente(double saldo, string nome) : base (saldo, nome)  
        {

        }

        public override void Saque(double value) {
            if (value > this.saldo) {
                throw new Operacao("Saquel maior que saldo existente");

            }

            this.saldo = this.saldo - value;
            
        }
        
    }
}
