using ReaLTaiizor.Forms;
using ReaLTaiizor.Utils;
using ReaLTaiizor.Colors;

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
    }
}