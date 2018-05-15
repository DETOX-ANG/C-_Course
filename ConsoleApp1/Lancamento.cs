using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class Lancamentos
    {
        //instanciando array 2D simples
        double[,] credito = new double[3,3];

        //Iniciar uma lista
        List<string> descDebt = new List<string>();

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
        }

        public void Extrato() {
            
            for (int i = 0; i < this.descDebt.Count; i++) {
                Console.WriteLine(descDebt[i]);
                
            }
        }

    }
        
    }

