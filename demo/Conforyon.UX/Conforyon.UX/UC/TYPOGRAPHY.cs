using Conforyon.Board;
using Conforyon.Enum;
using Conforyon.Typology;
using Conforyon.Value;
using ReaLTaiizor.Controls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Conforyon.UX.UC
{
    public partial class TYPOGRAPHY : UserControl
    {
        private bool DL = true;
        private bool CA = true;

        public TYPOGRAPHY()
        {
            try
            {
                InitializeComponent();
                TACB.SelectedIndex = 0;
                TBCB.SelectedIndex = 1;
                TDCB.SelectedIndex = 0;
                TCCB.SelectedIndex = 0;
                Height = 244;
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

                CFTB.Hint = "Core Formula [" + TB + " - " + TA + "]";
                CFTB.Text = Values.GetValue(Enums.MethodType.Typography, TB, TA);

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
                string TA = TACB.SelectedItem.ToString();
                string TB = TBCB.SelectedItem.ToString();
                int PC = string.IsNullOrEmpty(BTTB.Text) ? 2 : Convert.ToInt32(BTTB.Text);
                BTTB.Text = PC.ToString();

                if (TA == "INCH")
                {
                    if (TB == "CM")
                    {
                        TRTB.Text = INCH.CM(TVTB.Text, DL, CA, PC);
                    }
                    else if (TB == "PX")
                    {
                        TRTB.Text = INCH.PX(TVTB.Text, DL, CA, PC);
                    }
                }
                else if (TA == "CM")
                {
                    if (TB == "INCH")
                    {
                        TRTB.Text = CM.INCH(TVTB.Text, DL, CA, PC);
                    }
                    else if (TB == "PX")
                    {
                        TRTB.Text = CM.PX(TVTB.Text, DL, CA, PC);
                    }
                }
                else if (TA == "PX")
                {
                    if (TB == "INCH")
                    {
                        TRTB.Text = PX.INCH(TVTB.Text, DL, CA, PC);
                    }
                    else if (TB == "CM")
                    {
                        TRTB.Text = PX.CM(TVTB.Text, DL, CA, PC);
                    }
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
                if (Board.Text.Paste() != TRTB.Text)
                {
                    Board.Text.Copy(TRTB.Text);
                    TRTB.Focus();
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
                    if (TCB.SelectedItem.ToString() == TBCB.SelectedItem.ToString())
                    {
                        if (TCB.SelectedItem.ToString() == "INCH")
                        {
                            TBCB.SelectedItem = "CM";
                        }
                        else if (TCB.SelectedItem.ToString() == "CM")
                        {
                            TBCB.SelectedItem = "PX";
                        }
                        else if (TCB.SelectedItem.ToString() == "PX")
                        {
                            TBCB.SelectedItem = "INCH";
                        }
                    }
                }
                else
                {
                    if (TCB.SelectedItem.ToString() == TACB.SelectedItem.ToString())
                    {
                        if (TCB.SelectedItem.ToString() == "INCH")
                        {
                            TACB.SelectedItem = "PX";
                        }
                        else if (TCB.SelectedItem.ToString() == "CM")
                        {
                            TACB.SelectedItem = "INCH";
                        }
                        else if (TCB.SelectedItem.ToString() == "PX")
                        {
                            TACB.SelectedItem = "CM";
                        }
                    }
                }

                Refresh();

                CFTB.Hint = "Core Formula [" + TACB.SelectedItem.ToString() + " - " + TBCB.SelectedItem.ToString() + "]";
                CFTB.Text = Values.GetValue(Enums.MethodType.Typography, TACB.SelectedItem.ToString(), TBCB.SelectedItem.ToString());
            }
            catch
            {
                //
            }
        }

        private void TDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TDCB.SelectedItem.ToString() == "On")
                {
                    DL = true;
                }
                else
                {
                    DL = false;
                }
            }
            catch
            {
                //
            }
        }

        private void TCCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TCCB.SelectedItem.ToString() == "On")
                {
                    CA = true;
                    BTTB.Visible = CA;
                    CTB.Location = new Point(95, CTB.Location.Y);
                }
                else
                {
                    CA = false;
                    BTTB.Visible = CA;
                    CTB.Location = new Point(3, CTB.Location.Y);
                }
            }
            catch
            {
                //
            }
        }

        private void TVTB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TVTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(TVTB.Text, "[^0-9]"))
                {
                    TVTB.Text = TVTB.Text.Remove(TVTB.Text.Length - 1);
                    TVTB_TextChanged(sender, e);
                }
            }
            catch
            {
                //
            }
        }

        private void BTTB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BTTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(BTTB.Text, "[^0-9]"))
                {
                    BTTB.Text = BTTB.Text.Remove(BTTB.Text.Length - 1);
                    BTTB_TextChanged(sender, e);
                }
                else if (Convert.ToInt32(BTTB.Text) > 99)
                {
                    BTTB.Text = "99";
                }
                else if (Convert.ToInt32(BTTB.Text) < 0)
                {
                    BTTB.Text = "0";
                }
            }
            catch
            {
                //
            }
        }

        private void CFTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Values.GetValue(Enums.MethodType.Typography, TACB.SelectedItem.ToString(), TBCB.SelectedItem.ToString()) != CFTB.Text.Replace(".", ","))
                {
                    Values.SetValue(Enums.MethodType.Typography, TACB.SelectedItem.ToString(), TBCB.SelectedItem.ToString(), CFTB.Text.Replace(".", ","));
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
                    Height = 333;
                }
                else
                {
                    Height = 244;
                }
            }
            catch
            {
                //
            }
        }
    }
}