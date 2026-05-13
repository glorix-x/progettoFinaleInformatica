using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica
{
    public partial class FormHome : Form
    {
        private Font font;
        public FormHome()
        {
            InitializeComponent();
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/SupermercadoOne-Regular.ttf");
            this.font = new Font(fonts.Families[0], 11f);
        }
    }
}
