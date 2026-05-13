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
            cbOreM.Text = i.DurataOre.ToString(); 
        }
        public void SetData()
        {
            tbTitoloM.Text = i.Titolo;
            rtbDescrizioneM.Text = i.Descrizione;

        }
    }
}
