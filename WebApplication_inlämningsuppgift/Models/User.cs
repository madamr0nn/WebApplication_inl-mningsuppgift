namespace WebApplication_inlämningsuppgift.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Förnamn  { get; set; }
        public string Efternamn { get; set; }
        public string Mejladress { get; set; }
        public string Lösenord { get; set; }
        public string Adress { get; set; }
        public int Kundnummer { get; set; }
    }
}
