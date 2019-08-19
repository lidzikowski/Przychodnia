using System;

namespace PrzychodniaDLL
{
    public class Grafik : BaseDLL
    {
        public DateTime Godzina { get; set; }
        public Lekarz Lekarz { get; set; }
        public Pacjent Pacjent { get; set; }

        public bool? Diagnoza { get; set; }
    }
}