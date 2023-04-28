using System;
using System.Collections.Generic;
using System.Linq;
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

        public void PrenotaPosti()
        {
            Console.WriteLine("Quanti posti desideri prenotare?");



        }


    }
}
