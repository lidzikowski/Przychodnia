using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrzychodniaDLL
{
    public class Choroba : BaseDLL
    {
        public string Nazwa { get; set; }

        public virtual ObservableCollection<Lek> Leki { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}