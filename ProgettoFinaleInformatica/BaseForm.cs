using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica
{
    public partial class BaseForm : Form
    {
        private static PrivateFontCollection fonts = new PrivateFontCollection();
        private static Font appFont;

        static BaseForm()
        {
            fonts.AddFontFile("Fonts/SupermercadoOne-Regular.ttf");

            appFont = new Font(fonts.Families[0], 11f);
        }

        public BaseForm()
        {
            this.Font = appFont;
        }
    }
}