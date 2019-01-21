using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrabalhoFPI
{
    class TabelaValores
    {

        private int colunas = 0;
        private int[,] tabela; 

        public TabelaValores(int colunas)
        {
            tabela = new int[colunas+1,4];
            this.colunas = colunas+1;
        }


        public void adicionaValor(int nSumR, int nSumG, int nSumB, int intensity)
        {
            tabela[intensity, 0] += nSumR;
            tabela[intensity, 1] += nSumG;
            tabela[intensity, 2] += nSumB;
            tabela[intensity, 3] += 1;
        }

        public Color retornaMaior()
        {
            int maiorIndex = 0;
            int maiorValor=0;
            for (int index = 0; index < colunas; index++)
            {
                if(maiorValor < tabela[index,3])
                {
                    maiorIndex = index;
                    maiorValor = tabela[index, 3];
                }
            }

            return Color.FromArgb(tabela[maiorIndex, 0] / tabela[maiorIndex, 3], tabela[maiorIndex, 1] / tabela[maiorIndex, 3], tabela[maiorIndex, 2] / tabela[maiorIndex, 3]);
        }

    }
}
