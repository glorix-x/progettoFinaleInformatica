using ClassLibraryCalendario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica {
    public partial class FormModificaImpegno : Form
    {
        private Impegno impegno;
        private GestoreImpegni gestore;
        private FormSettimana form;
        public FormModificaImpegno(Impegno impegno, GestoreImpegni gestore, FormSettimana form)
        {
            InitializeComponent();
            this.impegno = impegno;
            this.gestore = gestore;
            this.form = form; 
            ucModifica.GetData(impegno, gestore);
            DateTime giorno = impegno.DataFissata;
            int numOreMax = 0;

            Impegno prossimoImpegno = gestore.GetNextImpegno(giorno);
            if (prossimoImpegno != null && prossimoImpegno.DataFissata.Date.CompareTo(giorno.Date) == 0)
            {
                DateTime oraProssimoImpegno = prossimoImpegno.DataFissata;
                numOreMax = oraProssimoImpegno.Hour - giorno.Hour;
            }
            else
            {
                numOreMax = 24 - giorno.Hour;
            }
            ucModifica.SetData(numOreMax);
        }

        private void btSalvaM_Click(object sender, EventArgs e)
        {
            ucModifica.ModificaImpegno(impegno); 
            gestore.SaveData();                  
            form.Aggiorna();                   
            form.Show();                      
            this.Close();
        }

        private void btElliminaM_Click(object sender, EventArgs e)
        {
            gestore.RimuoviImpegno(impegno.ImpegnoOrigine);
            form.Aggiorna();
            form.Show();
            this.Close();
        }
    }
}
