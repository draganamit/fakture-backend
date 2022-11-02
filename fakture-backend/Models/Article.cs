namespace fakture_backend.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public float Cijena { get; set; }
        public float IznosBezPdv { get; set; }
        public float PostoRabata { get; set; }
        public float Rabat { get; set; }
        public float IznostSaRabatomBezPdv { get; set; }
        public float Pdv { get; set; }
        public float Ukupno { get; set; }





    }
}
