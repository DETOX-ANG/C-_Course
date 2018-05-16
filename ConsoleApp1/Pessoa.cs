using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class Pessoa
    {
        public string nome { get; set; }
        public string email { get; set; }
        public int idade { get; set; }


        Pessoa(string nm, string mail, int age) {
            this.nome = nm;
            this.email = mail;
            this.idade = age;

        }

        public override string ToString() {
            return $"Dados dos cliente: {this.nome}, \n {this.email}, \n {this.idade}"; 
        }
    }
}
