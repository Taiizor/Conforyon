using System;
using System.Drawing;
using ReaLTaiizor.Util;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace Conforyon.UX.UI
{
    public partial class MAIN : LostForm
    {
        private readonly MaterialManager MM;
        private string AT;

        public MAIN()
        {
            InitializeComponent();
            MM = MaterialManager.Instance;
            MM.EnforceBackcolorOnAllComponents = true;
            MM.Theme = MaterialManager.Themes.DARK;
            MM.ColorScheme = new MaterialColorScheme(MaterialPrimary.Grey900, MaterialPrimary.Grey700, MaterialPrimary.Grey500, MaterialAccent.Amber400, MaterialTextShade.WHITE);

            UC.COLOR CR = new UC.COLOR() { Anchor = AnchorStyles.None };
            AT = "Color";
            CR.Location = new Point(VIEW.Width / 2 - CR.Width / 2, VIEW.Height / 2 - CR.Height / 2);
            VIEW.Controls.Clear();
            VIEW.Controls.Add(CR);
        }

        private new void Click(object sender, EventArgs e)
        {
            HopeButton Button = sender as HopeButton;
            if (AT != Button.Name)
            {
                AT = Button.Name;
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

        private void CENTERED_Tick(object sender, EventArgs e)
        {
            foreach (object Controls in VIEW.Controls)
            {
                if (Controls.GetType().ToString().Contains(".UX.UC."))
                {
                    UserControl Control = Controls as UserControl;
                    if (Control.Location.X != VIEW.Width / 2 - Control.Width / 2 || Control.Location.Y != VIEW.Height / 2 - Control.Height / 2)
                    {
                        Control.Location = new Point(VIEW.Width / 2 - Control.Width / 2, VIEW.Height / 2 - Control.Height / 2);
                    }
                }
            }
        }
    }
}