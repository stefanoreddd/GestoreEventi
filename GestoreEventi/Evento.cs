using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //ATTRIBUTI
        private string titolo;
        private DateTime data;
        private int capienza;
        private static int postiPrenotati = 0;


        //COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienza)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienza = capienza;
            if(capienza < 0)
            {
                throw new Exception("La capienza non può avere un numero negativo.");
            }
            postiPrenotati++;
        }


        //GETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }
        
        public DateTime GetData()
        {
            return this.data;
        }

        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }

        public int GetCapienza()
        {
            return this.capienza;
        }


        //SETTERS

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;

            if(titolo == "")
            {
                throw new ArgumentException("Il titolo dell'evento non può essere un campo vuoto. Riprova.");
            }
        }

        public void SetData(DateTime data)
        {
            this.data = data;
            DateTime dataAttuale = DateTime.Now;

            if(data < dataAttuale)
            {
                throw new ArgumentException("La data non può essere antecedente alla data attuale. Riprova.");
            }
        }


        //METODI

        public void PrenotaPosti(int postiUtente)
        {
            postiUtente = int.Parse(Console.ReadLine());
            postiPrenotati += postiUtente;

            if (postiPrenotati > this.capienza && this.data > DateTime.Now)
            {
                throw new ArgumentException("Non ci sono posti a sufficienza da prenotare.");
            }
            else if (this.capienza == 0)
            {
                throw new ArgumentException("Posti disponibili per questo evento terminati.");
            }
            else if (this.data < DateTime.Now)
            {
                throw new ArgumentException("Questo evento è terminato.");
            }

        }

        public void CancellaPrenotazione(int postiCancellatiUtente)
        {
            postiCancellatiUtente = int.Parse(Console.ReadLine());
            postiPrenotati -= postiCancellatiUtente;

            if (postiCancellatiUtente > postiPrenotati && this.data > DateTime.Now)
            {
                throw new ArgumentException("Non ci sono posti a sufficienza da cancellare.");
            }
            else if (this.data < DateTime.Now)
            {
                throw new ArgumentException("Questo evento è terminato.");
            }
        }


        public override string ToString()
        {
            return data.ToString("dd/MM/yyyy") + titolo;
        }

    }
}
