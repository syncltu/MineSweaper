using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MineSweaper
{
    public class FieldProperties:Button
    {
        private int OffsetFromCorners=100;

        public bool IsExplosive { get; set; }
        public int MinesNearby { get; set; }

        public FieldProperties(int x, int y, bool explosive=false,int minesNearby = 0)
        {
            IsExplosive = explosive;
            MinesNearby = minesNearby;
            Height = 30;
            Width = 30;
            Location = new Point(OffsetFromCorners+x * 35,y * 35+OffsetFromCorners);
        }
    }
}
