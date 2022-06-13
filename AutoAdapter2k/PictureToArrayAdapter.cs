using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdapter2k
{
    class PictureToArrayAdapter:MyArray
    {
        public PictureToArrayAdapter(Picture picture) : base(picture.N)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    Color color = picture.bitmap.GetPixel(i, j);
                    if (color.R > 120)
                        Arr[j,i] = 1;
                    else
                        Arr[j,i] = 0;
                }
        }
    }
}
