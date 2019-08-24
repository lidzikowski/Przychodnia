using System;

namespace PrzychodniaDLL
{
    public abstract class BaseDLL
    {
        public long Id { get; set; }
        public DateTime? DataStworzenia { get; set; }
        public bool Aktywny { get; set; } = true;
    }
}