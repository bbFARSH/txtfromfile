using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdapter2k
{
    class TxtToArrayAdapter:MyArray
    {
        public TxtToArrayAdapter(ReadTxt readTxt) : base(readTxt.N)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    Arr[j, i] = readTxt._array[j, i];
                }
        }
    }
}
