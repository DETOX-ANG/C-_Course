using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyC
    {
    class Pessoa
    {
        enum Orientacao {hetero, gay, lésbica, transexual, outro};  
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        

        public Pessoa(string nm, string mail, int age) {
            this.Nome = nm;
            this.Email = mail;
            this.Idade = age;
        }

        public override string ToString() {
            return $"Dados dos cliente: {this.Nome}, \n {this.Email}, \n {this.Idade}"; 
        }
    }
}
