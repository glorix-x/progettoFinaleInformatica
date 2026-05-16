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
                    Impegno sovrapposizione = lista.FirstOrDefault(i => SonoSovrapposti(i, impegno));
                    if(sovrapposizione != null) {
                        if(OreSovrapposte(impegno, sovrapposizione) == impegno.DurataOre) {
                            lista.Remove(sovrapposizione);
                        } else {
                            int ore = OreSovrapposte(impegno, sovrapposizione);
                            if(sovrapposizione.DataFissata.CompareTo(impegno.DataFissata) >= 0) {
                                sovrapposizione.DataFissata = sovrapposizione.DataFissata.AddHours(ore);
                                sovrapposizione.DurataOre -= ore;
                            } else {
                                sovrapposizione.DurataOre -= ore;
                            }
                        }
                    }
                    lista.Add(impegno);
                }
                if(impegno.RipetutoOgni != 0) {
                    Impegno i = impegno.Clone();
                    int c = 1;
                    while((i.DataFissata.Date - lunedi.Date).Days < 6) {
                        i = impegno.Clone();
                        i.DataFissata = i.DataFissata.AddDays(impegno.RipetutoOgni * c);
                        diff = (i.DataFissata.Date - lunedi.Date).Days;
                        if(diff >= 0 && diff <= 6) {
                            Impegno sovrapposizione = lista.FirstOrDefault(impegno => SonoSovrapposti(i, impegno));
                            if(sovrapposizione == null || OreSovrapposte(i, sovrapposizione) < i.DurataOre) {
                                if(sovrapposizione != null) {
                                    int ore = OreSovrapposte(i, sovrapposizione);
                                    if(i.DataFissata.CompareTo(sovrapposizione.DataFissata) >= 0) {
                                        i.DataFissata = i.DataFissata.AddHours(ore);
                                        i.DurataOre -= ore; 
                                    } else {
                                        i.DurataOre -= ore;
                                    }
                                }
                                lista.Add(i);
                            }
                        }
                        c++;
                        
                    }
                }
            }
            return lista;
        }

        public bool SonoSovrapposti(Impegno i1, Impegno i2) {
            DateTime inizio1 = i1.DataFissata;
            DateTime fine1 = i1.DataFissata.AddHours(i1.DurataOre);
            DateTime inizio2 = i2.DataFissata;
            DateTime fine2 = i2.DataFissata.AddHours(i2.DurataOre);
            return (inizio1.CompareTo(inizio2) >= 0 && inizio1.CompareTo(fine2) < 0) || (inizio2.CompareTo(inizio1) >= 0 && inizio2.CompareTo(fine1) < 0);
        }

        public int OreSovrapposte(Impegno i1, Impegno i2) {
            int c = 0;
            if(SonoSovrapposti(i1, i2)) {
                c = Math.Min(i2.DataFissata.Hour + i2.DurataOre - i1.DataFissata.Hour, i1.DataFissata.Hour + i1.DurataOre - i2.DataFissata.Hour);
            }
            return c;
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
