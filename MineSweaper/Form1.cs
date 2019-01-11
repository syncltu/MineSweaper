using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MineSweaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
        }
        public int Columns = 0;
        public int Rows = 0;

        public void InitializeBoard(int rows, int columns)
        {
            textBox1.Location = new Point(94, 30);
            textBox1.Text = "Let the game begin";
            button1.Dispose();
            textBox3.Dispose();
            textBox4.Dispose();
            textBox5.Dispose();
            textBox2.Dispose();
            button4.Location = new Point(279, 700);
            button4.Text = Columns.ToString() + "," + Rows.ToString();
            CreateFields(Rows, Columns);
            

        }
        private void Reveal0(int fieldX, int fieldY, FieldProperties[,] fields)
        {
            if (fields[fieldX, fieldY].IsChecked == true && fields[fieldX, fieldY].MinesNearby == 0)
            {
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        int targetX = fieldX + x;
                        int targetY = fieldY + y;
                        if (targetX >= 0 && targetX < Rows && targetY >= 0 && targetY < Columns && fields[targetX, targetY].IsChecked == false)
                        {

                            fields[targetX, targetY].IsChecked = true;
                        }
                    }
                }
            }

        }
        public void button1_Click(object sender, EventArgs e)
        {

            int.TryParse(textBox3.Text, out Columns);
            int.TryParse(textBox4.Text, out Rows);
            if (Rows < 2)
            {
                button1.Text = "Number of rows must be more than 2!";
            }
            else if (Columns < 2)
            {
                button1.Text = "Number of columns must be more than 2!";
            }
            else
            {
                InitializeBoard(Rows, Columns);
            }
        }
        public void CreateFields(int rows, int columns)
        {
            FieldProperties[,] fields = new FieldProperties[rows, columns];
            int bound0 = fields.GetUpperBound(0);
            int bound1 = fields.GetUpperBound(1);
            for (int x = 0; x <= bound0; x++)
            {
                for (int y = 0; y <= bound1; y++)
                {
                    fields[x, y] = new FieldProperties(this, x, y);
                    Controls.Add(fields[x, y]);
                    

                }
            }
            PlaceMines(fields);
            CountNearbyMines(fields);
            
        }
        public void PlaceMines(FieldProperties[,] fields)
        {
            
            int mineCount = Convert.ToInt32(Math.Sqrt(Rows * Columns));
            Random rand = new Random();
            while (mineCount > 0)
            {
                int targetX = rand.Next(Rows);
                int targetY = rand.Next(Columns);
                if (fields[targetX, targetY].IsExplosive == false)
                {
                    fields[targetX, targetY].IsExplosive = true;
                    mineCount--;
                }
            }
        }
        private void CountNearbyMines(FieldProperties[,] fields)
        {
            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    if (fields[x, y].IsExplosive == true)
                    {
                        MineIncrement(x, y, fields);
                    }
                }
            }
        }
        private void PrintSigns(FieldProperties[,] fields)
        {
            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    if (!fields[x, y].IsExplosive)
                    {
                        Reveal0(x, y, fields);
                    }
                }
            }
        }

        private void MineIncrement(int fieldX, int fieldY, FieldProperties[,] fields)
        {
            int mineCount = 0;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    int targetX = fieldX + x;
                    int targetY = fieldY + y;
                    if (targetX >= 0 && targetX < Rows && targetY >= 0 && targetY < Columns && fields[targetX, targetY].IsExplosive == false)
                    {
                        mineCount++;
                        fields[targetX, targetY].MinesNearby++;

                    }
                }
            }

        }

    }
}
