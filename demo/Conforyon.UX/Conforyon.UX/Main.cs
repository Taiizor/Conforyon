using System;
using ReaLTaiizor.Util;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace Conforyon.UX
{
    public partial class Main : LostForm
    {
        private readonly MaterialManager MM;

        public Main()
        {
            InitializeComponent();
            MM = MaterialManager.Instance;
            MM.EnforceBackcolorOnAllComponents = true;
            MM.Theme = MaterialManager.Themes.DARK;
            MM.ColorScheme = new MaterialColorScheme(MaterialPrimary.Grey900, MaterialPrimary.Grey700, MaterialPrimary.Grey500, MaterialAccent.Amber400, MaterialTextShade.WHITE);
        }

        private new void Click(object sender, EventArgs e)
        {
            HopeButton Button = sender as HopeButton;
            switch (Button.Name)
            {
                case "Color":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "DataStorage":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Temperature":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Typography":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Speed":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Time":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Clipboard":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Crypto":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Hash":
                    MessageBox.Show(Button.Name + "!");
                    break;
                case "Unicode":
                    MessageBox.Show(Button.Name + "!");
                    break;
                default:
                    MessageBox.Show("Unknown!");
                    break;
            }
        }
    }
}