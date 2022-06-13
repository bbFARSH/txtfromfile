using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdapter2k
{
    class Picture
    {
        public Bitmap bitmap { get; set; }
        public int N { get; set; }
        public Picture(string path)
        {
            bitmap = new Bitmap(path);
            N = bitmap.Width;
        }
    }
}
