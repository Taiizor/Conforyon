using Conforyon.Color;
using Conforyon.Cryptology;
using Conforyon.Hash;
using Conforyon.Speed;
using Conforyon.Storage;
using Conforyon.Temperature;
using Conforyon.Time;
using Conforyon.Typology;
using Conforyon.Unicode;
using Conforyon.Value;
using System;
using System.Windows.Forms;
using static Conforyon.Enum.Enums;
using CCC = Conforyon.Culture.Cultures;
using CEEMT = Conforyon.Enum.Enums.MethodType;

namespace Conforyon_CR
{
    public partial class Catcher : Form
    {
        public Catcher()
        {
            InitializeComponent();
            textBox2.Text = Application.ExecutablePath;
            CCC.SetAllCulture("en-GB");
        }

        private bool Unicoder = true;
        private bool Temperaturer = true;
        private bool Speeder = true;

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataStorage.AutoDataConvert(textBox1.Text, StorageType.PB, true, true, true, 2, "Error!"));
            MessageBox.Show(DataStorage.DataConvert(textBox1.Text, StorageType.PB, StorageType.EB, true, true, 2, "Error!"));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = FILE.SHA512(textBox2.Text, false, "Error!");
            textBox4.Text = FILE.SHA512(textBox2.Text, true, "Error!");
        }

        private async void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Coming Soon!");

                textBox3.Text = await FILE.HASH_Async(HashType.SHA512, textBox2.Text, false, "Error!");
                textBox4.Text = await FILE.HASH_Async(HashType.SHA512, textBox2.Text, true, "Error!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AES.Encrypt("Taiizor"));
            MessageBox.Show(AES.Decrypt(AES.Encrypt("Taiizor")));

            MessageBox.Show(TEXT.BASE(textBox5.Text, "Error!"));

            MessageBox.Show(TEXT.MD5(textBox5.Text, false, "Error!") + "\n" + TEXT.MD5(textBox5.Text, true, "Error!"));
            MessageBox.Show(TEXT.SHA1(textBox5.Text, false, "Error!") + "\n" + TEXT.SHA1(textBox5.Text, true, "Error!"));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Unicoder)
            {
                textBox7.Text = CHAR.ASCII(textBox6.Text, textBox8.Text.ToCharArray()[0], "Error!");
            }
            else
            {
                textBox6.Text = ASCII.CHAR(textBox7.Text, textBox8.Text.ToCharArray()[0], "Error!");
            }

            Unicoder = !Unicoder;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RGB.HEX(textBox9.Text, textBox10.Text, textBox11.Text, true, "Error!"));
            MessageBox.Show(RGB.HEX(textBox9.Text, textBox10.Text, textBox11.Text, false, "Error!"));
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Temperaturer)
            {
                textBox13.Text = Celsius.Fahrenheit(textBox12.Text, false, false, 0, false, "Error!");
            }
            else
            {
                textBox12.Text = Fahrenheit.Celsius(textBox13.Text, false, false, 0, false, "Error!");
            }

            Temperaturer = !Temperaturer;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (Speeder)
            {
                textBox15.Text = MPH.KPH(textBox14.Text, false, false, 0, false, "Error!");
            }
            else
            {
                textBox14.Text = KPH.MPH(textBox15.Text, false, false, 0, false, "Error!");
            }

            Speeder = !Speeder;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Times.AutoTimeConvert(textBox16.Text, TimeType.Second, true, true, true, 2, "Error!"));
            MessageBox.Show(Times.TimeConvert(textBox16.Text, TimeType.Second, TimeType.Day, true, true, 2, "Error!"));
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Values.GetValue(CEEMT.DataStorage, "PB", "EB", "Error!"));
            MessageBox.Show(Values.SetValue(CEEMT.DataStorage, "PB", "EB", "3333", "Error!"));

            MessageBox.Show(Values.GetValue(CEEMT.Temperature, "Celsius", "Multipy", "Error!"));
            MessageBox.Show(Values.SetValue(CEEMT.Temperature, "Celsius", "Multipy", "18", "Error!"));
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(INCH.CM(textBox17.Text, true, true, 2, "Error!") + " - INCH => CM");
            MessageBox.Show(INCH.PX(textBox17.Text, true, true, 2, "Error!") + " - INCH => PX");

            MessageBox.Show(CM.INCH(textBox17.Text, true, true, 2, "Error!") + " - CM => INCH");
            MessageBox.Show(CM.PX(textBox17.Text, true, true, 2, "Error!") + " - CM => PX");

            MessageBox.Show(PX.INCH(textBox17.Text, true, true, 2, "Error!") + " - PX => INCH");
            MessageBox.Show(PX.CM(textBox17.Text, true, true, 2, "Error!") + " - PX => CM");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Values.ListValueJson());
        }
    }
}