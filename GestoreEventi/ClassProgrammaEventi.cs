using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {

        //ATTRIBUTI

        private string titolo;
        private int numeroEventi;
        private List<Evento> eventi;


        //COSTRUTTORE

        public ProgrammaEventi(string titolo, int numeroEventi)
        {
            this.titolo = titolo;
            this.numeroEventi = numeroEventi;
            this.eventi = new List<Evento>();
        }


        //GETTERS

        public string GetTitolo()
        {
            return this.titolo;
        }

        public int GetNumeroEventi()
        {
            return this.numeroEventi;
        }

        public List<Evento> GetEventi()
        {
            return this.eventi;
        }


        //SETTERS

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void SetNumeroEventi(int numeroEventi)
        {
            this.numeroEventi = numeroEventi;
        }

        public void SetEvent(List<Evento> eventi)
        {
            this.eventi = eventi;
        }



        //METODI
        public void AddListaEventi(List<Evento> eventi)
        {
            foreach (Evento evento in eventi)
            {
                this.eventi.Add(evento);
            }
        }

        public void AddEvento(Evento evento)
        {
            this.eventi.Add(evento);
        }

        public void EventiPerData(DateTime dateTime)
        {
            foreach (Evento evento in eventi)
            {
                if (dateTime == evento.GetData())
                {
                    evento.ToString();
                }
            }
        }

        public static void StampaListaEventi(List<Evento> eventi)
        {
            foreach(Evento evento in eventi)
            {
                evento.ToString();
            }
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }

        public void CancellaLista()
        {
            eventi.Clear();
        }

        public override string ToString()
        {
            string programmaEventi = "----------" + "\n";
            programmaEventi += this.titolo + "\n";

            foreach (Evento evento in eventi)
            {
                programmaEventi += evento.ToString();
            }

            programmaEventi += "\n";

            return programmaEventi;
        }
    }
}
