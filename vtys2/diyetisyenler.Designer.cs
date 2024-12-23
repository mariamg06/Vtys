namespace oop_project
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 36);
            label1.TabIndex = 2;
            label1.Text = "Diyetisyenler";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(672, 405);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 31;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(629, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(589, 188);
            dataGridView1.TabIndex = 33;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 318);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 34;
            button2.Text = "Listele";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(98, 369);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 35;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(220, 316);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 36;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.ForestGreen;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(321, 369);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 37;
            button5.Text = "Güncelle";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(635, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(634, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(634, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(635, 268);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 43;
            label3.Text = "E-posta";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(634, 215);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 44;
            label2.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(634, 321);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 45;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(634, 151);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 46;
            label5.Text = "ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(634, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 47;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(446, 318);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 48;
            button6.Text = "Ara";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Details";
            Text = "𝓓𝓮𝓽𝓪𝓲𝓵𝓼";
            Load += details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Button button6;
    }
}