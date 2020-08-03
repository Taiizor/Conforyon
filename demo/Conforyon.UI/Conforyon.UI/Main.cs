using System;
using System.Windows.Forms;
using static Conforyon.Hash;
using static Conforyon.Color;
using static Conforyon.Crypto;
using System.Text.RegularExpressions;
using static Conforyon.Unicode;
using static Conforyon.Storage;
using static Conforyon.Typography;
using static Conforyon.Temperature;

namespace Conforyon.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string Seçim1, Seçim2, Seçim6, Seçim12, Seçim13, Seçim14;
        bool Seçim3, Seçim4, Seçim5, Seçim7, Seçim8, Seçim9, Seçim10, Seçim11, Seçim15, Seçim16;

        private void ComboBox()
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                    Seçim1 = "Bit";
                else if (comboBox1.SelectedIndex == 1)
                    Seçim1 = "Byte";
                else if (comboBox1.SelectedIndex == 2)
                    Seçim1 = "KB";
                else if (comboBox1.SelectedIndex == 3)
                    Seçim1 = "MB";
                else if (comboBox1.SelectedIndex == 4)
                    Seçim1 = "GB";
                else if (comboBox1.SelectedIndex == 5)
                    Seçim1 = "TB";
                else if (comboBox1.SelectedIndex == 6)
                    Seçim1 = "PB";
                else if (comboBox1.SelectedIndex == 7)
                    Seçim1 = "EB";
                else if (comboBox1.SelectedIndex == 8)
                    Seçim1 = "ZB";
                else if (comboBox1.SelectedIndex == 9)
                    Seçim1 = "YB";
                if (comboBox2.SelectedIndex == 0)
                    Seçim2 = "Bit";
                else if (comboBox2.SelectedIndex == 1)
                    Seçim2 = "Byte";
                else if (comboBox2.SelectedIndex == 2)
                    Seçim2 = "KB";
                else if (comboBox2.SelectedIndex == 3)
                    Seçim2 = "MB";
                else if (comboBox2.SelectedIndex == 4)
                    Seçim2 = "GB";
                else if (comboBox2.SelectedIndex == 5)
                    Seçim2 = "TB";
                else if (comboBox2.SelectedIndex == 6)
                    Seçim2 = "PB";
                else if (comboBox2.SelectedIndex == 7)
                    Seçim2 = "EB";
                else if (comboBox2.SelectedIndex == 8)
                    Seçim2 = "ZB";
                else if (comboBox2.SelectedIndex == 9)
                    Seçim2 = "YB";
                if (comboBox3.SelectedIndex == 0)
                    Seçim3 = true;
                else
                    Seçim3 = false;
                if (comboBox4.SelectedIndex == 0)
                    Seçim4 = true;
                else
                    Seçim4 = false;
                if (comboBox5.SelectedIndex == 0)
                    Seçim5 = true;
                else
                    Seçim5 = false;
                if (comboBox6.SelectedIndex == 0)
                    Seçim6 = "C=>F";
                else
                    Seçim6 = "F=>C";
                if (comboBox7.SelectedIndex == 0)
                    Seçim7 = true;
                else
                    Seçim7 = false;
                if (comboBox8.SelectedIndex == 0)
                    Seçim8 = true;
                else
                    Seçim8 = false;
                if (comboBox9.SelectedIndex == 0)
                    Seçim9 = true;
                else
                    Seçim9 = false;
                if (comboBox10.SelectedIndex == 0)
                    Seçim10 = true;
                else
                    Seçim10 = false;
                if (comboBox11.SelectedIndex == 0)
                    Seçim11 = true;
                else
                    Seçim11 = false;
                if (comboBox12.SelectedIndex == 0)
                    Seçim12 = "Text=>Base64";
                else if (comboBox12.SelectedIndex == 1)
                    Seçim12 = "Text=>MD5";
                else if (comboBox12.SelectedIndex == 2)
                    Seçim12 = "Text=>SHA1";
                else if (comboBox12.SelectedIndex == 3)
                    Seçim12 = "Text=>SHA256";
                else if (comboBox12.SelectedIndex == 4)
                    Seçim12 = "Text=>SHA384";
                else if (comboBox12.SelectedIndex == 5)
                    Seçim12 = "Text=>SHA512";
                else if (comboBox12.SelectedIndex == 6)
                    Seçim12 = "Base64=>Text";
                if (comboBox17.SelectedIndex == 0)
                    Seçim13 = "INCH";
                else if (comboBox17.SelectedIndex == 1)
                    Seçim13 = "CM";
                else
                    Seçim13 = "PX";
                if (comboBox13.SelectedIndex == 0)
                    Seçim14 = "INCH";
                else if (comboBox13.SelectedIndex == 1)
                    Seçim14 = "CM";
                else
                    Seçim14 = "PX";
                if (comboBox16.SelectedIndex == 0)
                    Seçim15 = true;
                else
                    Seçim15 = false;
                if (comboBox15.SelectedIndex == 0)
                    Seçim16 = true;
                else
                    Seçim16 = false;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void TextBox_Tuş(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox5.Text, "[^0-9]"))
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox6.Text, "[^0-9]"))
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox7.Text, "[^0-9]"))
                textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox9.Text, "[^0-9]"))
                textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox10.Text, "[^0-9]"))
                textBox10.Text = textBox10.Text.Remove(textBox10.Text.Length - 1);
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox15.Text, "[^0-9]"))
                textBox15.Text = textBox15.Text.Remove(textBox15.Text.Length - 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox7.Text))
                    textBox7.Text = "1";
                textBox4.Text = Convert(textBox3.Text, Seçim1, Seçim2, Seçim3, Seçim4, System.Convert.ToInt32(textBox7.Text), "Hata!");
                button4.Cursor = Cursors.Hand;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox7.Text))
                    textBox7.Text = "1";
                textBox4.Text = AutoConvert(textBox3.Text, Seçim1, Seçim5, Seçim3, Seçim4, System.Convert.ToInt32(textBox7.Text), "Hata!");
                button4.Cursor = Cursors.Hand;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int C1 = comboBox1.SelectedIndex;
                int C2 = comboBox2.SelectedIndex;
                comboBox1.SelectedIndex = C2;
                comboBox2.SelectedIndex = C1;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (button4.Cursor == Cursors.Hand)
                {
                    button4.Cursor = Cursors.No;
                    Clipboard.SetDataObject(textBox4.Text, false);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox5.Text))
                    textBox5.Text = "1";
                if (Seçim6 == "C=>F")
                    textBox2.Text = CtoF(textBox1.Text, Seçim9, Seçim8, System.Convert.ToInt32(textBox5.Text), Seçim7, "Hata!");
                else
                    textBox2.Text = FtoC(textBox1.Text, Seçim9, Seçim8, System.Convert.ToInt32(textBox5.Text), Seçim7, "Hata!");
                button6.Cursor = Cursors.Hand;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (button6.Cursor == Cursors.Hand)
                {
                    button6.Cursor = Cursors.No;
                    Clipboard.SetDataObject(textBox2.Text, false);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.SelectedIndex == 0)
                    comboBox6.SelectedIndex = 1;
                else
                    comboBox6.SelectedIndex = 0;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox10.SelectedIndex == 0)
                    comboBox10.SelectedIndex = 1;
                else
                    comboBox10.SelectedIndex = 0;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (button9.Cursor == Cursors.Hand)
                {
                    button9.Cursor = Cursors.No;
                    Clipboard.SetDataObject(textBox8.Text, false);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (button10.Cursor == Cursors.Hand)
                {
                    button10.Cursor = Cursors.No;
                    Clipboard.SetDataObject(textBox6.Text + ", " + textBox9.Text + ", " + textBox10.Text, false);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Seçim10 == true)
                    textBox8.Text = RGBtoHEX(textBox6.Text, textBox9.Text, textBox10.Text, false, "Hata!");
                else
                {
                    textBox6.Text = HEXtoRGB(textBox8.Text, 8, "Hata!");
                    textBox9.Text = HEXtoRGB(textBox8.Text, 9, "Hata!");
                    textBox10.Text = HEXtoRGB(textBox8.Text, 10, "Hata!");
                }

                button9.Cursor = Cursors.Hand;
                button10.Cursor = Cursors.Hand;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == 0)
                comboBox11.SelectedIndex = 1;
            else
                comboBox11.SelectedIndex = 0;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (button13.Cursor == Cursors.Hand)
                {
                    button13.Cursor = Cursors.No;
                    Clipboard.SetDataObject(textBox11.Text, false);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (button14.Cursor == Cursors.Hand)
                {
                    button14.Cursor = Cursors.No;
                    Clipboard.SetDataObject(textBox12.Text, false);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Seçim11 == true)
                    textBox12.Text = CHARtoASCII(textBox11.Text, "Hata!");
                else
                    textBox11.Text = ASCIItoCHAR(textBox12.Text, "Hata!");
                button13.Cursor = Cursors.Hand;
                button14.Cursor = Cursors.Hand;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Seçim12 == "Text=>Base64")
                    textBox13.Text = TEXTtoBASE64(textBox14.Text, "Hata!");
                else if (Seçim12 == "Text=>MD5")
                    textBox13.Text = TEXTtoMD5(textBox14.Text, "Hata!");
                else if (Seçim12 == "Textar=>SHA1")
                    textBox13.Text = TEXTtoSHA1(textBox14.Text, "Hata!");
                else if (Seçim12 == "Text=>SHA256")
                    textBox13.Text = TEXTtoSHA256(textBox14.Text, "Hata!");
                else if (Seçim12 == "Text=>SHA384")
                    textBox13.Text = TEXTtoSHA384(textBox14.Text, "Hata!");
                else if (Seçim12 == "Text=>SHA512")
                    textBox13.Text = TEXTtoSHA512(textBox14.Text, "Hata!");
                else if (Seçim12 == "Base64=>Text")
                    textBox13.Text = BASE64toTEXT(textBox14.Text, "Hata!");
                button17.Cursor = Cursors.Hand;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (button17.Cursor == Cursors.Hand)
            {
                button17.Cursor = Cursors.No;
                Clipboard.SetDataObject(textBox13.Text, false);
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (button18.Cursor == Cursors.Hand)
            {
                button18.Cursor = Cursors.No;
                Clipboard.SetDataObject(textBox16.Text, false);
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == 0)
                comboBox12.SelectedIndex = 6;
            else if (comboBox12.SelectedIndex == 6)
                comboBox12.SelectedIndex = 0;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                int C1 = comboBox17.SelectedIndex;
                int C2 = comboBox13.SelectedIndex;
                comboBox17.SelectedIndex = C2;
                comboBox13.SelectedIndex = C1;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox15.Text))
                    textBox15.Text = "1";
                if (Seçim13 == "INCH")
                {
                    if (Seçim14 == "CM")
                        textBox16.Text = INCHtoCM(textBox17.Text, Seçim15, Seçim16, System.Convert.ToInt32(textBox15.Text), "Hata!");
                    else if (Seçim14 == "PX")
                        textBox16.Text = INCHtoPX(textBox17.Text, Seçim15, Seçim16, System.Convert.ToInt32(textBox15.Text), "Hata!");
                    else
                        textBox16.Text = "Hata!";
                }
                else if (Seçim13 == "CM")
                {
                    if (Seçim14 == "INCH")
                        textBox16.Text = CMtoINCH(textBox17.Text, Seçim15, Seçim16, System.Convert.ToInt32(textBox15.Text), "Hata!");
                    else if (Seçim14 == "PX")
                        textBox16.Text = CMtoPX(textBox17.Text, Seçim15, Seçim16, System.Convert.ToInt32(textBox15.Text), "Hata!");
                    else
                        textBox16.Text = "Hata!";
                }
                else if (Seçim13 == "PX")
                {
                    if (Seçim14 == "INCH")
                        textBox16.Text = PXtoINCH(textBox17.Text, Seçim15, Seçim16, System.Convert.ToInt32(textBox15.Text), "Hata!");
                    else if (Seçim14 == "CM")
                        textBox16.Text = PXtoCM(textBox17.Text, Seçim15, Seçim16, System.Convert.ToInt32(textBox15.Text), "Hata!");
                    else
                        textBox16.Text = "Hata!";
                }
                button18.Cursor = Cursors.Hand;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                this.CenterToScreen();
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf("GigaByte");
                comboBox2.SelectedIndex = comboBox2.Items.IndexOf("MegaByte");
                comboBox3.SelectedIndex = comboBox3.Items.IndexOf("Ondalık Açık");
                comboBox4.SelectedIndex = comboBox4.Items.IndexOf("Küsürat Kapalı");
                comboBox5.SelectedIndex = comboBox5.Items.IndexOf("Çevir2 Tür Açık");
                comboBox6.SelectedIndex = comboBox6.Items.IndexOf("C - Celsius => F - Fahrenheit");
                comboBox7.SelectedIndex = comboBox7.Items.IndexOf("Çevir3 Tür Açık");
                comboBox8.SelectedIndex = comboBox8.Items.IndexOf("Küsürat Açık");
                comboBox9.SelectedIndex = comboBox9.Items.IndexOf("Ondalık Açık");
                comboBox10.SelectedIndex = comboBox10.Items.IndexOf("RGB => HEX");
                comboBox11.SelectedIndex = comboBox11.Items.IndexOf("Char => ASCII");
                comboBox12.SelectedIndex = comboBox12.Items.IndexOf("Text => Base64");
                comboBox13.SelectedIndex = comboBox13.Items.IndexOf("CM");
                comboBox17.SelectedIndex = comboBox17.Items.IndexOf("INCH");
                comboBox15.SelectedIndex = comboBox4.Items.IndexOf("Küsürat Açık");
                comboBox16.SelectedIndex = comboBox3.Items.IndexOf("Ondalık Açık");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }
    }
}