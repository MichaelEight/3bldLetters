﻿namespace _3bldLetters
{
    partial class mainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.letterBox1 = new System.Windows.Forms.TextBox();
            this.letterBox2 = new System.Windows.Forms.TextBox();
            this.letterBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.letterBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.letterBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.memo1 = new System.Windows.Forms.Label();
            this.memo2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.memo3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.memo4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.memo5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // letterBox1
            // 
            this.letterBox1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterBox1.Location = new System.Drawing.Point(284, 31);
            this.letterBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterBox1.MaxLength = 42;
            this.letterBox1.Name = "letterBox1";
            this.letterBox1.Size = new System.Drawing.Size(1082, 65);
            this.letterBox1.TabIndex = 0;
            this.letterBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterBox1_KeyDown);
            this.letterBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterBox1_KeyPress);
            // 
            // letterBox2
            // 
            this.letterBox2.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterBox2.Location = new System.Drawing.Point(284, 111);
            this.letterBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterBox2.MaxLength = 42;
            this.letterBox2.Name = "letterBox2";
            this.letterBox2.Size = new System.Drawing.Size(1082, 65);
            this.letterBox2.TabIndex = 1;
            this.letterBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterBox2_KeyDown);
            this.letterBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterBox2_KeyPress);
            // 
            // letterBox3
            // 
            this.letterBox3.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterBox3.Location = new System.Drawing.Point(284, 191);
            this.letterBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterBox3.MaxLength = 42;
            this.letterBox3.Name = "letterBox3";
            this.letterBox3.Size = new System.Drawing.Size(1082, 65);
            this.letterBox3.TabIndex = 2;
            this.letterBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterBox3_KeyDown);
            this.letterBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterBox3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Corners";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Midges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 58);
            this.label4.TabIndex = 7;
            this.label4.Text = "x Centers";
            // 
            // letterBox4
            // 
            this.letterBox4.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterBox4.Location = new System.Drawing.Point(284, 271);
            this.letterBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterBox4.MaxLength = 42;
            this.letterBox4.Name = "letterBox4";
            this.letterBox4.Size = new System.Drawing.Size(1082, 65);
            this.letterBox4.TabIndex = 6;
            this.letterBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterBox4_KeyDown);
            this.letterBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 58);
            this.label5.TabIndex = 9;
            this.label5.Text = "+ Centers";
            // 
            // letterBox5
            // 
            this.letterBox5.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterBox5.Location = new System.Drawing.Point(284, 351);
            this.letterBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterBox5.MaxLength = 42;
            this.letterBox5.Name = "letterBox5";
            this.letterBox5.Size = new System.Drawing.Size(1082, 65);
            this.letterBox5.TabIndex = 8;
            this.letterBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterBox5_KeyDown);
            this.letterBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(18, 429);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "On Table:";
            // 
            // memo1
            // 
            this.memo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memo1.ForeColor = System.Drawing.Color.Blue;
            this.memo1.Location = new System.Drawing.Point(18, 477);
            this.memo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memo1.Name = "memo1";
            this.memo1.Size = new System.Drawing.Size(1506, 98);
            this.memo1.TabIndex = 11;
            this.memo1.Text = "MEMO";
            // 
            // memo2
            // 
            this.memo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memo2.ForeColor = System.Drawing.Color.Red;
            this.memo2.Location = new System.Drawing.Point(21, 623);
            this.memo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memo2.Name = "memo2";
            this.memo2.Size = new System.Drawing.Size(1503, 108);
            this.memo2.TabIndex = 13;
            this.memo2.Text = "MEMO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(16, 575);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 46);
            this.label9.TabIndex = 12;
            this.label9.Text = "On Bed:";
            // 
            // memo3
            // 
            this.memo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.memo3.Location = new System.Drawing.Point(21, 778);
            this.memo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memo3.Name = "memo3";
            this.memo3.Size = new System.Drawing.Size(1503, 108);
            this.memo3.TabIndex = 15;
            this.memo3.Text = "MEMO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(16, 731);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(387, 46);
            this.label11.TabIndex = 14;
            this.label11.Text = "Table - Living Room:";
            // 
            // memo4
            // 
            this.memo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memo4.ForeColor = System.Drawing.Color.Lime;
            this.memo4.Location = new System.Drawing.Point(18, 940);
            this.memo4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memo4.Name = "memo4";
            this.memo4.Size = new System.Drawing.Size(1503, 108);
            this.memo4.TabIndex = 17;
            this.memo4.Text = "MEMO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(16, 892);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(348, 46);
            this.label13.TabIndex = 16;
            this.label13.Text = "Bed - Living Room";
            // 
            // memo5
            // 
            this.memo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memo5.ForeColor = System.Drawing.SystemColors.Control;
            this.memo5.Location = new System.Drawing.Point(18, 1120);
            this.memo5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memo5.Name = "memo5";
            this.memo5.Size = new System.Drawing.Size(1503, 108);
            this.memo5.TabIndex = 19;
            this.memo5.Text = "MEMO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(16, 1065);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 46);
            this.label15.TabIndex = 18;
            this.label15.Text = "Kitchen:";
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputButton.Location = new System.Drawing.Point(1377, 28);
            this.inputButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(147, 392);
            this.inputButton.TabIndex = 20;
            this.inputButton.Text = "NEXT";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1536, 1232);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.memo5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.memo4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.memo3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.memo2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.memo1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.letterBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.letterBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterBox3);
            this.Controls.Add(this.letterBox2);
            this.Controls.Add(this.letterBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Blindfolded Letters To Words by Eight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letterBox1;
        private System.Windows.Forms.TextBox letterBox2;
        private System.Windows.Forms.TextBox letterBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox letterBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox letterBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label memo1;
        private System.Windows.Forms.Label memo2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label memo3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label memo4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label memo5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button inputButton;
    }
}

