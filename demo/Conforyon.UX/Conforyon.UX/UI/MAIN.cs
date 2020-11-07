using System;
using System.Drawing;
using ReaLTaiizor.Util;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Colors;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

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

                //SetControl("Crypto");
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
                VIEW.Controls.Clear();
                Control UC = null;
                switch (Control)
                {
                    case "Color":
                        UC = new UC.COLOR() { Anchor = AnchorStyles.None };
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
                        UC = new UC.CRYPTO() { Anchor = AnchorStyles.None };
                        break;
                    case "Hash":
                        UC = new UC.HASH() { Anchor = AnchorStyles.None };
                        break;
                    case "Unicode":
                        MessageBox.Show(Control + "!");
                        break;
                    default:
                        MessageBox.Show("Unknown!");
                        break;
                }
                UC.Location = new Point(VIEW.Width / 2 - UC.Width / 2, VIEW.Height / 2 - UC.Height / 2);
                VIEW.Controls.Add(UC);
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