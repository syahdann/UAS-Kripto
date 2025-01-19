using Microsoft.VisualBasic;
using System;
using System.Drawing.Imaging;
using System.Text;

namespace Kripto_UAS
{
    public partial class Form1 : Form
    {
        private string inputFilename;
        private string tempInputFilename = "tempPlainText.txt";
        private string tempOutputFilename = "tempEncryptedData.plt";
        Image image;
        private Bitmap bmp = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Image file";
            openFileDialog1.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                if (image != null)
                {
                    image.Dispose();
                }
                string ext = Path.GetExtension(openFileDialog1.FileName);
                if (ext == ".png" || ext == ".bmp" || ext == ".jpg")
                {
                    try
                    {
                        image = Image.FromFile(openFileDialog1.FileName);
                        pictureBox1.Image = image;
                    }
                    catch
                    {
                        image = null;
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Asli.Text) && !string.IsNullOrEmpty(txt_Key.Text))
            {
                byte[] key = Encoding.UTF8.GetBytes(txt_Key.Text.PadRight(32).Substring(0, 32)); 
                byte[] iv = AESCrypt.GenerateRandomIV();
                byte[] encrypted = AESCrypt.Encrypt(txt_Asli.Text, key, iv);
                txt_Chiper.Text = Convert.ToBase64String(encrypted);
                File.WriteAllBytes("iv.bin", iv);
            }
            else
            {
                MessageBox.Show("Teks asli dan kunci tidak boleh kosong.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txt_Asli.Clear();
        }

        private void txt_Asli_TextChanged(object sender, EventArgs e)
        {
            if (txt_Asli.TextLength > 0)
            {
                ClearTxtAsli.Visible = true;
                button4.Visible = true;
            }
            else if (txt_Asli.TextLength == 0)
            {
                ClearTxtAsli.Visible = false;
                button4.Visible = false;
            }
        }

        private void txt_Chiper_TextChanged(object sender, EventArgs e)
        {
            if (txt_Chiper.TextLength > 0)
            {
                ClearTxtChiper.Visible = true;
                button6.Visible = true;

            }
            else if (txt_Chiper.TextLength == 0)
            {
                ClearTxtChiper.Visible = false;
                button6.Visible= false; 
            }
        }

        private void ClearTxtChiper_Click(object sender, EventArgs e)
        {
            txt_Chiper.Clear();
        }

        private void btn_dekripsi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Chiper.Text) && !string.IsNullOrEmpty(txt_Key.Text))
            {
                byte[] iv = File.ReadAllBytes("iv.bin");
                byte[] key = Encoding.UTF8.GetBytes(txt_Key.Text.PadRight(32).Substring(0, 32));
                byte[] cipherText = Convert.FromBase64String(txt_Chiper.Text);
                string decrypted = AESCrypt.Decrypt(cipherText, key, iv);

                txt_Asli.Text = decrypted;
            }
            else
            {
                MessageBox.Show("Encripted text dan kunci tidak boleh kosong.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image;

                string text = txt_Asli.Text;

                if (text.Equals(""))
                {
                    MessageBox.Show("Text tidak boleh kosong!", "Warning");

                    return;
                }


                bmp = Steganograpy.embedText(text, bmp);

                MessageBox.Show("Pesan asli berhasil disisipkan!", "Insert Message");
            }
            else
            {
                MessageBox.Show("Pilih Gambar terlebih dahulu!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;

            string text = txt_Chiper.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("Chipertext tidak boleh kosong!", "Warning");

                return;
            }


            bmp = Steganograpy.embedText(text, bmp);

            MessageBox.Show("Pesan Chipertext berhasil disisipkan!", "Insert Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image;

                string extractedText = Steganograpy.extractText(bmp);
                txt_extracted.Text = extractedText;
                if(extractedText == "")
                {
                    MessageBox.Show("Tidak ada pesan tersembunyi pada gambar!", "Pesan tersembunyi!");
                }
                else { 
                MessageBox.Show("Berhasil mengextract pesan tersembunyi", "Pesan tersembunyi!");
                }
            }
            else
            {
                MessageBox.Show("Gambar kosong","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
