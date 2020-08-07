using System;
using Conforyon;
using System.Windows.Forms;

namespace Conforyon_CR
{
    public partial class Catcher : Form
    {
        public Catcher()
        {
            InitializeComponent();
            textBox2.Text = Application.ExecutablePath;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataStorage.AutoDataConvert(textBox1.Text, Conforyon.Conforyon.StorageType.PB, true, true, true, 2, "Hata!"));
            MessageBox.Show(DataStorage.DataConvert(textBox1.Text, Conforyon.Conforyon.StorageType.PB, Conforyon.Conforyon.StorageType.EB, true, true, 2, "Hata!"));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Hash.FILEtoSHA512(textBox2.Text, false, "Error!");
            textBox4.Text = Hash.FILEtoSHA512(textBox2.Text, true, "Error!");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Crypto.TEXTtoMD5(textBox5.Text, "Error!"));
            MessageBox.Show(Crypto.TEXTtoSHA1(textBox5.Text, "Error!"));
        }
    }
}