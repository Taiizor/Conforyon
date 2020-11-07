﻿using System;
using Conforyon;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

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

                if (TA == "BASE64")
                {
                    CRTB.Text = Crypto.BASE64toTEXT(CVTB.Text);
                }
                else
                {
                    if (TB == "BASE64")
                    {
                        CRTB.Text = Crypto.TEXTtoBASE64(CVTB.Text);
                    }
                    else if (TB == "MD5")
                    {
                        CRTB.Text = Crypto.TEXTtoMD5(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA1")
                    {
                        CRTB.Text = Crypto.TEXTtoSHA1(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA256")
                    {
                        CRTB.Text = Crypto.TEXTtoSHA256(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA384")
                    {
                        CRTB.Text = Crypto.TEXTtoSHA384(CVTB.Text, CRC);
                    }
                    else if (TB == "SHA512")
                    {
                        CRTB.Text = Crypto.TEXTtoSHA512(CVTB.Text, CRC);
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
                if (Clipboard.GetText() != CRTB.Text)
                {
                    ClipBoard.CopyText(CRTB.Text);
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
                        TBCB.SelectedItem = "BASE64";
                    }
                    else if (TACB.SelectedItem.ToString() == "BASE64")
                    {
                        TBCB.SelectedItem = "TEXT";
                    }
                }
                else
                {
                    if (TBCB.SelectedItem.ToString() == "BASE64" && TACB.SelectedItem.ToString() == "BASE64")
                    {
                        TACB.SelectedItem = "TEXT";
                    }
                    else if (TBCB.SelectedItem.ToString() == "TEXT")
                    {
                        TACB.SelectedItem = "BASE64";
                    }
                    else
                    {
                        TACB.SelectedItem = "TEXT";
                    }
                }

                Refresh();

                if ((TACB.SelectedItem.ToString() == "TEXT" || TACB.SelectedItem.ToString() == "BASE64") && (TBCB.SelectedItem.ToString() == "TEXT" || TBCB.SelectedItem.ToString() == "BASE64"))
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