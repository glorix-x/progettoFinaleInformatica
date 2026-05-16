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
        public void RimuoviImpegno(Impegno impegno)
        {
            listaImpegni.Remove(impegno);
            this.SaveData();
        }
        /*  
            parte da ORA
            cerca il primo buco libero
            mette gli impegni prima della deadline
            evita sovrapposizioni
            evita notte
            evita weekend
            dà priorità alle scadenze vicine
        */
        private bool SlotLibero(DateTime inizio, int durata)
        {
            DateTime fine = inizio.AddHours(durata);

            foreach (Impegno i in listaImpegni)
            {
                DateTime start = i.DataFissata;
                DateTime end = i.DataFissata.AddHours(i.DurataOre);

                bool libero = inizio < end && fine > start;

                if (libero)
                    return false;
            }

            return true;
        }
        public void Ottimizza(List<Impegno> daOttimizzare)
        {
            // Ordino per deadline
            daOttimizzare = daOttimizzare
                .OrderBy(i => i.Deadline)
                .ThenByDescending(i => i.DurataOre)
                .ToList();

            foreach (Impegno imp in daOttimizzare)
            {
                DateTime corrente = DateTime.Now;

                bool trovato = false;

                while (corrente < imp.Deadline)
                {
                    // Evita notte
                    if (corrente.Hour < 8)
                    {
                        corrente = new DateTime(
                            corrente.Year,
                            corrente.Month,
                            corrente.Day,
                            8, 0, 0
                        );
                    }

                    // Evita oltre le 22
                    if (corrente.Hour + imp.DurataOre > 22)
                    {
                        corrente = corrente.Date.AddDays(1).AddHours(8);
                        continue;
                    }

                    // Evita weekend
                    if (corrente.DayOfWeek == DayOfWeek.Saturday ||
                       corrente.DayOfWeek == DayOfWeek.Sunday)
                    {
                        corrente = corrente.Date.AddDays(1).AddHours(8);
                        continue;
                    }

                    // Controllo slot
                    if (SlotLibero(corrente, imp.DurataOre))
                    {
                        imp.DataFissata = corrente;

                        listaImpegni.Add(imp);

                        trovato = true;
                        break;
                    }

                    corrente = corrente.AddHours(1);
                }
                AddImpegno(imp);

                if (!trovato)
                {
                   
                }
                SaveData();
            }
        }
    }
}
