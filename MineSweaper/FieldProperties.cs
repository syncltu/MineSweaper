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
        private static int OffsetFromCorners=100;
        private Form1 parent;

        public bool IsExplosive { get; set; }
        public int MinesNearby { get; set; }

        public FieldProperties(Form1 parent, int x, int y, bool explosive=false,int minesNearby = 0)
        {
            this.parent = parent;
            IsExplosive = explosive;
            MinesNearby = minesNearby;
            Height = 30;
            Width = 30;
            Location = new Point(OffsetFromCorners+x * 35,y * 35+OffsetFromCorners);
        }
    }
}
