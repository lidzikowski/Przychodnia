namespace PrzychodniaDLL
{
    public class Lekarz : BaseDLL
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}