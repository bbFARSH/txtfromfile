using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdapter2k
{
    class ReadTxt
    {
        public int N { get; set; }
        public int[,] _array { get; set; }
        public ReadTxt()
        {
            OpenNote();
        }
        public int[,] OpenNote()
        {
            FileStream fileStream = new FileStream("C:\\Users\\glebs\\OneDrive\\Рабочий стол\\readme.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            _array = new int[N, N];
            N = Convert.ToInt32(streamReader.ReadLine());
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    _array[i, j] = streamReader.Read() - 48;
                }
            fileStream.Close();
            return _array;
        }
    }
}
