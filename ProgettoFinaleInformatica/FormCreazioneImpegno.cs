using ClassLibraryCalendario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica {
    public partial class FormCreazioneImpegno : Form {
        private static Color[] listaColori = { Color.OrangeRed, Color.LightBlue, Color.LightPink, Color.Yellow, Color.Green};
        private GestoreImpegni gestore;
        private DateTime giorno;
        private FormSettimana form;

        public FormCreazioneImpegno(DateTime giorno, GestoreImpegni gestore, FormSettimana form) {
            InitializeComponent();
            this.gestore = gestore;
            this.giorno = giorno;
            this.form = form;

            int numOreMax = 0;

            Impegno prossimoImpegno = gestore.GetNextImpegno(giorno);
            if(prossimoImpegno != null && prossimoImpegno.DataFissata.Date.CompareTo(giorno.Date) == 0) {
                DateTime oraProssimoImpegno = prossimoImpegno.DataFissata;
                numOreMax = oraProssimoImpegno.Hour - giorno.Hour;
            } else {
                numOreMax = 24 - giorno.Hour;
            }

            List<int> listaOre = new List<int>();

            for(int i = 1; i <= numOreMax; i++) {
                listaOre.Add(i);
            }

            cbColore.DataSource = listaColori;
            cbDurata.DataSource = listaOre;
        }

        private void btnSalva_Click(object sender, EventArgs e) {
            string titolo = txtTitolo.Text;
            string descrizione = rtbDescrizione.Text;
            int durata = Convert.ToInt32(cbDurata.Text);
            Color colore = listaColori[cbColore.SelectedIndex];
            if(titolo.Trim() == "" || descrizione.Trim() == "") {
                MessageBox.Show("Compilare tutti i campi");
            } else {
                Impegno nuovoImpegno = new Impegno(titolo, descrizione, giorno, giorno, durata, true, ColoreHex(colore));
                gestore.AddImpegno(nuovoImpegno);
                form.SetImpegno(nuovoImpegno);
                form.Show();
                this.Close();
            }
        }

        private string ColoreHex(Color colore) {
            return $"#{colore.R:X2}{colore.G:X2}{colore.B:X2}";
        }
    }
}
