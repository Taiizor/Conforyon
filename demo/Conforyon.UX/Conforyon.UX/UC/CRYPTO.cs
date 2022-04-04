using Conforyon.Cryptology;
using ReaLTaiizor.Controls;
using System;
using System.Windows.Forms;
using TextCopy;

namespace Conforyon.UX.UC
{
    public partial class CRYPTO : UserControl
    {
        private bool CRC = false;

        public CRYPTO()
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

                string CV = CRTB.Text;
                string CR = CVTB.Text;

                CRTB.Text = CR;
                CVTB.Text = CV;

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

                if (TA == "BASE")
                {
                    CRTB.Text = BASE.TEXT(CVTB.Text);
                }
                else
                {
                    if (TB == "BASE")
                    {
                        CRTB.Text = TEXT.BASE(CVTB.Text);
                    }
                    else if (TB == "MD5")
                    {
                        CRTB.Text = TEXT.MD5(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA1")
                    {
                        CRTB.Text = TEXT.SHA1(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA256")
                    {
                        CRTB.Text = TEXT.SHA256(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA384")
                    {
                        CRTB.Text = TEXT.SHA384(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA512")
                    {
                        CRTB.Text = TEXT.SHA512(CVTB.Text, CRC);
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
                if (ClipboardService.GetText() != CRTB.Text)
                {
                    ClipboardService.SetText(CRTB.Text);
                    CRTB.Focus();
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
                    if (TACB.SelectedItem.ToString() == "TEXT" && TBCB.SelectedItem.ToString() == "TEXT")
                    {
                        TBCB.SelectedItem = "BASE";
                    }
                    else if (TACB.SelectedItem.ToString() == "BASE")
                    {
                        TBCB.SelectedItem = "TEXT";
                    }
                }
                else
                {
                    if (TBCB.SelectedItem.ToString() == "BASE" && TACB.SelectedItem.ToString() == "BASE")
                    {
                        TACB.SelectedItem = "TEXT";
                    }
                    else if (TBCB.SelectedItem.ToString() == "TEXT")
                    {
                        TACB.SelectedItem = "BASE";
                    }
                    else
                    {
                        TACB.SelectedItem = "TEXT";
                    }
                }

                Refresh();

                if ((TACB.SelectedItem.ToString() == "TEXT" || TACB.SelectedItem.ToString() == "BASE") && (TBCB.SelectedItem.ToString() == "TEXT" || TBCB.SelectedItem.ToString() == "BASE"))
                {
                    TTB.Enabled = true;
                    CRCB.Enabled = false;
                }
                else
                {
                    TTB.Enabled = false;
                    CRCB.Enabled = true;
                }
            }
            catch
            {
                //
            }
        }

        private void FRCB_Click(object sender, EventArgs e)
        {
            try
            {
                CRC = !CRC;
                if (CRC)
                {
                    CRCB.Icon = Properties.Resources.Uppercase;
                    CRTB.Text = CRTB.Text.ToUpperInvariant();
                }
                else
                {
                    CRCB.Icon = Properties.Resources.Lowercase;
                    CRTB.Text = CRTB.Text.ToLowerInvariant();
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