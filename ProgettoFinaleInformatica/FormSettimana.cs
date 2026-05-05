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
        private List<Impegno> impegniAggiunti = new List<Impegno>();
        private FormCreazioneImpegno formAttivo = null;
        public FormSettimana(DateTime start, List<Impegno> listaImpegni) {
            this.start = start;
            InitializeComponent();
            for(int i = 0; i <= 24; i++) {
                Label lbl = new Label();
                lbl.Location = new Point(grigliaSettimana.Location.X - 70, grigliaSettimana.Location.Y - 12 + i * grigliaSettimana.Height / 24);
                lbl.Text = (i.ToString().Length == 1 ? "0" : "") + i.ToString() + ":00";
                Controls.Add(lbl);
            }
            for(int i = 0; i < 24; i++) {
                for(int j = 0; j < 7; j++) {
                    Button btn = new Button();
                    btn.Tag = new int[] { j, i };
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
            
            foreach(Impegno impegno in listaImpegni) {
                DateTime data = impegno.DataFissata;
                Button btn = (Button)grigliaSettimana.Controls.Find(((int)data.DayOfWeek - 1).ToString() + " " + data.Hour, true)[0];
                for(int i = 1; i < impegno.DurataOre; i++) {
                    grigliaSettimana.Controls.Remove((Button)grigliaSettimana.Controls.Find(((int)data.DayOfWeek - 1).ToString() + " " + (data.Hour + i), true)[0]);
                }
                grigliaSettimana.SetRowSpan(btn, impegno.DurataOre);
            }
        }

        public void AggiungiImpegno(object sender, EventArgs e) {
            Button btn = (Button)sender;
            int[] coordinate = (int[])btn.Tag;
            int numGiorno = coordinate[0];
            int numOra = coordinate[1];

            FormCreazioneImpegno form = new FormCreazioneImpegno();

            if(formAttivo == null) {
                formAttivo = form;
            } else {
                formAttivo.Close();
                formAttivo = form;
            }
            formAttivo.Show();
        }
    }
}
