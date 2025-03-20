using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] score = new int[7,2] {{80,70}, { 70, 80 },{ 30, 50 }, { 90, 100 }, { 100, 90 }, { 100, 100 }, { 10, 30 } };
            int[] answer = new int[score.GetLength(0)];
            float[] average = new float[score.GetLength(0)];
            float[] rank = new float[score.GetLength(0)];
            for (int i = 0; i < score.GetLength(0); i++)
            {
                average[i] = (score[i, 0] + score[i, 1]) / 2f;
                rank[i] = average[i];
            }
            Array.Sort(rank, (a,b) => a>b ? -1 : 1);
            int n = 0;
            foreach (float i in average)
            {
                for (int j = 0; j < score.GetLength(0); j++)
                {

                    if (i == rank[j])
                    {
                        answer[n++] = j + 1;
                        break;
                    }
                }
            }
            for (int i = 0;i < score.GetLength(0); i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
