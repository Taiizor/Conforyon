using System;
using System.Drawing;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace Conforyon.UX.UC
{
    public partial class COLOR : UserControl
    {
        public COLOR()
        {
            InitializeComponent();
            TACB.SelectedIndex = 0;
            TBCB.SelectedIndex = 0;
        }

        private void TTB_Click(object sender, EventArgs e)
        {
            object A = TACB.SelectedItem;
            object B = TBCB.SelectedItem;
            TACB.SelectedItem = B.ToString();
            TBCB.SelectedItem = A.ToString();
            Refresh();
        }

        private void TCB_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            else
            {
                CRTB.ReadOnly = false;
                CRTB.Location = new Point(3, 48);
                CGTB.ReadOnly = false;
                CGTB.Location = new Point(56, 48);
                CBTB.ReadOnly = false;
                CBTB.Location = new Point(118, 48);
                CHTB.ReadOnly = true;
                CHTB.Location = new Point(217, 48);
            }
        }
    }
}