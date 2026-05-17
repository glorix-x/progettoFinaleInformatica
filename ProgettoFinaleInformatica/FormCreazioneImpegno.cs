using ClassLibraryCalendario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica {
    public partial class FormCreazioneImpegno : Form {
        public static Color[] listaColori = { Color.OrangeRed, Color.LightBlue, Color.LightPink, Color.Yellow, Color.Green};
        private GestoreImpegni gestore;
        private DateTime giorno;
        private FormSettimana form;
        private Font font;

        public FormCreazioneImpegno(DateTime giorno, GestoreImpegni gestore, FormSettimana form)
        {
            InitializeComponent();
            this.gestore = gestore;
            this.giorno = giorno;
            this.form = form;

            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Fonts/SupermercadoOne-Regular.ttf");
            this.font = new Font(fonts.Families[0], 11f);

            int numOreMax = 0;

            //Preso il prossimo impegno determino il numero di ore massime che può durare l'impegno da creare
            Impegno prossimoImpegno = gestore.GetNextImpegno(giorno);
            if (prossimoImpegno != null && prossimoImpegno.DataFissata.Date.CompareTo(giorno.Date) == 0)
            {
                //Se il prossimo impegno è nello stesso giorno conto la differenza di ore
                DateTime oraProssimoImpegno = prossimoImpegno.DataFissata;
                numOreMax = oraProssimoImpegno.Hour - giorno.Hour;
            }
            else
            {
                //Altrimenti conto le ore fino alla fine della giornata
                numOreMax = 24 - giorno.Hour;
            }

            List<int> listaOre = new List<int>();

            for (int i = 1; i <= numOreMax; i++)
            {
                listaOre.Add(i);
            }

            cbColore.DataSource = listaColori;
            cbDurata.DataSource = listaOre;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string titolo = txtTitolo.Text;
            string descrizione = rtbDescrizione.Text;
            int durata = Convert.ToInt32(cbDurata.Text);
            Color colore = listaColori[cbColore.SelectedIndex];

            //Controllo che siano stati compilati tutti i campi
            if (titolo.Trim() == "" || descrizione.Trim() == "")
            {
                MessageBox.Show("Compilare tutti i campi");
            }
            else
            {
                bool errore = false;
                int ripetereOgni = 0;
                if(cbRipetere.Checked) {
                    try {
                        ripetereOgni = Convert.ToInt32(txtGiorniDaRipetere.Text.Trim());
                    } catch(Exception ex) {
                        MessageBox.Show("Inserire un numero valido come giorni da ripetere");
                        errore = true;
                    }
                }
                if(!errore) {
                    //Creo l'impegno e lo aggiungo al gestore e alla griglia
                    Impegno nuovoImpegno = new Impegno(titolo, descrizione, giorno, giorno, durata, true, ripetereOgni, null, ColoreHex(colore));
                    nuovoImpegno.ImpegnoOrigine = nuovoImpegno;
                    gestore.AddImpegno(nuovoImpegno);
                    form.Aggiorna();
                    form.Show();
                    this.Close();
                }
            }
        }

        private string ColoreHex(Color colore)
        {
            return $"#{colore.R:X2}{colore.G:X2}{colore.B:X2}";
        }
    }
}
