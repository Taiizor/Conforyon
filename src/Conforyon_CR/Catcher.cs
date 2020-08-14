using System;
using Conforyon;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Conforyon_CR
{
    public partial class Catcher : Form
    {
        public Catcher()
        {
            InitializeComponent();
            textBox2.Text = Application.ExecutablePath;
        }

        private bool Unicoder = true;

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

        private async void Button5_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                await Task.Run
                (
                    async () =>
                    {
                        textBox3.Text = await Hash.FILEtoHASH_Async(Conforyon.Conforyon.HashType.SHA512, textBox2.Text, false, "Error!");
                        textBox4.Text = await Hash.FILEtoHASH_Async(Conforyon.Conforyon.HashType.SHA512, textBox2.Text, true, "Error!");
                    }
                );
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Crypto.TEXTtoMD5(textBox5.Text, "Error!"));
            MessageBox.Show(Crypto.TEXTtoSHA1(textBox5.Text, "Error!"));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Unicoder)
                textBox7.Text = Unicode.CHARtoASCII(textBox6.Text, textBox8.Text.ToCharArray()[0], "Error!");
            else
                textBox6.Text = Unicode.ASCIItoCHAR(textBox7.Text, textBox8.Text.ToCharArray()[0], "Error!");
            Unicoder = !Unicoder;
        }
    }
}