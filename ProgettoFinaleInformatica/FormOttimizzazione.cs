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
    public partial class FormOttimizzazione : Form
    {
        private GestoreImpegni g;
        private BindingList<Impegno> impegniDaOttimizzare = new BindingList<Impegno>();
        public FormOttimizzazione(GestoreImpegni g)
        {
            InitializeComponent();
            this.g = g;
            dgvImpegni.DataSource = impegniDaOttimizzare;
            cbColore.DataSource = FormCreazioneImpegno.listaColori;
            cbDurata.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            this.BackColor = Color.LightBlue;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.Trim().Length == 0 || rtbDescrizione.Text.Trim().Length == 0)
            {
                MessageBox.Show("impegno non valido! :(");
                return;

            }
            Impegno i = new Impegno(tbNome.Text, rtbDescrizione.Text, dtpDeadline.Value, DateTime.Now, Convert.ToInt32(cbDurata.Text), false, ColoreHex(FormCreazioneImpegno.listaColori[cbColore.SelectedIndex]));
            impegniDaOttimizzare.Add(i);

        }
        private string ColoreHex(Color colore)
        {
            return $"#{colore.R:X2}{colore.G:X2}{colore.B:X2}";
        }

        private void dgvImpegni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 0)
                {
                    impegniDaOttimizzare.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
