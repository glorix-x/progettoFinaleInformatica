using ClassLibraryCalendario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica {
    public partial class FormSettimana : Form {
        private static string[] daysName = { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica" };
        private DateTime start;
        private FormCreazioneImpegno formCreazioneAttivo = null;
        private FormModificaImpegno formModificaAttivo = null;
        private GestoreImpegni gestore;

        public FormSettimana(DateTime start, GestoreImpegni gestore) {
            InitializeComponent();
            this.start = start;
            this.gestore = gestore;

            for(int i = 0; i <= 24; i++) {
                Label lbl = new Label();
                lbl.Location = new Point(grigliaSettimana.Location.X - 70, grigliaSettimana.Location.Y - 12 + i * grigliaSettimana.Height / 24);
                lbl.Text = (i.ToString().Length == 1 ? "0" : "") + i.ToString() + ":00";
                Controls.Add(lbl);
            }
            for(int i = 0; i < 24; i++) {
                for(int j = 0; j < 7; j++) {
                    Button btn = new Button();
                    btn.Tag = null;
                    btn.Name = j.ToString() + " " + i.ToString();
                    btn.Click += AggiungiImpegno;
                    grigliaSettimana.Controls.Add(btn);
                    btn.Dock = DockStyle.Fill;
                }
            }
            DateTime day = start;
            lblLunedi.Text = "Lun " + (day.Day.ToString().Length == 1 ? "0" : "") + day.Day + "/" + (day.Month.ToString().Length == 1 ? "0" : "") + day.Month;
            day = day.AddDays(1);
            lblMartedi.Text = "Mar " + (day.Day.ToString().Length == 1 ? "0" : "") + day.Day + "/" + (day.Month.ToString().Length == 1 ? "0" : "") + day.Month;
            day = day.AddDays(1);
            lblMercoledi.Text = "Mer " + (day.Day.ToString().Length == 1 ? "0" : "") + day.Day + "/" + (day.Month.ToString().Length == 1 ? "0" : "") + day.Month;
            day = day.AddDays(1);
            lblGiovedi.Text = "Gio " + (day.Day.ToString().Length == 1 ? "0" : "") + day.Day + "/" + (day.Month.ToString().Length == 1 ? "0" : "") + day.Month;
            day = day.AddDays(1);
            lblVenerdi.Text = "Ven " + (day.Day.ToString().Length == 1 ? "0" : "") + day.Day + "/" + (day.Month.ToString().Length == 1 ? "0" : "") + day.Month;
            day = day.AddDays(1);
            lblSabato.Text = "Sab " + (day.Day.ToString().Length == 1 ? "0" : "") + day.Day + "/" + (day.Month.ToString().Length == 1 ? "0" : "") + day.Month;
            day = day.AddDays(1);
            lblDomenica.Text = "Dom " + (day.Day.ToString().Length == 1 ? "0" : "") + day.Day + "/" + (day.Month.ToString().Length == 1 ? "0" : "") + day.Month;

            List<Impegno> listaImpegni = gestore.GetListaImpegniSettimana(start);

            foreach(Impegno impegno in listaImpegni) {
                SetImpegno(impegno);
            }
        }

        public void SetImpegno(Impegno impegno) {
            this.Hide();
            DateTime data = impegno.DataFissata;
            Button btn = (Button)grigliaSettimana.Controls.Find(((int)data.DayOfWeek - 1).ToString() + " " + data.Hour, true)[0];
            for(int i = 1; i < impegno.DurataOre; i++) {
                grigliaSettimana.Controls.Remove((Button)grigliaSettimana.Controls.Find(((int)data.DayOfWeek - 1).ToString() + " " + (data.Hour + i), true)[0]);
            }
            grigliaSettimana.SetRowSpan(btn, impegno.DurataOre);
            btn.Tag = impegno;
            btn.Click -= AggiungiImpegno;
            btn.Click += ModificaImpegno;
        }

        public void AggiungiImpegno(object sender, EventArgs e) {
            Button btn = (Button)sender;

            string giorno = "";
            string ora = "";
            int numGiorno = 0;
            int numOra = 0;
            bool isOra = false;
            
            foreach(char c in btn.Name) {
                if(c == ' ') {
                    isOra = true;
                    continue;
                }
                if(isOra) {
                    ora += c;
                } else {
                    giorno += c;
                }
            }

            numGiorno = Convert.ToInt32(giorno);
            numOra = Convert.ToInt32(ora);

            DateTime giornoOra = new DateTime(start.Year, start.Month, start.AddDays(numGiorno).Day, numOra, 0, 0);
            FormCreazioneImpegno form = new FormCreazioneImpegno(giornoOra, gestore, this);

            if(formCreazioneAttivo == null) {
                formCreazioneAttivo = form;
            } else {
                formCreazioneAttivo.Close();
                formCreazioneAttivo = form;
            }
            formCreazioneAttivo.Show();
        }

        public void ModificaImpegno(object sender, EventArgs e) {
            Button btn = (Button)sender;
            Impegno impegno = (Impegno)btn.Tag;

            FormModificaImpegno form = new FormModificaImpegno(impegno);

            if(formModificaAttivo == null) {
                formModificaAttivo = form;
            } else {
                formModificaAttivo.Close();
                formModificaAttivo = form;
            }
            formModificaAttivo.Show();
        }
    }
}
