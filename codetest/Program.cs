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
            int[,] lines = new int[3, 2] { {0, 5 }, { 3, 9 }, { 1, 10 }  };
            int answer = 0;
            for (int i = 0; i < 3; i++)
            {
                int j = (i + 1) % 3;
                if (lines[i, 1] < lines[j, 0] || lines[j, 1] < lines[i, 0])
                {
                    continue;
                }
                else if (lines[i, 1] <= lines[j, 1])
                {
                    int k = (lines[j, 0] > lines[i, 0] ? lines[j, 0] : lines[i, 0]);
                    answer += lines[i, 1] - k;
                    continue;
                }
                else if (lines[i, 0] <= lines[j, 1])
                {
                    int k = (lines[j, 0] > lines[i, 0] ? lines[j, 0] : lines[i, 0]);
                    answer += lines[j, 1] - k;
                    continue;
                }
            }
            if (!(lines[0, 1] < lines[1, 0] || lines[1, 1] < lines[0, 0]))
            {
                int x = (lines[0, 0] > lines[1, 0] ? lines[0, 0] : lines[1, 0]);
                int y = (lines[0, 1] > lines[1, 1] ? lines[1, 1] : lines[0, 1]);
                int[,] xline = { { x, y } };
                if (!(lines[2, 1] < xline[0, 0] || xline[0, 1] < lines[2, 0]))
                {
                    int xPrime = (lines[2, 0] > xline[0, 0] ? lines[2, 0] : xline[0, 0]);
                    int yPrime = (lines[2, 1] > xline[0, 1] ? lines[2, 1] : xline[0, 1]);
                    int[,] yline = { { xPrime, yPrime } };
                    answer -= yline[0,0];
            }
            }
          Console.WriteLine(answer);


        }
    }
}
