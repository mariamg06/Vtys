
namespace oop_project
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox5 = new TextBox();
            label6 = new Label();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 36);
            label1.TabIndex = 2;
            label1.Text = "Raporlar";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(657, 389);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 31;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(544, 188);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(562, 121);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(103, 27);
            textBox5.TabIndex = 62;
           // textBox5.TextChanged += this.textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(560, 96);
            label6.Name = "label6";
            label6.Size = new Size(118, 22);
            label6.TabIndex = 61;
            label6.Text = "Danisan ID";
            label6.Click += label6_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 357);
            button6.Name = "button6";
            button6.Size = new Size(95, 33);
            button6.TabIndex = 60;
            button6.Text = "Listele";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.ForestGreen;
            button5.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(208, 357);
            button5.Name = "button5";
            button5.Size = new Size(95, 33);
            button5.TabIndex = 59;
            button5.Text = "Ara";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(443, 357);
            button3.Name = "button3";
            button3.Size = new Size(113, 33);
            button3.TabIndex = 56;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(688, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 90);
            textBox1.TabIndex = 53;
//            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(700, 96);
            label2.Name = "label2";
            label2.Size = new Size(59, 22);
            label2.TabIndex = 52;
            label2.Text = "İçerik";
         //   label2.Click += this.label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.ForestGreen;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(560, 160);
            label9.Name = "label9";
            label9.Size = new Size(96, 22);
            label9.TabIndex = 47;
            label9.Text = "Rapor ID";
            //label9.Click += this.label9_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(562, 185);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(103, 27);
            textBox7.TabIndex = 46;
           // textBox7.TextChanged += this.textBox7_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(667, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
           // pictureBox1.Click += this.pictureBox1_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Staff";
            Text = "𝓢𝓽𝓪𝓯𝓯";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label label6;
        private Button button6;
        private Button button5;
        private Button button3;
        private TextBox textBox1;
        private Label label2;
        private Label label9;
        private TextBox textBox7;
        private PictureBox pictureBox1;
        private EventHandler textBox5_TextChanged;
        private EventHandler textBox1_TextChanged;
        private EventHandler label2_Click;
        private EventHandler label9_Click;
        private EventHandler textBox7_TextChanged;
        private EventHandler pictureBox1_Click;
    }
}