using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Conforyon.UX.UI
{
    public partial class MAIN : LostForm
    {
        private readonly MaterialSkinManager MM;
        private string AT;

        public MAIN()
        {
            try
            {
                InitializeComponent();
                MM = MaterialSkinManager.Instance;
                MM.Theme = MaterialSkinManager.Themes.DARK;
                MM.EnforceBackcolorOnAllComponents = true;
                MM.ColorScheme = new MaterialColorScheme(MaterialPrimary.Grey900, MaterialPrimary.Grey700, MaterialPrimary.Grey500, MaterialAccent.Amber400, MaterialTextShade.WHITE);

                //SetControl("Typography");
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
                        UC = new UC.TYPOGRAPHY() { Anchor = AnchorStyles.None };
                        break;
                    case "Speed":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Time":
                        MessageBox.Show(Control + "!");
                        break;
                    case "Clipboard":
                        UC = new UC.CLIPBOARD() { Anchor = AnchorStyles.None };
                        break;
                    case "Crypto":
                        UC = new UC.CRYPTO() { Anchor = AnchorStyles.None };
                        break;
                    case "Hash":
                        UC = new UC.HASH() { Anchor = AnchorStyles.None };
                        break;
                    case "Unicode":
                        UC = new UC.UNICODE() { Anchor = AnchorStyles.None };
                        break;
                    default:
                        MessageBox.Show("Unknown!");
                        break;
                }
                UC.Location = new Point(VIEW.Width / 2 - UC.Width / 2, VIEW.Height / 2 - UC.Height / 2);
                VIEW.Controls.Add(UC);
                SetButton();
            }
            catch
            {
                //
            }
        }

        private void SetButton()
        {
            try
            {
                foreach (System.Windows.Forms.TabPage Controls in UOTC.TabPages)
                {
                    SetButton(Controls);
                }

                Refresh();
            }
            catch
            {
                //
            }
        }

        private void SetButton(System.Windows.Forms.TabPage Page)
        {
            try
            {
                foreach (object Controls in Page.Controls)
                {
                    if (Controls.GetType().ToString() == "ReaLTaiizor.Controls.HopeButton")
                    {
                        HopeButton Control = Controls as HopeButton;
                        if (Control.Name == AT)
                        {
                            Control.PrimaryColor = System.Drawing.Color.FromArgb(35, 35, 38);
                        }
                        else
                        {
                            Control.PrimaryColor = System.Drawing.Color.FromArgb(45, 45, 48);
                        }
                    }
                }
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