using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrzychodniaDLL
{
    public class Pacjent : BaseDLL
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public virtual ObservableCollection<Choroba> Choroby { get; set; }
        public string ChorobyToString
        {
            get
            {
                if (Choroby == null || Choroby.Count == 0)
                    return string.Empty;

                string message = string.Empty;
                foreach (Choroba choroba in Choroby)
                {
                    message += $"{choroba.Nazwa}, ";
                }
                return message.Remove(message.Length - 2, 2);
            }
        }

        public bool CzyChory
        {
            get => Choroby != null && Choroby.Count > 0;
        }



        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}