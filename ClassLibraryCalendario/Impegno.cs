using System.Drawing;

namespace ClassLibraryCalendario {
    public class Impegno {
        private string titolo;
        private string descrizione;
        private DateTime deadline;
        private DateTime dataFissata;
        private int durataOre;
        private bool fisso;
        private int ripetutoOgni;
        private string coloreHex;

        public Impegno(string titolo, string descrizione, DateTime deadline, DateTime dataFissata, int durataOre, bool fisso, int ripetutoOgni, string coloreHex) {
            this.titolo = titolo;
            this.descrizione = descrizione;
            this.deadline = deadline;
            this.dataFissata = dataFissata;
            this.durataOre = durataOre;
            this.fisso = fisso;
            this.ripetutoOgni = ripetutoOgni;
            this.coloreHex = coloreHex;
        }

        public string Titolo { get => titolo; set => titolo = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public DateTime DataFissata { get => dataFissata; set => dataFissata = value; }
        public int DurataOre { get => durataOre; set => durataOre = value; }
        public bool Fisso { get => fisso; set => fisso = value; }
        public int RipetutoOgni { get => ripetutoOgni; set => ripetutoOgni = value; }
        public string ColoreHex { get => coloreHex; set => coloreHex = value; }

        public Impegno Clone() {
            return new Impegno(this.Titolo, this.Descrizione, this.Deadline, this.DataFissata, this.DurataOre, this.Fisso, this.RipetutoOgni, this.ColoreHex);
        }

        public override string ToString() {
            string s = "";
            s += titolo + "\n";
            s += descrizione + "\n";
            s += GetStringHour();
            return s;
        }

        public string GetStringHour() {
            return (dataFissata.Hour.ToString().Length == 1 ? "0" : "") + dataFissata.Hour.ToString() + ":00 - " + ((dataFissata.Hour + durataOre).ToString().Length == 1 ? "0" : "") + (dataFissata.Hour + durataOre).ToString() + ":00";
        }
    }
}
