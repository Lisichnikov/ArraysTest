using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Arrayyy
    {
        public int SumLine(int[,] A, int M, int N, int k)
        {
            int bufer = 0;
            int[] s = new int[N];
            if (k > M || k > N)
            {
                return 0;
            }
            else
            {
                for (int i = k - 1; i <= k - 1; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        s[i] += A[i, j];
                    }
                    bufer = s[i];
                }
                return bufer;
            }
        }
        static void Main(string[] args)
        {
            // создаем основные переменные
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            //int[,] A = new int[M, N];

            // заполнение массива
            //Random ran = new Random();
            //for (int i = 0; i < M; i++)
            //{
            //  for (int j = 0; j < N; j++)
            //{
            //  A[i, j] = ran.Next(1, 15);
            //}
            //}

            int[,] A = new int[,] {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
            };

            Arrayyy arrayInstance = new Arrayyy();
            // Вывод ответа
            Console.WriteLine("Ответ на эту задачу: " + arrayInstance.SumLine(A, M, N, k));

            string x = Console.ReadLine();
        }
    }
}
