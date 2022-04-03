using Conforyon.Board;
using System;
using System.Windows.Forms;

namespace Conforyon.UX.UC
{
    public partial class CLIPBOARD : UserControl
    {
        public CLIPBOARD()
        {
            try
            {
                InitializeComponent();
                Height = 150;
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
                if (Board.Text.Paste() != CVTB.Text)
                {
                    Board.Text.Copy(CVTB.Text);
                    CVTB.Focus();
                }
            }
            catch
            {
                //
            }
        }

        private void PEB_Click(object sender, EventArgs e)
        {
            try
            {
                if (Board.Text.Paste() != CRTB.Text)
                {
                    CRTB.Text = Board.Text.Paste();
                    CRTB.Focus();
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
                    Height = 203;
                }
                else
                {
                    Height = 150;
                }
            }
            catch
            {
                //
            }
        }
    }
}