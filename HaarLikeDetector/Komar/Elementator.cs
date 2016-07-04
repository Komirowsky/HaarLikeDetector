using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaarLikeDetector.Komar
{
    delegate double genMask(int[,] corners);
    class Elementator
    {
        public int px, py, sx, sy;
        public uint idMask;
        public genMask Mask;
        public Elementator(int cpx, int cpy, int csx, int csy, genMask cMask,uint idMask)
        {
            this.px = cpx;
            this.py = cpy;
            this.sx = csx;
            this.sy = csy;
            this.Mask = cMask;
            this.idMask = idMask;
        }
    }
}
