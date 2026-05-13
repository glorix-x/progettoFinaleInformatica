using ClassLibraryCalendario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        public void GetData(Impegno i, GestoreImpegni g)
        {
            this.i = i;
            this.g = g;
            tbTitoloM.Text = i.Titolo;
            rtbDescrizioneM.Text = i.Descrizione;
            cbDurata.Text = i.DurataOre.ToString(); 
        }
        public void SetData(int numOreMax)
        {
            tbTitoloM.Text = i.Titolo;
            rtbDescrizioneM.Text = i.Descrizione;
            cbDurata.DataSource = Enumerable.Range(1, numOreMax).ToList();
            cbColore.DataSource = listaColori;

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
            return i;
        }
    }
}
