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
                int diff = (impegno.DataFissata.Date - lunedi.Date).Days;
                if(diff >= 0 && diff <= 6) {
                    lista.Add(impegno);
                }
                if(impegno.RipetutoOgni != 0) {
                    Impegno i = impegno.Clone();
                    while((i.DataFissata.Date - lunedi.Date).Days < 6) {
                        i = i.Clone();
                        i.DataFissata = i.DataFissata.AddDays(impegno.RipetutoOgni);
                        diff = (i.DataFissata.Date - lunedi.Date).Days;
                        if(diff >= 0 && diff <= 6) {
                            lista.Add(i);
                        }
                    }
                }
            }
            return lista;
        }

        public Impegno GetNextImpegno(DateTime ora) {
            Impegno next = null;
            List<Impegno> listaImpegni = GetListaImpegniSettimana(GetLunedi(ora));
            foreach(Impegno i in listaImpegni) {
                if(i.DataFissata.CompareTo(ora) > 0 && (next == null || i.DataFissata.CompareTo(next.DataFissata) < 0)) {
                    next = i;
                }
            }
            return next;
        }

        public DateTime GetLunedi(DateTime day) {
            int differenza = (7 + day.DayOfWeek - DayOfWeek.Monday) % 7;
            return day.AddDays(-differenza).Date;
        }

        public void AddImpegno(Impegno impegno) {
            listaImpegni.Add(impegno);
        }

        public void SaveData() {
            File.WriteAllText("impegni.json", JsonSerializer.Serialize(listaImpegni));
        }
    }
}
