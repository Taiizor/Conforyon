using ReaLTaiizor.Controls;
using System;
using System.Windows.Forms;

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
                CGTB.ReadOnly = true;
                CBTB.ReadOnly = true;
            }
            else
            {
                CRTB.ReadOnly = false;
                CGTB.ReadOnly = false;
                CBTB.ReadOnly = false;
            }
        }
    }
}