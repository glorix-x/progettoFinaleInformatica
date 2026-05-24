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

        public List<Impegno> GetListaImpegni(DateTime inizio, int numGiorni) {
            listaImpegni = listaImpegni.OrderByDescending(x => x.RipetutoOgni == 0).ThenBy(x => x.DurataOre).ThenBy(x => x.DataFissata).ToList();
            List<Impegno> lista = new List<Impegno>();
            foreach(Impegno impegno in listaImpegni) {
                int diff = (impegno.DataFissata.Date - inizio.Date).Days;
                if(diff >= 0 && diff <= numGiorni - 1 && impegno.RipetutoOgni == 0) {
                    lista.Add(impegno);
                } else if(impegno.RipetutoOgni != 0) {
                    List<Impegno> impegni = new List<Impegno>();
                    int c = 0;
                    while((impegno.DataFissata.AddDays(impegno.RipetutoOgni * c).Date - inizio.Date).Days < numGiorni) {
                        impegni = new List<Impegno>();
                        impegni.Add(impegno.CreateImpegnoRicorrente());
                        Impegno i = impegni[impegni.Count - 1];
                        i.DataFissata = i.DataFissata.AddDays(impegno.RipetutoOgni * c);
                        diff = (i.DataFissata.Date - inizio.Date).Days;
                        if(diff >= 0 && diff <= numGiorni - 1) {
                            List<Impegno> sovrapposizioni = lista.Where(impegno => SonoSovrapposti(i, impegno)).OrderBy(x => x.DataFissata).ToList();
                            foreach(Impegno sovrapposizione in sovrapposizioni) {
                                i = impegni[impegni.Count - 1];
                                if(sovrapposizione.DataFissata.CompareTo(i.DataFissata) > 0 && sovrapposizione.DataFissata.AddHours(sovrapposizione.DurataOre).CompareTo(i.DataFissata.AddHours(i.DurataOre)) < 0) {
                                    ImpegnoRicorrente i1 = new ImpegnoRicorrente(i.Titolo, i.Descrizione, i.Deadline, i.DataFissata, (sovrapposizione.DataFissata - i.DataFissata).Hours, i.Fisso, i.RipetutoOgni, i.ColoreHex, impegno);
                                    ImpegnoRicorrente i2 = new ImpegnoRicorrente(i.Titolo, i.Descrizione, i.Deadline, sovrapposizione.DataFissata.AddHours(sovrapposizione.DurataOre), i.DataFissata.Hour + i.DurataOre - (sovrapposizione.DataFissata.Hour + sovrapposizione.DurataOre), i.Fisso, i.RipetutoOgni, i.ColoreHex, impegno);
                                    if(i1.DurataOre != 0) {
                                        impegni.Add(i1);
                                    }
                                    impegni.Add(i2);
                                    impegni.Remove(i);
                                } else if(OreSovrapposte(i, sovrapposizione) < i.DurataOre) {
                                    int ore = OreSovrapposte(i, sovrapposizione);
                                    if(i.DataFissata.CompareTo(sovrapposizione.DataFissata) >= 0) {
                                        i.DataFissata = i.DataFissata.AddHours(ore);
                                        i.DurataOre -= ore;
                                    } else {
                                        i.DurataOre -= ore;
                                    }
                                } else {
                                    impegni.Remove(i);
                                }
                            }
                            foreach(Impegno imp in impegni) {
                                lista.Add(imp);
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
            List<Impegno> listaImpegni = GetListaImpegni(GetLunedi(ora), 7);
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
        }
        /*
            parte da ora
            cerca il primo buco libero
            mette gli impegni prima della deadline
            evita sovrapposizioni
            evita notte
            evita weekend
            dà priorità alle scadenze vicine
        */
        private bool SlotLibero(DateTime inizio, int durata)
        {
            // Calcolo l'orario di fine dello slot
            DateTime fine = inizio.AddHours(durata);

            // Calcolo quanti giorni copre lo slot
            int giorni = (fine.Date - inizio.Date).Days + 1;

            // Recupero tutti gli impegni presenti
            List<Impegno> impegni = GetListaImpegni(inizio.Date, giorni);

            // Controllo ogni impegno presente
            foreach (Impegno i in impegni)
            {
                // Inizio dell'impegno corrente
                DateTime start = i.DataFissata;

                // Fine dell'impegno corrente
                DateTime end = i.DataFissata.AddHours(i.DurataOre);

                // Verifico se i due intervalli si sovrappongono
                bool occupato = inizio < end && fine > start;

                
                if (occupato)
                    return false;
            }

            return true;
        }
        public List<Impegno> Ottimizza(List<Impegno> daOttimizzare)
        {
            // Ordina gli impegni:
            // prima per scadenza più vicina,
            // poi per durata maggiore
            daOttimizzare = daOttimizzare
                .OrderBy(i => i.Deadline)
                .ThenByDescending(i => i.DurataOre)
                .ToList();

            // Lista degli impegni che verranno pianificati correttamente
            List<Impegno> daRimuovere = new List<Impegno>();

           
            foreach (Impegno imp in daOttimizzare)
            {
                // Parto dalla data e ora corrente
                DateTime corrente = DateTime.Now;

                // Variabile che indica se è stato trovato uno slot libero
                bool trovato = false;

                // Continuo finché non supero la deadline dell’impegno
                while (corrente < imp.Deadline)
                {
                    // Evita orari notturni:
                    // se prima delle 8, sposta alle 8:00
                    if (corrente.Hour < 8)
                    {
                        corrente = new DateTime(
                            corrente.Year,
                            corrente.Month,
                            corrente.Day,
                            8, 0, 0
                        );
                    }

                    // Evita orari oltre le 22:
                    // se l’impegno finirebbe troppo tardi,
                    // passa al giorno successivo alle 8
                    if (corrente.Hour + imp.DurataOre > 22)
                    {
                        corrente = corrente.Date.AddDays(1).AddHours(8);
                        continue;
                    }

                    // Evita il weekend:
                    // se è sabato o domenica,
                    // passa al giorno successivo
                    if (corrente.DayOfWeek == DayOfWeek.Saturday ||
                        corrente.DayOfWeek == DayOfWeek.Sunday)
                    {
                        corrente = corrente.Date.AddDays(1).AddHours(8);
                        continue;
                    }

                    // Controlla se lo slot è libero
                    if (SlotLibero(corrente, imp.DurataOre))
                    {
                        // Assegna la data trovata all’impegno
                        imp.DataFissata = corrente;

                        // Segna che è stato trovato uno slot valido
                        trovato = true;

                        // Esce dal ciclo while
                        break;
                    }

                    // Se lo slot non è libero,
                    // prova un’ora dopo
                    corrente = corrente.AddHours(1);
                }

                // Se è stato trovato uno slot disponibile
                if (trovato)
                {
                    // Aggiunge l’impegno al calendario
                    AddImpegno(imp);

                    // Segna l’impegno per la rimozione
                    // dalla lista da ottimizzare
                    daRimuovere.Add(imp);
                }
            }

            // Rimuove dalla lista gli impegni già pianificati
            foreach (Impegno i in daRimuovere)
            {
                daOttimizzare.Remove(i);
            }

            // Restituisce eventuali impegni non pianificati
            return daOttimizzare;
        }
    }
}
