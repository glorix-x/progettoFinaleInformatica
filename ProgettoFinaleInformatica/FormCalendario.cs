using ClassLibraryCalendario;
using System.Text.Json;

namespace ProgettoFinaleInformatica {
    public partial class FormCalendario : BaseForm {
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
