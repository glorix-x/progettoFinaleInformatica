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
        public FormModificaImpegno(Impegno impegno)
        {
            InitializeComponent();
            this.impegno = impegno;
        }

    }
}
