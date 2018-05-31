using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemyC
    {
    class Lancamentos : Exception
    {
        //instanciando array 2D simples
        double[,] credito = new double[3,3];
        
        //Iniciar uma lista
        List<string> descDebt = new List<string>();

        //Iniciar um Conjunto
        HashSet<string> conjunto = new HashSet<string>();

        public Lancamentos(string mensagem) : base(mensagem) {

        }

        public Lancamentos() { }

        public void InserirCredt() {
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    this.credito[linha,coluna] = double.Parse(Console.ReadLine());
                }
            }
         }

        public void ExibirLcto(){
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    while (coluna <3) {
                        Console.Write(credito[linha,coluna] + "\t");
                        coluna++;
                        
                    }
                    Console.Write("\n");
                }
                
            }
        }

        public void InserirDebt() {
            this.descDebt.Add("Ifood");
            this.descDebt.Add("Uber");
            this.descDebt.Add("Saque 24 Horas");
            this.descDebt.Add("Presente");
            this.conjunto.Add("Presente");
            this.conjunto.Add("Saque 24 Horas");

        }

        public void Extrato() {
            
            for (int i = 0; i < this.descDebt.Count; i++) {
                Console.WriteLine(descDebt[i]);
                               
            }
            //Imprimir posição de um item na lista através do seu indexador Lê-se Localize X tal que(=>) X seja igual Uber
            Console.WriteLine($"Posição do Uber: {descDebt.FindIndex(x => x == "Uber")}");

            //imprimir todos os itens de uma lista
            foreach (string item in conjunto) {
                Console.WriteLine(item);
            }
        }



    }
        
    }

