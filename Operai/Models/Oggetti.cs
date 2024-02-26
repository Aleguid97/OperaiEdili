using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Operai.Models
{
    public class Operai
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CodiceFiscale { get; set; }
        public string Mansione { get; set; }
        public bool Sposato { get; set; }
        public int Figli { get; set; }

       
        public Operai(string nome, string cognome, string indirizzo, string codiceFiscale, string mansione, bool sposato, int figli)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            CodiceFiscale = codiceFiscale;
            Mansione = mansione;
            Sposato = sposato;
            Figli = figli;
        }
    }
}
