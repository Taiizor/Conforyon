﻿using Conforyon.Hash;
using System;
using System.Windows.Forms;
using TextCopy;

namespace Conforyon.UX.UC
{
    public partial class HASH : UserControl
    {
        private bool HRC = false;

        public HASH()
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

        private void CTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBCB.SelectedItem.ToString() == "MD5")
                {
                    FRTB.Text = FILE.MD5(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA1")
                {
                    FRTB.Text = FILE.SHA1(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA256")
                {
                    FRTB.Text = FILE.SHA256(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA384")
                {
                    FRTB.Text = FILE.SHA384(FLTB.Text, HRC);
                }
                else if (TBCB.SelectedItem.ToString() == "SHA512")
                {
                    FRTB.Text = FILE.SHA512(FLTB.Text, HRC);
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
                OpenFileDialog OFD = new()
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
                if (ClipboardService.GetText() != FRTB.Text)
                {
                    ClipboardService.SetText(FRTB.Text);
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