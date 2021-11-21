namespace MineSweaper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, faasdlse.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(94, 198);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(445, 28);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "Good day sir, select the size of the map";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(458, 310);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(139, 58);
      this.button1.TabIndex = 1;
      this.button1.Text = "Generate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(279, 438);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(88, 58);
      this.button4.TabIndex = 1;
      this.button4.Text = "0";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox2.Location = new System.Drawing.Point(31, 297);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(267, 28);
      this.textBox2.TabIndex = 0;
      this.textBox2.Text = "Input a number of rows:";
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox3
      // 
      this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
      this.textBox3.Location = new System.Drawing.Point(353, 294);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(40, 30);
      this.textBox3.TabIndex = 2;
      this.textBox3.Text = "5";
      this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox4
      // 
      this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
      this.textBox4.Location = new System.Drawing.Point(353, 351);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(40, 30);
      this.textBox4.TabIndex = 2;
      this.textBox4.Text = "5";
      this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox5
      // 
      this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox5.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox5.Location = new System.Drawing.Point(31, 354);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(302, 28);
      this.textBox5.TabIndex = 0;
      this.textBox5.Text = "Input a number of columns:";
      this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(931, 906);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

