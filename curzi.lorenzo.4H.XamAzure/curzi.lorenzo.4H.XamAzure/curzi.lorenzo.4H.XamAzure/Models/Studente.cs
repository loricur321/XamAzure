using System;
using System.Collections.Generic;
using System.Text;

namespace curzi.lorenzo._4H.XamAzure.Models
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Immagine { get; set; }
        public string URLImmagine
        {
            get
            {
                return @"https://curzi-lorenzo-4h-xamazureapi.conveyor.cloud/images/" + Immagine;
            }
        }
        //https://curzi-lorenzo-4h-xamazureapi.conveyor.cloud/images/maurizio.conti.png

        public string NomeCognome 
        {
            get
            {
                return $"{Nome} {Cognome}";
            }
        }

        public string Dettagli { get; set; }

        public Studente () { }
    }
}
