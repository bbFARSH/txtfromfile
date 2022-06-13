using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdapter2k
{
    class MyArray
    {
        public int[,] Arr { get; set; }
        public int N { get; set; }
        public MyArray(int n)
        {
            N = n;
            Arr = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Arr[i, j] = random.Next(10);

        }
    }
}
