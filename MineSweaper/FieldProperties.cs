﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MineSweaper;

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
            IsExplosive = explosive;
            MinesNearby = minesNearby;
            IsChecked = isChecked;     
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (mevent.Button==MouseButtons.Left)
            {
                IsChecked = true;   
            }
        }

        private bool isChecked;
        public bool IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                isChecked = value;
                if (value)
                {
                    if (IsExplosive)
                    {
                        Text = "X";
                        BackColor = Color.Red;
                    }
                    else if (MinesNearby > 0)
                    {
                        Text = MinesNearby.ToString();
                        BackColor = Color.Yellow;
                    }
                    else
                    {
                        Text = " ";
                        BackColor = Color.Green;
                    }
                }

            }
        }

    }
}
