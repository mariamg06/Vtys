﻿namespace oop_project
{
    partial class Alerji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alerji));
            textBox5 = new TextBox();
            label6 = new Label();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(629, 136);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(103, 27);
            textBox5.TabIndex = 114;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(627, 111);
            label6.Name = "label6";
            label6.Size = new Size(118, 22);
            label6.TabIndex = 113;
            label6.Text = "Danisan ID";
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(23, 350);
            button6.Name = "button6";
            button6.Size = new Size(95, 33);
            button6.TabIndex = 112;
            button6.Text = "Listele";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.ForestGreen;
            button5.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(216, 350);
            button5.Name = "button5";
            button5.Size = new Size(95, 33);
            button5.TabIndex = 111;
            button5.Text = "Ara";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(423, 350);
            button3.Name = "button3";
            button3.Size = new Size(113, 33);
            button3.TabIndex = 110;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.ForestGreen;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(627, 178);
            label9.Name = "label9";
            label9.Size = new Size(113, 22);
            label9.TabIndex = 109;
            label9.Text = "Alerji Türü";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(629, 203);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(103, 27);
            textBox7.TabIndex = 108;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(678, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(544, 188);
            dataGridView1.TabIndex = 106;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(678, 395);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 105;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(311, 26);
            label1.Name = "label1";
            label1.Size = new Size(109, 36);
            label1.TabIndex = 104;
            label1.Text = "Alerji";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Alerji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Alerji";
            Text = "Alerji";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Label label6;
        private Button button6;
        private Button button5;
        private Button button3;
        private Label label9;
        private TextBox textBox7;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
    }
}