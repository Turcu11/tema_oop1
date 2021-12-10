using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Library.Library
{
    public class ArrayHelper
    {
        public static int[,] CreateMatrix()
        {
            Console.Write("Specify the number of rows = ");
            int randuri = Convert.ToInt32(Console.ReadLine());
            Console.Write("Specify the number of colomns = ");
            int coloane = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int[,] matrix = new int[randuri, coloane];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Element of matrix [{i}] [{j}] = ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = element;
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix is null)
            {
                Console.WriteLine("Matrix is null !");
                return;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6}");
                }

                Console.WriteLine();
            }
        }

        public static bool CheckIfMatrixIdentity(int[,] matrix)
        {
            bool isPerfect = false;
            bool perfectElseWhere = false;
            bool perfectDiagonal = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j && matrix[i, j] == 1)
                    {
                        perfectDiagonal = true;
                    }
                    if (i != j && matrix[i, j] == 0)
                    {
                        perfectElseWhere = true;
                    }
                }
            }
            if (perfectDiagonal == true && perfectElseWhere == true)
            {
                isPerfect = true;
            }
            return isPerfect;
        }

        static int[] fibonacci(int n)
        {
            Console.Write("Please enter the number of elements for Fibonacci sequence: ");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[] fi = new int[dim];
            fi[0] = 0;
            if (n == 0) return fi;
            fi[1] = 1;
            if (n == 1) return fi;
            int i = 1;

            while (fi[i] < n)
            {
                i++;
                fi[i] = fi[i - 1] + fi[i - 2];

            }
            return fi;
        }

        public static int[] frecventa()
        {
            Console.Write("Te rog sa introduci numarul de elemente: ");
            int numarElem = Convert.ToInt32(Console.ReadLine());
            int[] vec = new int[numarElem];


            for (int i = 0; i < vec.Length; i++)
            {
                Console.Write($"Vector [{i}] = ");
                vec[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---------------------");

            int[] frequencies = new int[vec.Length];

            for (int i = 0; i < vec.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < vec.Length; j++)
                {
                    if (vec[i] == vec[j])
                    {
                        cont++;
                        frequencies[i] = cont;
                    }
                }
            }
            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Write(frequencies[i] + "  ");
            }
            return frequencies;
        }
    }
}
