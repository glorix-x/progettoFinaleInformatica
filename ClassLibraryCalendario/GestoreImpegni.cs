using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ClassLibraryCalendario {
    public class GestoreImpegni {
        List<Impegno> listaImpegni;

        public GestoreImpegni() {
            string testo = File.ReadAllText("impegni.json");
            listaImpegni = JsonSerializer.Deserialize<List<Impegno>>(testo);
        }

        public List<Impegno> GetListaImpegniSettimana(DateTime lunedi) {
            List<Impegno> lista = new List<Impegno>();
            foreach(Impegno impegno in listaImpegni) {
                int diff = impegno.DataFissata.Date.CompareTo(lunedi.Date);
                if(diff >= 0 && diff <= 6) {
                    lista.Add(impegno);
                }
            }
            return lista;
        }
    }
}
