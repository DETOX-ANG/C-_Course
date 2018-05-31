using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyC {
    class ContaPoupanca : Conta, ITributos {

        public double ValorTotalTrib { get; private set; }

        public ContaPoupanca(double saldo, string nome) : base(saldo, nome) {

        }

        public double CalculaTributos() {
            return this.ValorTotalTrib = this.saldo * 0.2;
        }

        public override void Saque(double value) {
            throw new NotImplementedException();
        }
    }
}
