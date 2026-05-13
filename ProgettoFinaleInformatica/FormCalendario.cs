using ClassLibraryCalendario;
using System.Drawing.Text;
using System.Text.Json;

namespace ProgettoFinaleInformatica {
    public partial class FormCalendario : Form {
        private FormSettimana formAttivo = null;
        private GestoreImpegni gestore;
        private Font font;
        public FormCalendario() {
            InitializeComponent();
            gestore = new GestoreImpegni();
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/SupermercadoOne-Regular.ttf");
            this.font = new Font(fonts.Families[0], 11f);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
            DateTime day = e.Start;
            int differenza = (7 + day.DayOfWeek - DayOfWeek.Monday) % 7;
            day = day.AddDays(-differenza).Date;
            if(formAttivo != null) {
                formAttivo.Close();
            }
            formAttivo = new FormSettimana(day, gestore);
            formAttivo.Show();
        }

        public void SaveData() {
            gestore.SaveData();
        }
    }
}
