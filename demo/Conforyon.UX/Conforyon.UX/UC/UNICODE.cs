using System;
using Conforyon.Board;
using Conforyon.Unicode;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using System.Text.RegularExpressions;

namespace Conforyon.UX.UC
{
    public partial class UNICODE : UserControl
    {
        public UNICODE()
        {
            try
            {
                InitializeComponent();
                TACB.SelectedIndex = 0;
                TBCB.SelectedIndex = 0;
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

                string UV = URTB.Text;
                string UR = UVTB.Text;

                URTB.Text = UR;
                UVTB.Text = UV;

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
                char BT = string.IsNullOrEmpty(BTTB.Text) ? ',' : BTTB.Text.ToCharArray()[0];
                BTTB.Text = BT.ToString();

                if (TACB.SelectedItem.ToString() == "CHAR")
                {
                    URTB.Text = Unicodes.CHARtoASCII(UVTB.Text, BT);
                }
                else
                {
                    URTB.Text = Unicodes.ASCIItoCHAR(UVTB.Text, BT);
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
                if (ClipBoard.GetText() != URTB.Text)
                {
                    ClipBoard.CopyText(URTB.Text);
                    URTB.Focus();
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