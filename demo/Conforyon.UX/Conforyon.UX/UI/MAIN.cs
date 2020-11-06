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
            try
            {
                InitializeComponent();
                MM = MaterialManager.Instance;
                MM.Theme = MaterialManager.Themes.DARK;
                MM.EnforceBackcolorOnAllComponents = true;
                MM.ColorScheme = new MaterialColorScheme(MaterialPrimary.Grey900, MaterialPrimary.Grey700, MaterialPrimary.Grey500, MaterialAccent.Amber400, MaterialTextShade.WHITE);
            }
            catch
            {
                //
            }
        }

        private new void Click(object sender, EventArgs e)
        {
            try
            {
                HopeButton Button = sender as HopeButton;
                if (AT != Button.Name)
                {
                    AT = Button.Name;
                    VIEW.Controls.Clear();
                    SetControl(AT);
                }
            }
            catch
            {
                //
            }
        }

        private void SetControl(string Control)
        {
            try
            {
                Control CR = null;
                switch (Control)
                {
                    case "Color":
                        CR = new UC.COLOR() { Anchor = AnchorStyles.None };
                        break;
                    case "DataStorage":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Temperature":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Typography":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Speed":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Time":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Clipboard":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Crypto":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Hash":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Unicode":
                        MessageBox.Show(Control + "!");
                        break;
                    default:
                        MessageBox.Show("Unknown!");
                        break;
                }
                CR.Location = new Point(VIEW.Width / 2 - CR.Width / 2, VIEW.Height / 2 - CR.Height / 2);
                VIEW.Controls.Add(CR);
            }
            catch
            {
                //
            }
        }

        private void CENTERED_Tick(object sender, EventArgs e)
        {
            try
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
            catch
            {
                //
            }
        }
    }
}