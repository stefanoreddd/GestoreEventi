using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Conferenza : Evento
    {
        //ATTRIBUTI
        private string relatore;
        private double prezzo;

        //COSTRUTTORE
        public Conferenza(string titolo, DateTime data, int capienza, int postiPrenotati, string relatore, double prezzo) : base(titolo, data, capienza, postiPrenotati)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        //GETTERS

        public string GetRelatore()
        {
            return this.relatore;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }


        //SETTERS

        public void SetRelatore(string relatore)
        {
            this.relatore = relatore;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }


        //METODI

        public override string ToString()
        {
            string conferenza;
            conferenza = base.ToString() + " - " + this.relatore + " - " + prezzo.ToString("0.00") + " euro";

            return conferenza;
        }
    }
}
