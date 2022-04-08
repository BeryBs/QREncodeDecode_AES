using System;
using System.Security.Cryptography;


namespace QREncodeDecode
{
 
    public partial class Form1 : Form
    {
        private string? decryptedString;
        private string key = "b14ca5898a4e4133bbce2ea2315a1916";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 8;
                    Console.WriteLine(encoder.QRCodeErrorCorrect);

                    var encryptedString = EncryptString(key, txtEncode.Text);
                    Bitmap bmp = encoder.Encode(encryptedString);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Image = bmp;

                    bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private byte[] EncryptStringToBytes_Aes(string text)
        {
            throw new NotImplementedException();
        }

        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }
        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
           

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter= "JPEG | *.jpg", ValidateNames = true,Multiselect=false})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image=Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();

                    try
                    {

                        this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        decryptedString = encoder.Decode(new MessagingToolkit.QRCode.Codec.Data.QRCodeBitmapImage(pictureBox1.Image as Bitmap));
                        txtDecode.Text = DecryptString(key, decryptedString);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Choosen QR Image size is out of range, it can be 405x264 maximum ");    
                    }
                    
                 
                       
                        
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 8;
                    Console.WriteLine(encoder.QRCodeErrorCorrect);

                    var encryptedString = EncryptString(key, Clipboard.GetText());
                    Bitmap bmp = encoder.Encode(encryptedString);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Image = bmp;

                    bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        
    }
}