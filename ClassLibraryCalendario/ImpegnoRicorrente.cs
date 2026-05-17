using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryCalendario {
    public class ImpegnoRicorrente : Impegno {
        private Impegno impegnoOrigine;

        public ImpegnoRicorrente(string titolo, string descrizione, DateTime deadline, DateTime dataFissata, int durataOre, bool fisso, int ripetutoOgni, string coloreHex, Impegno impegnoOrigine) : base(titolo, descrizione, deadline, dataFissata, durataOre, fisso, ripetutoOgni, coloreHex) {
            this.impegnoOrigine = impegnoOrigine;
        }

        public Impegno ImpegnoOrigine { get => impegnoOrigine; set => impegnoOrigine = value; }
    }
}
