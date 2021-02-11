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

        private bool Unicoder = true;
        private bool Temperaturer = true;
        private bool Speeder = true;

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataStorage.AutoDataConvert(textBox1.Text, Conforyon.Conforyon.StorageType.PB, true, true, true, 2, "Error!"));
            MessageBox.Show(DataStorage.DataConvert(textBox1.Text, Conforyon.Conforyon.StorageType.PB, Conforyon.Conforyon.StorageType.EB, true, true, 2, "Error!"));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Hash.FILEtoSHA512(textBox2.Text, false, "Error!");
            textBox4.Text = Hash.FILEtoSHA512(textBox2.Text, true, "Error!");
        }

        private async void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Coming Soon!");

                textBox3.Text = await Hash.FILEtoHASH_Async(Conforyon.Conforyon.HashType.SHA512, textBox2.Text, false, "Error!");
                textBox4.Text = await Hash.FILEtoHASH_Async(Conforyon.Conforyon.HashType.SHA512, textBox2.Text, true, "Error!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Crypto.TEXTtoMD5(textBox5.Text, false, "Error!") + "\n" + Crypto.TEXTtoMD5(textBox5.Text, true, "Error!"));
            MessageBox.Show(Crypto.TEXTtoSHA1(textBox5.Text, false, "Error!") + "\n" + Crypto.TEXTtoSHA1(textBox5.Text, true, "Error!"));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Unicoder)
            {
                textBox7.Text = Unicode.CHARtoASCII(textBox6.Text, textBox8.Text.ToCharArray()[0], "Error!");
            }
            else
            {
                textBox6.Text = Unicode.ASCIItoCHAR(textBox7.Text, textBox8.Text.ToCharArray()[0], "Error!");
            }

            Unicoder = !Unicoder;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Color.RGBtoHEX(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), true, "Error!"));
            MessageBox.Show(Color.RGBtoHEX(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), false, "Error!"));
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Temperaturer)
            {
                textBox13.Text = Temperature.CtoF(textBox12.Text, false, false, 0, false, "Error!");
            }
            else
            {
                textBox12.Text = Temperature.FtoC(textBox13.Text, false, false, 0, false, "Error!");
            }

            Temperaturer = !Temperaturer;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (Speeder)
            {
                textBox15.Text = Speed.MPHtoKPH(textBox14.Text, false, false, 0, false, "Error!");
            }
            else
            {
                textBox14.Text = Speed.KPHtoMPH(textBox15.Text, false, false, 0, false, "Error!");
            }

            Speeder = !Speeder;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Time.AutoTimeConvert(textBox16.Text, Conforyon.Conforyon.TimeType.Second, true, true, true, 2, "Error!"));
            MessageBox.Show(Time.TimeConvert(textBox16.Text, Conforyon.Conforyon.TimeType.Second, Conforyon.Conforyon.TimeType.Day, true, true, 2, "Error!"));
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Conforyon.Conforyon.GetValues("DataStorage", "PB", "EB", "Error!"));
            MessageBox.Show(Conforyon.Conforyon.SetValues("DataStorage", "PB", "EB", "3333", "Error!"));

            MessageBox.Show(Conforyon.Conforyon.GetValues("Temperature", "Celsius", "Multipy", "Error!"));
            MessageBox.Show(Conforyon.Conforyon.SetValues("Temperature", "Celsius", "Multipy", "18", "Error!"));
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Typography.INCHtoCM(textBox17.Text, true, true, 2, "Error!") + " - INCH => CM");
            MessageBox.Show(Typography.INCHtoPX(textBox17.Text, true, true, 2, "Error!") + " - INCH => PX");

            MessageBox.Show(Typography.CMtoINCH(textBox17.Text, true, true, 2, "Error!") + " - CM => INCH");
            MessageBox.Show(Typography.CMtoPX(textBox17.Text, true, true, 2, "Error!") + " - CM => PX");

            MessageBox.Show(Typography.PXtoINCH(textBox17.Text, true, true, 2, "Error!") + " - PX => INCH");
            MessageBox.Show(Typography.PXtoCM(textBox17.Text, true, true, 2, "Error!") + " - PX => CM");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Conforyon.Conforyon.ListValuesJson());
        }
    }
}