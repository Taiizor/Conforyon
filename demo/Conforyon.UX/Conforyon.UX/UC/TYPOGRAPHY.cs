using System;
using Conforyon;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using System.Text.RegularExpressions;

namespace Conforyon.UX.UC
{
    public partial class TYPOGRAPHY : UserControl
    {
        private bool DL = true;
        private bool CA = true;
        private int PC = 2;

        public TYPOGRAPHY()
        {
            try
            {
                InitializeComponent();
                TACB.SelectedIndex = 0;
                TBCB.SelectedIndex = 1;
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

                if (TA == "INCH")
                {
                    if (TB == "CM")
                    {
                        TRTB.Text = Typography.INCHtoCM(TVTB.Text, DL, CA, PC);
                    }
                    else if (TB == "PX")
                    {
                        TRTB.Text = Typography.INCHtoPX(TVTB.Text, DL, CA, PC);
                    }
                }
                else if (TA == "CM")
                {
                    if (TB == "INCH")
                    {
                        TRTB.Text = Typography.CMtoINCH(TVTB.Text, DL, CA, PC);
                    }
                    else if (TB == "PX")
                    {
                        TRTB.Text = Typography.CMtoPX(TVTB.Text, DL, CA, PC);
                    }
                }
                else if (TA == "PX")
                {
                    if (TB == "INCH")
                    {
                        TRTB.Text = Typography.PXtoINCH(TVTB.Text, DL, CA, PC);
                    }
                    else if (TB == "CM")
                    {
                        TRTB.Text = Typography.PXtoCM(TVTB.Text, DL, CA, PC);
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
                if (Clipboard.GetText() != TRTB.Text)
                {
                    ClipBoard.CopyText(TRTB.Text);
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
                e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
                if (!Regex.IsMatch(BTTB.Text, "[^0-9]"))
                {
                    BTTB.Text = BTTB.Text.Remove(BTTB.Text.Length - 1);
                    BTTB_TextChanged(sender, e);
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
                    Height = 296;
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