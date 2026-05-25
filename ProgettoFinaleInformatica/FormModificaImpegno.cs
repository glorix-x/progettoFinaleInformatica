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

            if(!(impegno is ImpegnoRicorrente)) {
                Impegno prossimoImpegno = gestore.GetNextImpegno(giorno);
                //Esiste un prossimo impegno e Verifica se è nello stesso giorno.
                if (prossimoImpegno != null && prossimoImpegno.DataFissata.Date.CompareTo(giorno.Date) == 0) {
                    //Prende la data/ora del prossimo impegno
                    DateTime oraProssimoImpegno = prossimoImpegno.DataFissata;
                    //Calcola quante ore ci sono tra: l’impegno corrente il prossimo.
                    numOreMax = oraProssimoImpegno.Hour - giorno.Hour;
                } else {
                    //Calcola quante ore restano fino a mezzanotte  
                    numOreMax = 24 - giorno.Hour;
                }
            } else {
                //Cast impegno in tipo ImpegnoRicorrente
                numOreMax = 24 - ((ImpegnoRicorrente)impegno).ImpegnoOrigine.DataFissata.Hour;
            }
            //Controllo il numero massimo di ore consentite
            ucModifica.SetData(numOreMax);
        }

        private void btSalvaM_Click(object sender, EventArgs e)
        {
            ucModifica.ModificaImpegno(impegno);
            form.Aggiorna();
            form.Show();
            this.Close();
        }

        private void btEliminaM_Click(object sender, EventArgs e)
        {
            //Controlla se è ricorrente.
            if (impegno is ImpegnoRicorrente)
            {
                //Converte l’oggetto,elimina l’impegno originale
                gestore.RimuoviImpegno(((ImpegnoRicorrente)impegno).ImpegnoOrigine);
            }
            else
            {
                //Elimina direttamente l’impegno normale
                gestore.RimuoviImpegno(impegno);
            }
            form.Aggiorna();
            form.Show();
            this.Close();
        }
        //Imposta il colore di sfondo della finestra quando viene aperto
        private void FormModificaImpegno_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(impegno.ColoreHex);
        }
    }
}
