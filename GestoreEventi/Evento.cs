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
        private int postiPrenotati;


        //COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienza, int postiPrenotati = 0)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienza = capienza;
            if(capienza < 0)
            {
                throw new ArgumentException("La capienza non può avere un numero negativo.");
            }
            this.postiPrenotati = postiPrenotati;
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

            if(data < DateTime.Now)
            {
                throw new ArgumentException("La data non può essere antecedente alla data attuale. Riprova.");
            }
        }


        //METODI

        public void PrenotaPosti(int postiUtente)
        {

            if (postiPrenotati > this.capienza || this.data > DateTime.Now)
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
            else
            {
                postiPrenotati += postiUtente;
            }

        }

        /*public void CancellaPrenotazione(int postiCancellatiUtente)
        {
            

            if (postiPrenotati - postiCancellatiUtente < postiPrenotati && this.data > DateTime.Now && postiCancellatiUtente < postiPrenotati)
            {
                postiPrenotati -= postiCancellatiUtente;
            }
            else
            {
                throw new ArgumentException("Impossibile cancellare la prenotazione.");
            }
            
        }*/

        public void CancellaPrenotazione(int postiCancellatiUtente)
        {
            if (postiCancellatiUtente < 0)
            {
                throw new Exception("Il numero delle disdette è negativo. Riprova.");
            }
            else if (postiCancellatiUtente < this.postiPrenotati)
            {
                throw new Exception("Il numero delle disdette è superiore alle prenotazioni. Riprova.");
            }
            else if (postiPrenotati - postiCancellatiUtente > postiPrenotati || this.data < DateTime.Now)
            {
                throw new Exception("Impossibile disdire la prenotazione per questo evento.");
            }
            else
            {
                this.postiPrenotati -= postiCancellatiUtente;
            }
        }


        public override string ToString()
        {
            return data.ToString("dd/MM/yyyy") + titolo;
        }

    }
}
