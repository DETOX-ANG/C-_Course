using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyC
{
    class Operacao : Exception {

        /// <summary>
        /// Construtor utilizado para tratar excessões de operações não realizadas
        /// </summary>
        /// <param name="msg"></param>
        public Operacao(string msg) : base (msg){

        }
    }
}
