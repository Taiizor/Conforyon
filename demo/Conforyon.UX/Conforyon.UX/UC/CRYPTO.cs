using System;
using Conforyon;
using System.Windows.Forms;

namespace Conforyon.UX.UC
{
    public partial class CRYPTO : UserControl
    {
        private bool HRC = false;

        public CRYPTO()
        {
            try
            {
                InitializeComponent();
                TACB.SelectedIndex = 0;
                TBCB.SelectedIndex = 0;
                Height = 244;
                //ilk combo'dan Text seçilirse ikinciden kaldır
                //ilk combo'dan Base64 seçilirse ikinciden kaldır
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
                if (TBCB.SelectedItem.ToString() == "MD5")
                {
                    FRTB.Text = Hash.FILEtoMD5(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA1")
                {
                    FRTB.Text = Hash.FILEtoSHA1(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA256")
                {
                    FRTB.Text = Hash.FILEtoSHA256(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA384")
                {
                    FRTB.Text = Hash.FILEtoSHA384(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA512")
                {
                    FRTB.Text = Hash.FILEtoSHA512(FLTB.Text, HRC);
                }
            }
            catch
            {
                //
            }
        }

        private void OFLB_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog
                {
                    RestoreDirectory = true,
                    CheckFileExists = true
                };

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    FLTB.Text = OFD.FileName;
                    FLTB.Focus();
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
                HRC = !HRC;
                if (HRC)
                {
                    FRCB.Icon = Properties.Resources.Uppercase;
                    FRTB.Text = FRTB.Text.ToUpperInvariant();
                }
                else
                {
                    FRCB.Icon = Properties.Resources.Lowercase;
                    FRTB.Text = FRTB.Text.ToLowerInvariant();
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
                if (Clipboard.GetText() != FRTB.Text)
                {
                    ClipBoard.CopyText(FRTB.Text);
                    FRTB.Focus();
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