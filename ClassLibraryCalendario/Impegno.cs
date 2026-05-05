namespace ClassLibraryCalendario {
    public class Impegno {
        private string titolo;
        private string descrizione;
        private DateTime deadline;
        private DateTime dataFissata;
        private int durataOre;
        private bool fisso;

        public Impegno(string titolo, string descrizione, DateTime deadline, DateTime dataFissata, int durataOre, bool fisso) {
            this.titolo = titolo;
            this.descrizione = descrizione;
            this.deadline = deadline;
            this.dataFissata = dataFissata;
            this.durataOre = durataOre;
            this.fisso = fisso;
        }

        public string Titolo { get => titolo; set => titolo = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public DateTime DataFissata { get => dataFissata; set => dataFissata = value; }
        public int DurataOre { get => durataOre; set => durataOre = value; }
        public bool Fisso { get => fisso; set => fisso = value; }
    }
}
