using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgettoFinaleInformatica {
    public partial class FormSettimana : Form {
        private DateTime lunedi;
        public FormSettimana(DateTime lunedi) {
            this.lunedi = lunedi;
            InitializeComponent();
            for(int i = 0; i <= 24; i++) {
                Label lbl = new Label();
                lbl.Location = new Point(grigliaSettimana.Location.X - 70, grigliaSettimana.Location.Y - 12 + i * grigliaSettimana.Height / 24);
                lbl.Text = (i.ToString().Length == 1 ? "0" : "") + i.ToString() + ":00";
                Controls.Add(lbl);
            }
            for(int i = 0; i < 24; i++) {
                for(int j = 0; j < 7; j++) {
                    Button btn = new Button();
                    btn.Tag = new int[] { j, i };
                    btn.Size = new Size(grigliaSettimana.Width / 7, grigliaSettimana.Height / 24);
                    btn.Click += AggiungiImpegno;
                    grigliaSettimana.Controls.Add(btn);
                }
            }
        }

        public void AggiungiImpegno(object sender, EventArgs e) {
            Button btn = (Button)sender;
            int[] coordinate = (int[])btn.Tag;
            string ora = (coordinate[1].ToString().Length == 1 ? "0" : "") + coordinate[1].ToString() + ":00";
            string giorno = "";
            switch(coordinate[0]) {
                case 0: giorno = "Lunedì"; break;
                case 1: giorno = "Martedì"; break;
                case 2: giorno = "Mercoledì"; break;
                case 3: giorno = "Giovedì"; break;
                case 4: giorno = "Venerdì"; break;
                case 5: giorno = "Sabato"; break;
                case 6: giorno = "Domenica"; break;
            }
            MessageBox.Show("Giorno: " + giorno + " Ora: " + ora);
        }
    }
}
