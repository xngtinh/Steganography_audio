using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sercurity
{
     public partial class Form1 : Form
     {
          public Vigernere vi = new Vigernere();
          public Form1()
          {
               InitializeComponent();
               
          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               

          }

          private void label2_Click(object sender, EventArgs e)
          {

          }

          private void button1_Click_1(object sender, EventArgs e)
          {
               vi.key = txtKey.Text;
               vi.cipherText = txtCipher.Text;
               vi.plainText = vi.GiaiMa();
               txtText.Text = vi.plainText;
               txtCipher.Text = "";
          }

          private void txtKey_TextChanged(object sender, EventArgs e)
          {
               txtKey.Text = txtKey.Text.ToUpper();
          }

          private void label4_Click(object sender, EventArgs e)
          {

          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }
          public class RSAEncryption
          {
               #region Ham_MaHoa_GiaiMa
               public static byte[] MaHoa(byte[] dulieu, RSAParameters
              RSAKey, bool doOAEF)
               {
                    try
                    {
                         RSACryptoServiceProvider rsa = new
                        RSACryptoServiceProvider();
                         rsa.ImportParameters(RSAKey);
                         return rsa.Encrypt(dulieu, doOAEF);
                    }
                    catch (CryptographicException ex)
                    {
                         MessageBox.Show(ex.Message);
                         return null;
                    }
               }
               //byte[] PublicKey1;
               //byte[] PublicKey = {48,49,50,51,52,53,54,55,56,57,58,59,60};

               public static byte[] GiaiMa(byte[] dulieu, RSAParameters
              RSAKey, bool doOAEF)
               {
                    try
                    {

                         RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();



                         rsa.ImportParameters(RSAKey);
                         return rsa.Decrypt(dulieu, doOAEF);

                    }
                    catch (CryptographicException ex)
                    {
                         MessageBox.Show(ex.Message);
                         return null;
                    }
               }
               #endregion
          }
          #region BienTrungGian
          RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
          byte[] plaintText;
          byte[] cipherText;
          #endregion
          private void btnGiaiMa_Click(object sender, EventArgs e)
          {
               
               byte[] decryptText = RSAEncryption.GiaiMa(cipherText, rsa.ExportParameters(true), false);
               txtGiaiMa2.Text = Encoding.UTF8.GetString(decryptText);
          }

          private void button3_Click(object sender, EventArgs e)
          {
               plaintText = Encoding.UTF8.GetBytes(txtKiTu.Text);
               cipherText = RSAEncryption.MaHoa(plaintText,
               rsa.ExportParameters(false), false);
               //txtCipherText.Text =
               Encoding.UTF8.GetString(cipherText);
               StringBuilder sbHash = new StringBuilder();
               foreach (byte b in cipherText)
                    sbHash.Append(String.Format("{0:x2}", b));
               txtGiaiMa.Text = sbHash.ToString();
          }

          private void btnVi_Click(object sender, EventArgs e)
          {
               vi.key = txtKey.Text;
               vi.plainText = txtText.Text;
               vi.cipherText = vi.MaHoa();
               txtText.Text = "";
               txtCipher.Text = vi.cipherText;
          }

          private void button2_Click(object sender, EventArgs e)
          {
               vi.key = txtKey.Text;
               vi.cipherText = txtCipher.Text;
               txtText.Text = vi.GiaiMa();
               txtCipher.Text = "";
          }
     }
}
