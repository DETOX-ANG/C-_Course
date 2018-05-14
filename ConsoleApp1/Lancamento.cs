using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class Lancamentos
    {
        //instanciando array 2D simples
        double[,] credito = new double[3,3];
        

        public void inserirCredt() {
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

    }
        
    }

