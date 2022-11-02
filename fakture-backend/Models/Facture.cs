using System;
using System.Collections.Generic;

namespace fakture_backend.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Partner { get; set; }
        public float IznosBezPdv { get; set; }
        public float PostoRabata { get; set; }
        public float Rabat { get; set; }
        public float IznosSaRabatomBezPdv { get; set; }
        public float Pdv { get; set; }
        public float Ukupno { get; set; }
        public List<Article> Artikli { get; set; }

    }
}
