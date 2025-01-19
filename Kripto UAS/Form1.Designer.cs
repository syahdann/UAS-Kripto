namespace Kripto_UAS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button6 = new Button();
            ClearTxtChiper = new Label();
            ClearTxtAsli = new Label();
            button4 = new Button();
            btn_dekripsi = new Button();
            btn_enkripsi = new Button();
            label3 = new Label();
            txt_Chiper = new TextBox();
            label2 = new Label();
            txt_Asli = new TextBox();
            label1 = new Label();
            txt_Key = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txt_extracted = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(ClearTxtChiper);
            groupBox1.Controls.Add(ClearTxtAsli);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(btn_dekripsi);
            groupBox1.Controls.Add(btn_enkripsi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Chiper);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Asli);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Key);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(269, 301);
            button6.Name = "button6";
            button6.Size = new Size(82, 23);
            button6.TabIndex = 6;
            button6.Text = "Sisipkan";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // ClearTxtChiper
            // 
            ClearTxtChiper.BorderStyle = BorderStyle.FixedSingle;
            ClearTxtChiper.Cursor = Cursors.Hand;
            ClearTxtChiper.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearTxtChiper.ForeColor = Color.Red;
            ClearTxtChiper.Location = new Point(357, 301);
            ClearTxtChiper.Name = "ClearTxtChiper";
            ClearTxtChiper.Size = new Size(48, 23);
            ClearTxtChiper.TabIndex = 11;
            ClearTxtChiper.Text = "Clear";
            ClearTxtChiper.TextAlign = ContentAlignment.MiddleCenter;
            ClearTxtChiper.Visible = false;
            ClearTxtChiper.Click += ClearTxtChiper_Click;
            // 
            // ClearTxtAsli
            // 
            ClearTxtAsli.BorderStyle = BorderStyle.FixedSingle;
            ClearTxtAsli.Cursor = Cursors.Hand;
            ClearTxtAsli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearTxtAsli.ForeColor = Color.Red;
            ClearTxtAsli.Location = new Point(357, 173);
            ClearTxtAsli.Name = "ClearTxtAsli";
            ClearTxtAsli.Size = new Size(48, 23);
            ClearTxtAsli.TabIndex = 9;
            ClearTxtAsli.Text = "Clear";
            ClearTxtAsli.TextAlign = ContentAlignment.MiddleCenter;
            ClearTxtAsli.Visible = false;
            ClearTxtAsli.Click += label4_Click;
            // 
            // button4
            // 
            button4.Location = new Point(269, 173);
            button4.Name = "button4";
            button4.Size = new Size(82, 23);
            button4.TabIndex = 4;
            button4.Text = "Sisipkan";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // btn_dekripsi
            // 
            btn_dekripsi.Location = new Point(335, 207);
            btn_dekripsi.Name = "btn_dekripsi";
            btn_dekripsi.Size = new Size(75, 30);
            btn_dekripsi.TabIndex = 8;
            btn_dekripsi.Text = "Dekripsi ⬆";
            btn_dekripsi.UseVisualStyleBackColor = true;
            btn_dekripsi.Click += btn_dekripsi_Click;
            // 
            // btn_enkripsi
            // 
            btn_enkripsi.Location = new Point(233, 207);
            btn_enkripsi.Name = "btn_enkripsi";
            btn_enkripsi.Size = new Size(75, 30);
            btn_enkripsi.TabIndex = 7;
            btn_enkripsi.Text = "Enkripsi ⬇";
            btn_enkripsi.UseVisualStyleBackColor = true;
            btn_enkripsi.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 218);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Teks AES :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Chiper
            // 
            txt_Chiper.Location = new Point(7, 246);
            txt_Chiper.Multiline = true;
            txt_Chiper.Name = "txt_Chiper";
            txt_Chiper.Size = new Size(403, 82);
            txt_Chiper.TabIndex = 5;
            txt_Chiper.TextChanged += txt_Chiper_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Teks Asli :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Asli
            // 
            txt_Asli.Location = new Point(7, 102);
            txt_Asli.Multiline = true;
            txt_Asli.Name = "txt_Asli";
            txt_Asli.Size = new Size(403, 99);
            txt_Asli.TabIndex = 3;
            txt_Asli.TextChanged += txt_Asli_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Kunci :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Key
            // 
            txt_Key.Location = new Point(7, 38);
            txt_Key.Name = "txt_Key";
            txt_Key.Size = new Size(151, 23);
            txt_Key.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(440, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(440, 289);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 2;
            button1.Text = "Buka Gambar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(440, 329);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 3;
            button2.Text = "Simpan Gambar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(546, 299);
            button3.Name = "button3";
            button3.Size = new Size(62, 51);
            button3.TabIndex = 5;
            button3.Text = "Ekstrak Teks";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_extracted
            // 
            txt_extracted.Location = new Point(614, 295);
            txt_extracted.Multiline = true;
            txt_extracted.Name = "txt_extracted";
            txt_extracted.Size = new Size(205, 69);
            txt_extracted.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 373);
            Controls.Add(txt_extracted);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Steganografi - Buat Pesan Rahasiamu";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private TextBox txt_Key;
        private Label label2;
        private TextBox txt_Asli;
        private Label label3;
        private TextBox txt_Chiper;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btn_dekripsi;
        private Button btn_enkripsi;
        private Button button6;
        private Label ClearTxtAsli;
        private Label ClearTxtChiper;
        private TextBox txt_extracted;
    }
}
