using System;
using Conforyon;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Conforyon.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Conforyon.StorageType Selection1, Selection2;
        Conforyon.TimeType Selection18, Selection19;
        string Selection6, Selection12, Selection13, Selection14, Selection17;
        bool Selection3, Selection4, Selection5, Selection7, Selection8, Selection9, Selection10, Selection11, Selection15, Selection16, Selection20, Selection21, Selection22;

        private void ComboBox()
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                    Selection1 = Conforyon.StorageType.Bit;
                else if (comboBox1.SelectedIndex == 1)
                    Selection1 = Conforyon.StorageType.Byte;
                else if (comboBox1.SelectedIndex == 2)
                    Selection1 = Conforyon.StorageType.KB;
                else if (comboBox1.SelectedIndex == 3)
                    Selection1 = Conforyon.StorageType.MB;
                else if (comboBox1.SelectedIndex == 4)
                    Selection1 = Conforyon.StorageType.GB;
                else if (comboBox1.SelectedIndex == 5)
                    Selection1 = Conforyon.StorageType.TB;
                else if (comboBox1.SelectedIndex == 6)
                    Selection1 = Conforyon.StorageType.PB;
                else if (comboBox1.SelectedIndex == 7)
                    Selection1 = Conforyon.StorageType.EB;
                else if (comboBox1.SelectedIndex == 8)
                    Selection1 = Conforyon.StorageType.ZB;
                else if (comboBox1.SelectedIndex == 9)
                    Selection1 = Conforyon.StorageType.YB;
                if (comboBox2.SelectedIndex == 0)
                    Selection2 = Conforyon.StorageType.Bit;
                else if (comboBox2.SelectedIndex == 1)
                    Selection2 = Conforyon.StorageType.Byte;
                else if (comboBox2.SelectedIndex == 2)
                    Selection2 = Conforyon.StorageType.KB;
                else if (comboBox2.SelectedIndex == 3)
                    Selection2 = Conforyon.StorageType.MB;
                else if (comboBox2.SelectedIndex == 4)
                    Selection2 = Conforyon.StorageType.GB;
                else if (comboBox2.SelectedIndex == 5)
                    Selection2 = Conforyon.StorageType.TB;
                else if (comboBox2.SelectedIndex == 6)
                    Selection2 = Conforyon.StorageType.PB;
                else if (comboBox2.SelectedIndex == 7)
                    Selection2 = Conforyon.StorageType.EB;
                else if (comboBox2.SelectedIndex == 8)
                    Selection2 = Conforyon.StorageType.ZB;
                else if (comboBox2.SelectedIndex == 9)
                    Selection2 = Conforyon.StorageType.YB;
                if (comboBox3.SelectedIndex == 0)
                    Selection3 = true;
                else
                    Selection3 = false;
                if (comboBox4.SelectedIndex == 0)
                    Selection4 = true;
                else
                    Selection4 = false;
                if (comboBox5.SelectedIndex == 0)
                    Selection5 = true;
                else
                    Selection5 = false;
                if (comboBox6.SelectedIndex == 0)
                    Selection6 = "C=>F";
                else
                    Selection6 = "F=>C";
                if (comboBox7.SelectedIndex == 0)
                    Selection7 = true;
                else
                    Selection7 = false;
                if (comboBox8.SelectedIndex == 0)
                    Selection8 = true;
                else
                    Selection8 = false;
                if (comboBox9.SelectedIndex == 0)
                    Selection9 = true;
                else
                    Selection9 = false;
                if (comboBox10.SelectedIndex == 0)
                    Selection10 = true;
                else
                    Selection10 = false;
                if (comboBox11.SelectedIndex == 0)
                    Selection11 = true;
                else
                    Selection11 = false;
                if (comboBox12.SelectedIndex == 0)
                    Selection12 = "Text=>Base64";
                else if (comboBox12.SelectedIndex == 1)
                    Selection12 = "Text=>MD5";
                else if (comboBox12.SelectedIndex == 2)
                    Selection12 = "Text=>SHA1";
                else if (comboBox12.SelectedIndex == 3)
                    Selection12 = "Text=>SHA256";
                else if (comboBox12.SelectedIndex == 4)
                    Selection12 = "Text=>SHA384";
                else if (comboBox12.SelectedIndex == 5)
                    Selection12 = "Text=>SHA512";
                else if (comboBox12.SelectedIndex == 6)
                    Selection12 = "Base64=>Text";
                if (comboBox17.SelectedIndex == 0)
                    Selection13 = "INCH";
                else if (comboBox17.SelectedIndex == 1)
                    Selection13 = "CM";
                else
                    Selection13 = "PX";
                if (comboBox13.SelectedIndex == 0)
                    Selection14 = "INCH";
                else if (comboBox13.SelectedIndex == 1)
                    Selection14 = "CM";
                else
                    Selection14 = "PX";
                if (comboBox16.SelectedIndex == 0)
                    Selection15 = true;
                else
                    Selection15 = false;
                if (comboBox15.SelectedIndex == 0)
                    Selection16 = true;
                else
                    Selection16 = false;
                if (comboBox14.SelectedIndex == 0)
                    Selection17 = "FILE=>MD5";
                else if (comboBox14.SelectedIndex == 1)
                    Selection17 = "FILE=>SHA1";
                else if (comboBox14.SelectedIndex == 2)
                    Selection17 = "FILE=>SHA256";
                else if (comboBox14.SelectedIndex == 3)
                    Selection17 = "FILE=>SHA384";
                else if (comboBox14.SelectedIndex == 4)
                    Selection17 = "FILE=>SHA512";

                if (comboBox22.SelectedIndex == 0)
                    Selection18 = Conforyon.TimeType.Microsecond;
                else if (comboBox22.SelectedIndex == 1)
                    Selection18 = Conforyon.TimeType.Millisecond;
                else if (comboBox22.SelectedIndex == 2)
                    Selection18 = Conforyon.TimeType.Second;
                else if (comboBox22.SelectedIndex == 3)
                    Selection18 = Conforyon.TimeType.Minute;
                else if (comboBox22.SelectedIndex == 4)
                    Selection18 = Conforyon.TimeType.Hour;
                else if (comboBox22.SelectedIndex == 5)
                    Selection18 = Conforyon.TimeType.Day;
                else if (comboBox22.SelectedIndex == 6)
                    Selection18 = Conforyon.TimeType.Week;
                else if (comboBox22.SelectedIndex == 7)
                    Selection18 = Conforyon.TimeType.Year;

                if (comboBox19.SelectedIndex == 0)
                    Selection19 = Conforyon.TimeType.Microsecond;
                else if (comboBox19.SelectedIndex == 1)
                    Selection19 = Conforyon.TimeType.Millisecond;
                else if (comboBox19.SelectedIndex == 2)
                    Selection19 = Conforyon.TimeType.Second;
                else if (comboBox19.SelectedIndex == 3)
                    Selection19 = Conforyon.TimeType.Minute;
                else if (comboBox19.SelectedIndex == 4)
                    Selection19 = Conforyon.TimeType.Hour;
                else if (comboBox19.SelectedIndex == 5)
                    Selection19 = Conforyon.TimeType.Day;
                else if (comboBox19.SelectedIndex == 6)
                    Selection19 = Conforyon.TimeType.Week;
                else if (comboBox19.SelectedIndex == 7)
                    Selection19 = Conforyon.TimeType.Year;

                if (comboBox21.SelectedIndex == 0)
                    Selection20 = true;
                else
                    Selection20 = false;

                if (comboBox20.SelectedIndex == 0)
                    Selection21 = true;
                else
                    Selection21 = false;

                if (comboBox18.SelectedIndex == 0)
                    Selection22 = true;
                else
                    Selection22 = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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
                textBox4.Text = DataStorage.DataConvert(textBox3.Text, Selection1, Selection2, Selection3, Selection4, Convert.ToInt32(textBox7.Text), "Error!");
                button4.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox7.Text))
                    textBox7.Text = "1";
                textBox4.Text = DataStorage.AutoDataConvert(textBox3.Text, Selection1, Selection5, Selection3, Selection4, Convert.ToInt32(textBox7.Text), "Error!");
                button4.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (button4.Cursor == Cursors.Hand)
                {
                    button4.Cursor = Cursors.No;
                    ClipBoard.CopyText(textBox4.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox5.Text))
                    textBox5.Text = "1";
                if (Selection6 == "C=>F")
                    textBox2.Text = Temperature.CtoF(textBox1.Text, Selection9, Selection8, Convert.ToInt32(textBox5.Text), Selection7, "Error!");
                else
                    textBox2.Text = Temperature.FtoC(textBox1.Text, Selection9, Selection8, Convert.ToInt32(textBox5.Text), Selection7, "Error!");
                button6.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (button6.Cursor == Cursors.Hand)
                {
                    button6.Cursor = Cursors.No;
                    ClipBoard.CopyText(textBox2.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (button9.Cursor == Cursors.Hand)
                {
                    button9.Cursor = Cursors.No;
                    ClipBoard.CopyText(textBox8.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox21.Text))
                    textBox21.Text = "1";
                textBox22.Text = Time.AutoTimeConvert(textBox23.Text, Selection18, Selection22, Selection20, Selection21, Convert.ToInt32(textBox21.Text), "Error!");
                button24.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (button23.Cursor == Cursors.Hand)
                {
                    button23.Cursor = Cursors.No;
                    ClipBoard.CopyText(textBox19.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            try
            {
                int C1 = comboBox22.SelectedIndex;
                int C2 = comboBox19.SelectedIndex;
                comboBox22.SelectedIndex = C2;
                comboBox19.SelectedIndex = C1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox21.Text))
                    textBox21.Text = "1";
                textBox22.Text = Time.TimeConvert(textBox23.Text, Selection18, Selection19, Selection20, Selection21, Convert.ToInt32(textBox21.Text), "Error!");
                button24.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (button24.Cursor == Cursors.Hand)
                {
                    button24.Cursor = Cursors.No;
                    ClipBoard.CopyText(textBox22.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection17 == "FILE=>MD5")
                    textBox19.Text = Hash.FILEtoMD5(textBox20.Text, false, "Error!");
                else if (Selection17 == "FILE=>SHA1")
                    textBox19.Text = Hash.FILEtoSHA1(textBox20.Text, false, "Error!");
                else if (Selection17 == "FILE=>SHA256")
                    textBox19.Text = Hash.FILEtoSHA256(textBox20.Text, false, "Error!");
                else if (Selection17 == "FILE=>SHA384")
                    textBox19.Text = Hash.FILEtoSHA384(textBox20.Text, false, "Error!");
                else if (Selection17 == "FILE=>SHA512")
                    textBox19.Text = Hash.FILEtoSHA512(textBox20.Text, false, "Error!");
                button23.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (button10.Cursor == Cursors.Hand)
                {
                    button10.Cursor = Cursors.No;
                    ClipBoard.CopyText(textBox6.Text + ", " + textBox9.Text + ", " + textBox10.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection10)
                    textBox8.Text = Color.RGBtoHEX(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), false, "Error!");
                else
                {
                    textBox6.Text = Color.HEXtoRGB(textBox8.Text, Conforyon.ColorType.OnlyR, "Error!");
                    textBox9.Text = Color.HEXtoRGB(textBox8.Text, Conforyon.ColorType.OnlyG, "Error!");
                    textBox10.Text = Color.HEXtoRGB(textBox8.Text, Conforyon.ColorType.OnlyB, "Error!");
                }

                button9.Cursor = Cursors.Hand;
                button10.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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
                    ClipBoard.CopyText(textBox11.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (button14.Cursor == Cursors.Hand)
                {
                    button14.Cursor = Cursors.No;
                    ClipBoard.CopyText(textBox12.Text, false);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection11)
                    textBox12.Text = Unicode.CHARtoASCII(textBox11.Text, textBox18.Text.ToCharArray()[0], "Error!");
                else
                    textBox11.Text = Unicode.ASCIItoCHAR(textBox12.Text, textBox18.Text.ToCharArray()[0], "Error!");
                button13.Cursor = Cursors.Hand;
                button14.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection12 == "Text=>Base64")
                    textBox13.Text = Crypto.TEXTtoBASE64(textBox14.Text, "Error!");
                else if (Selection12 == "Text=>MD5")
                    textBox13.Text = Crypto.TEXTtoMD5(textBox14.Text, false, "Error!");
                else if (Selection12 == "Text=>SHA1")
                    textBox13.Text = Crypto.TEXTtoSHA1(textBox14.Text, false, "Error!");
                else if (Selection12 == "Text=>SHA256")
                    textBox13.Text = Crypto.TEXTtoSHA256(textBox14.Text, false, "Error!");
                else if (Selection12 == "Text=>SHA384")
                    textBox13.Text = Crypto.TEXTtoSHA384(textBox14.Text, false, "Error!");
                else if (Selection12 == "Text=>SHA512")
                    textBox13.Text = Crypto.TEXTtoSHA512(textBox14.Text, false, "Error!");
                else if (Selection12 == "Base64=>Text")
                    textBox13.Text = Crypto.BASE64toTEXT(textBox14.Text, "Error!");
                button17.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (button17.Cursor == Cursors.Hand)
            {
                button17.Cursor = Cursors.No;
                ClipBoard.CopyText(textBox13.Text, false);
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (button18.Cursor == Cursors.Hand)
            {
                button18.Cursor = Cursors.No;
                ClipBoard.CopyText(textBox16.Text, false);
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox15.Text))
                    textBox15.Text = "1";
                if (Selection13 == "INCH")
                {
                    if (Selection14 == "CM")
                        textBox16.Text = Typography.INCHtoCM(textBox17.Text, Selection15, Selection16, Convert.ToInt32(textBox15.Text), "Error!");
                    else if (Selection14 == "PX")
                        textBox16.Text = Typography.INCHtoPX(textBox17.Text, Selection15, Selection16, Convert.ToInt32(textBox15.Text), "Error!");
                    else
                        textBox16.Text = "Error!";
                }
                else if (Selection13 == "CM")
                {
                    if (Selection14 == "INCH")
                        textBox16.Text = Typography.CMtoINCH(textBox17.Text, Selection15, Selection16, Convert.ToInt32(textBox15.Text), "Error!");
                    else if (Selection14 == "PX")
                        textBox16.Text = Typography.CMtoPX(textBox17.Text, Selection15, Selection16, Convert.ToInt32(textBox15.Text), "Error!");
                    else
                        textBox16.Text = "Error!";
                }
                else if (Selection13 == "PX")
                {
                    if (Selection14 == "INCH")
                        textBox16.Text = Typography.PXtoINCH(textBox17.Text, Selection15, Selection16, Convert.ToInt32(textBox15.Text), "Error!");
                    else if (Selection14 == "CM")
                        textBox16.Text = Typography.PXtoCM(textBox17.Text, Selection15, Selection16, Convert.ToInt32(textBox15.Text), "Error!");
                    else
                        textBox16.Text = "Error!";
                }
                button18.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                this.CenterToScreen();
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf("GigaByte");
                comboBox2.SelectedIndex = comboBox2.Items.IndexOf("MegaByte");
                comboBox3.SelectedIndex = comboBox3.Items.IndexOf("Decimal On");
                comboBox4.SelectedIndex = comboBox4.Items.IndexOf("Fraction Off");
                comboBox5.SelectedIndex = comboBox5.Items.IndexOf("ADC Type On");
                comboBox6.SelectedIndex = comboBox6.Items.IndexOf("C - Celsius => F - Fahrenheit");
                comboBox7.SelectedIndex = comboBox7.Items.IndexOf("Type On");
                comboBox8.SelectedIndex = comboBox8.Items.IndexOf("Fraction On");
                comboBox9.SelectedIndex = comboBox9.Items.IndexOf("Decimal On");
                comboBox10.SelectedIndex = comboBox10.Items.IndexOf("RGB => HEX");
                comboBox11.SelectedIndex = comboBox11.Items.IndexOf("Char => ASCII");
                comboBox12.SelectedIndex = comboBox12.Items.IndexOf("Text => Base64");
                comboBox14.SelectedIndex = comboBox14.Items.IndexOf("FILE => MD5");
                comboBox13.SelectedIndex = comboBox13.Items.IndexOf("CM");
                comboBox17.SelectedIndex = comboBox17.Items.IndexOf("INCH");
                comboBox15.SelectedIndex = comboBox15.Items.IndexOf("Fraction On");
                comboBox16.SelectedIndex = comboBox16.Items.IndexOf("Decimal On");
                comboBox22.SelectedIndex = comboBox22.Items.IndexOf("Day");
                comboBox19.SelectedIndex = comboBox19.Items.IndexOf("Second");
                comboBox21.SelectedIndex = comboBox21.Items.IndexOf("Decimal On");
                comboBox20.SelectedIndex = comboBox20.Items.IndexOf("Fraction Off");
                comboBox18.SelectedIndex = comboBox18.Items.IndexOf("ATC Type On");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}