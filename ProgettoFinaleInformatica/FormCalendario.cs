using ClassLibraryCalendario;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Text.Json;

namespace ProgettoFinaleInformatica {
    public partial class FormCalendario : Form
    {
        private FormSettimana formAttivo = null;
        private GestoreImpegni gestore;
        private Font font;
        public FormCalendario()
        {
            InitializeComponent();
            gestore = new GestoreImpegni();
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/SupermercadoOne-Regular.ttf");
            this.font = new Font(fonts.Families[0], 11f);
            lblScegliSettimana.Font = new Font(font.FontFamily, 30);
        }
        private void FormCalendario_Load(object sender, EventArgs e)
        {
            lblScegliSettimana.AutoSize = false;
            lblScegliSettimana.Width = this.ClientSize.Width - 20;
            lblScegliSettimana.Height = 100;
            lblScegliSettimana.Top = 15;
            lblScegliSettimana.Left = 10;
            lblScegliSettimana.TextAlign = ContentAlignment.MiddleCenter;
            btnOttimizzazione.Left = (this.ClientSize.Width - btnOttimizzazione.Width) / 2;
            this.BackColor = Color.LightGreen;
            linkLabel1.BackColor = Color.Plum;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime day = e.Start;
            day = gestore.GetLunedi(day);
            ShowWeek(day);
        }

        public void ShowWeek(DateTime day)
        {
            if (formAttivo != null)
            {
                formAttivo.Close();
            }
            formAttivo = new FormSettimana(day, gestore, this);
            formAttivo.Show();
        }

        public void SaveData()
        {
            gestore.SaveData();
        }

        private void btnOttimizzazione_Click(object sender, EventArgs e)
        {
            FormOttimizzazione f = new FormOttimizzazione(gestore, this);
            f.Show();
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string url = "https://gofund.me/4b361fdd5";

            // Imposta lo stato del link su "visitato" per cambiare colore
            linkLabel1.LinkVisited = true;

            // Avvia il browser predefinito
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
