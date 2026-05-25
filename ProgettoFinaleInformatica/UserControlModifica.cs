using ClassLibraryCalendario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica
{
    public partial class UserControlModifica : UserControl
    {
        Impegno i;
        GestoreImpegni g;

        private static Color[] listaColori =
        {
            Color.OrangeRed,
            Color.LightBlue,
            Color.LightPink,
            Color.Yellow,
            Color.Green
        };

        public UserControlModifica()
        {
            InitializeComponent();
        }

        // Carica i dati dell'impegno nei controlli del form
        public void GetData(Impegno i, GestoreImpegni g)
        {
            this.i = i;
            this.g = g;
            tbTitoloM.Text = i.Titolo;
            rtbDescrizioneM.Text = i.Descrizione;
            cbDurata.Text = i.DurataOre.ToString();

            // Gestiamo la checkbox "Ripeti":
            // Se RipetutoOgni è > 0, l'impegno è ricorrente
            if (i.RipetutoOgni > 0)
            {
                cbRipeti.Checked = true;
                tbRipeti.Text = i.RipetutoOgni.ToString();
            }
            else
            {
                cbRipeti.Checked = false;
                tbRipeti.Text = "";
            }
        }
        //Configura i controlli grafici
        public void SetData(int numOreMax)
        {
            tbTitoloM.Text = i.Titolo;
            rtbDescrizioneM.Text = i.Descrizione;
            //Genera automaticamente una lista di numeri
            cbDurata.DataSource = Enumerable.Range(1, numOreMax).ToList();
            //Seleziona nel ComboBox la durata originale
            if (i is ImpegnoRicorrente) {
                cbDurata.SelectedIndex = ((ImpegnoRicorrente)i).ImpegnoOrigine.DurataOre - 1;
            } else {
                //Imposta la durata normale
                cbDurata.SelectedIndex = i.DurataOre - 1;
            }


            cbColore.DataSource = listaColori;
            cbColore.DisplayMember = "Name";
            //Converte una stringa HTML in un oggetto Color     
            Color colore = ColorTranslator.FromHtml(i.ColoreHex);
            cbColore.SelectedIndex = listaColori.IndexOf(listaColori.FirstOrDefault(c => colore.R == c.R && colore.G == c.G && colore.B == c.B));
        }

        private void cbRipeti_CheckedChanged(object sender, EventArgs e)
        {
            tbRipeti.Enabled = cbRipeti.Checked;
            if (!cbRipeti.Checked)
                tbRipeti.Text = "";
        }

        private string ColoreHex(Color colore)
        {
            return $"#{colore.R:X2}{colore.G:X2}{colore.B:X2}";
        }

        public void ModificaImpegno(Impegno i)
        {
            Impegno impegno = null;
            if (i is ImpegnoRicorrente)
            {
                //Modifica l’impegno originale
                impegno = ((ImpegnoRicorrente)i).ImpegnoOrigine;
            }
            else
            {
                impegno = i;
            }
            //Aggiornamenti
            impegno.Titolo = tbTitoloM.Text;
            impegno.Descrizione = rtbDescrizioneM.Text;
            impegno.DurataOre = (int)cbDurata.SelectedValue;
            impegno.ColoreHex = ColoreHex(listaColori[cbColore.SelectedIndex]);
            //Convertire il testo in numero senza errori , Salva il risultato nella variabile giorni
            if (cbRipeti.Checked && int.TryParse(tbRipeti.Text, out int giorni) && giorni > 0)
            {
                impegno.RipetutoOgni = giorni;
            }
            else
            {
                impegno.RipetutoOgni = 0;
            }
        }

        private void cbRipeti_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbRipeti.Checked)
            {
                label3.Show();
                tbRipeti.Show();
            }
            else
            {
                label3.Hide();
                tbRipeti.Hide();
            }
        }
    }
}