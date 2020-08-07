using System;
using Conforyon;
using System.Windows.Forms;

namespace Conforyon_CR
{
    public partial class Catcher : Form
    {
        public Catcher()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataStorage.AutoDataConvert(textBox1.Text, Conforyon.Conforyon.StorageType.PB, true, true, true, 2, "Hata!"));
            MessageBox.Show(DataStorage.DataConvert(textBox1.Text, Conforyon.Conforyon.StorageType.PB, Conforyon.Conforyon.StorageType.EB, true, true, 2, "Hata!"));
        }
    }
}