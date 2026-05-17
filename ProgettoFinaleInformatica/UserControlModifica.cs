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

            // ✅ Gestiamo la checkbox "Ripeti":
            // Se RipetutoOgni è > 0, l'impegno è ricorrente
            if (i.RipetutoOgni > 0)
            {
                cbRipeti.Checked = true;
                tbRipeti.Text = i.RipetutoOgni.ToString();
                tbRipeti.Enabled = true;
            }
            else
            {
                cbRipeti.Checked = false;
                tbRipeti.Text = "";
                tbRipeti.Enabled = false; 
            }
        }

        public void SetData(int numOreMax)
        {
            tbTitoloM.Text = i.Titolo;
            rtbDescrizioneM.Text = i.Descrizione;
            cbDurata.DataSource = Enumerable.Range(1, numOreMax).ToList();


            cbColore.DataSource = listaColori;
            cbColore.DisplayMember = "Name";
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

        public Impegno ModificaImpegno(Impegno i)
        {
            i.Titolo = tbTitoloM.Text;
            i.Descrizione = rtbDescrizioneM.Text;
            i.DurataOre = (int)cbDurata.SelectedValue;
            i.ColoreHex = ColoreHex(listaColori[cbColore.SelectedIndex]);


            if (cbRipeti.Checked && int.TryParse(tbRipeti.Text, out int giorni) && giorni > 0)
            {
                i.RipetutoOgni = giorni;
            }
            else
            {
                i.RipetutoOgni = 0; 
            }

            return i;
        }
    }
}