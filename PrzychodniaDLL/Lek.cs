namespace PrzychodniaDLL
{
    public class Lek : BaseDLL
    {
        public string Nazwa { get; set; }

        public int CzasStosowania { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}