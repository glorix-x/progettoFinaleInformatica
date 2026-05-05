using ClassLibraryCalendario;
using System.Text.Json;

namespace ProgettoFinaleInformatica {
    public partial class FormCalendario : Form {
        private FormSettimana formAttivo = null;
        private GestoreImpegni gestore;
        public FormCalendario() {
            InitializeComponent();
            gestore = new GestoreImpegni();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
            DateTime day = e.Start;
            int differenza = (7 + day.DayOfWeek - DayOfWeek.Monday) % 7;
            day = day.AddDays(-differenza).Date;
            FormSettimana formSettimana = new FormSettimana(day, gestore.GetListaImpegniSettimana(day));
            if(formAttivo == null) {
                formAttivo = formSettimana;
            } else {
                formAttivo.Close();
                formAttivo = formSettimana;
            }
            formAttivo.Show();
        }
    }
}
