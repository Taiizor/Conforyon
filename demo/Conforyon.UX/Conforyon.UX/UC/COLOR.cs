using Conforyon.Board;
using Conforyon.Color;
using Conforyon.Enum;
using ReaLTaiizor.Controls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Conforyon.UX.UC
{
    public partial class COLOR : UserControl
    {
        public COLOR()
        {
            try
            {
                InitializeComponent();
                TACB.SelectedIndex = 0;
                TBCB.SelectedIndex = 0;
                Height = 194;
            }
            catch
            {
                //
            }
        }

        private void TTB_Click(object sender, EventArgs e)
        {
            try
            {
                string TA = TACB.SelectedItem.ToString();
                string TB = TBCB.SelectedItem.ToString();
                TACB.SelectedItem = TB;
                TBCB.SelectedItem = TA;
                Refresh();
            }
            catch
            {
                //
            }
        }

        private void CTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (TACB.SelectedItem.ToString() == "RGB")
                {
                    CHTB.Text = Colorful.RGBtoHEX(Convert.ToInt32(CRTB.Text), Convert.ToInt32(CGTB.Text), Convert.ToInt32(CBTB.Text));
                }
                else
                {
                    CRTB.Text = Colorful.HEXtoRGB(CHTB.Text, Enums.ColorType.OnlyR);
                    CGTB.Text = Colorful.HEXtoRGB(CHTB.Text, Enums.ColorType.OnlyG);
                    CBTB.Text = Colorful.HEXtoRGB(CHTB.Text, Enums.ColorType.OnlyB);
                }
            }
            catch
            {
                //
            }
        }

        private void CYB_Click(object sender, EventArgs e)
        {
            try
            {
                if (TACB.SelectedItem.ToString() == "RGB")
                {
                    if (ClipBoard.GetText() != CHTB.Text)
                    {
                        ClipBoard.CopyText(CHTB.Text);
                        CHTB.Focus();
                    }
                }
                else
                {
                    if (ClipBoard.GetText() != CRTB.Text + ", " + CGTB.Text + ", " + CBTB.Text)
                    {
                        ClipBoard.CopyText(CRTB.Text + ", " + CGTB.Text + ", " + CBTB.Text);
                        CGTB.Focus();
                    }
                }
            }
            catch
            {
                //
            }
        }

        private void TCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MaterialComboBox TCB = sender as MaterialComboBox;
                if (TCB.Name == "TACB")
                {
                    TBCB.SelectedIndex = TACB.SelectedIndex;
                }
                else
                {
                    TACB.SelectedIndex = TBCB.SelectedIndex;
                }

                Refresh();

                if (TACB.SelectedItem.ToString() == "HEX")
                {
                    CRTB.ReadOnly = true;
                    CRTB.Location = new Point(123, 48);
                    CGTB.ReadOnly = true;
                    CGTB.Location = new Point(185, 48);
                    CBTB.ReadOnly = true;
                    CBTB.Location = new Point(247, 48);
                    CHTB.ReadOnly = false;
                    CHTB.Location = new Point(3, 48);
                    CTB.Location = new Point(3, 107);
                    CYB.Location = new Point(191, 107);
                }
                else
                {
                    CRTB.ReadOnly = false;
                    CRTB.Location = new Point(3, 48);
                    CGTB.ReadOnly = false;
                    CGTB.Location = new Point(65, 48);
                    CBTB.ReadOnly = false;
                    CBTB.Location = new Point(127, 48);
                    CHTB.ReadOnly = true;
                    CHTB.Location = new Point(217, 48);
                    CTB.Location = new Point(35, 107);
                    CYB.Location = new Point(238, 107);
                }
            }
            catch
            {
                //
            }
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch
            {
                //
            }
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaterialTextBox CTB = sender as MaterialTextBox;
                if (Regex.IsMatch(CTB.Text, "[^0-9]"))
                {
                    CTB.Text = CTB.Text.Remove(CTB.Text.Length - 1);
                    TB_TextChanged(sender, e);
                }
                else if (Convert.ToInt32(CTB.Text) > 255)
                {
                    CTB.Text = "255";
                }
                else if (Convert.ToInt32(CTB.Text) < 0)
                {
                    CTB.Text = "0";
                }
            }
            catch
            {
                //
            }
        }

        private void CSS_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CSS.Checked)
                {
                    Height = 240;
                }
                else
                {
                    Height = 194;
                }
            }
            catch
            {
                //
            }
        }
    }
}