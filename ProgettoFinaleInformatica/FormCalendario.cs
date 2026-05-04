namespace ProgettoFinaleInformatica {
    public partial class FormCalendario : Form {
        public FormCalendario() {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
            DateTime day = e.Start;
            int differenza = day.DayOfWeek - DayOfWeek.Monday;
            day = day.AddDays(-differenza).Date;

        }
    }
}
