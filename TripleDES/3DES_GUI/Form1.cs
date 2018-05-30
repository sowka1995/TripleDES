using _3DES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DES_GUI
{
    public partial class Form1 : Form
    {
        private string keyHex;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            keyHex = TripleDES.GetRandomKeyHex();
            labelKey.Text = keyHex;
        }

        private void btnKeyGenerator_Click(object sender, EventArgs e)
        {
            keyHex = TripleDES.GetRandomKeyHex();
            labelKey.Text = keyHex;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string toEncrypt = textInput.Text;
            string toEncryptHex = HexConverter.StrToHex(toEncrypt);
            string encryptedHex = TripleDES.Encrypt(keyHex, toEncryptHex);
            textResult.Text = encryptedHex;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string toDecrypt = textInput.Text;
            string decryptedText = TripleDES.Decrypt(keyHex, toDecrypt);
            textResult.Text = decryptedText;
        }

        private void textInput_DoubleClick(object sender, EventArgs e)
        {
            textInput.SelectAll();
        }

        private void textResult_DoubleClick(object sender, EventArgs e)
        {
            textResult.SelectAll();
        }
    }
}
