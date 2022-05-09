using System;
using System.Collections.Generic;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int[] elementos = new int[3];

            elementos[0] = 2;
            elementos[1] = 3;
            elementos[2] = 4;

            SomaMenorNumeroElementos(numero, elementos);
        }

        public static int MenorElementoParaInteracoes(int[] elementos)
        {
            int resultado = int.MaxValue;

            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] < resultado)
                {
                    resultado = elementos[i];
                }
            }

            if (resultado == 0)
            {
                resultado++;
            }

            return resultado;
        }

        public static List<int[]> SomaMenorNumeroElementos(int numero, int[] elementos)
        {
            int maiorQtdInteracoes = numero / MenorElementoParaInteracoes(elementos);
            int[] aux = new int[maiorQtdInteracoes];

            List<int[]> resultado = new List<int[]>();

            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == numero)
                {
                    resultado.Add(new int[1] { elementos[i] });
                }
            }

            if (resultado.Count == 0)
            {
                for (int i = 0; i < elementos.Length; i++)
                {
                    for (int j = 0; j < elementos.Length; j++)
                    {
                        if (elementos[i] + elementos[j] == numero)
                        {
                            resultado.Add(new int[2] { elementos[i], elementos[j] });
                        }
                    }
                }
            }

            if (resultado.Count == 0)
            {
                for (int i = 0; i < elementos.Length; i++)
                {
                    for (int j = 0; j < elementos.Length; j++)
                    {
                        for (int k = 0; k < elementos.Length; k++)
                        {
                            if (elementos[i] + elementos[j] + elementos[k] == numero)
                            {
                                resultado.Add(new int[3] { elementos[i], elementos[j], elementos[k] });
                            }
                        }
                    }
                }
            }

            if (resultado.Count == 0)
            {
                for (int i = 0; i < elementos.Length; i++)
                {
                    for (int j = 0; j < elementos.Length; j++)
                    {
                        for (int k = 0; k < elementos.Length; k++)
                        {
                            for (int l = 0; l < elementos.Length; l++)
                            {
                                if (elementos[i] + elementos[j] + elementos[k] + elementos[l] == numero)
                                {
                                    resultado.Add(new int[4] { elementos[i], elementos[j], elementos[k], elementos[l] });
                                }
                            }
                        }
                    }
                }
            }

            if (resultado.Count == 0)
            {
                for (int i = 0; i < elementos.Length; i++)
                {
                    for (int j = 0; j < elementos.Length; j++)
                    {
                        for (int k = 0; k < elementos.Length; k++)
                        {
                            for (int l = 0; l < elementos.Length; l++)
                            {
                                for (int m = 0; m < elementos.Length; m++)
                                {
                                    if (elementos[i] + elementos[j] + elementos[k] + elementos[l] == numero)
                                    {
                                        resultado.Add(new int[5] { elementos[i], elementos[j], elementos[k], elementos[l], elementos[m] });
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return resultado;
        }
    }
}
