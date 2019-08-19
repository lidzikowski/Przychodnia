using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PrzychodniaDLL;

namespace PrzychodniaWCF
{
    public class Service1 : IService1
    {
        #region Lekarz
        private static List<Lekarz> Lekarze = new List<Lekarz>();

        public List<Lekarz> PobierzLekarzy()
        {
            Lekarze.Clear();
            Lekarze.Add(new Lekarz() { Imie = "Jan", Nazwisko = "Test" });
            Lekarze.Add(new Lekarz() { Imie = "Nfg", Nazwisko = "Test2" });
            Lekarze.Add(new Lekarz() { Imie = "AAA", Nazwisko = "BBB" });

            for (int i = 0; i < Lekarze.Count; i++)
            {
                Lekarze[i].Id = i;
                Lekarze[i].DataStworzenia = DateTime.Now;
            }

            return Lekarze;
        }

        public Lekarz DodajLekarza(Lekarz lekarz)
        {
            lekarz.Id = Lekarze.Count > 0 ? Lekarze.Last().Id + 1 : 1;
            lekarz.DataStworzenia = DateTime.Now;

            Lekarze.Add(lekarz);
            return lekarz;
        }

        public bool UsunLekarza(long id)
        {
            Lekarz lekarz = Lekarze.FirstOrDefault(o => o.Id == id);
            if (lekarz != null)
            {
                Lekarze.Remove(lekarz);
                return true;
            }
            return false;
        }
        #endregion

        #region Pacjent
        private static List<Pacjent> Pacjenci = new List<Pacjent>();

        public List<Pacjent> PobierzPacjentow()
        {
            Pacjenci.Clear();
            Pacjenci.Add(new Pacjent() { Imie = "Jan", Nazwisko = "Test", Choroby = new ObservableCollection<Choroba>(PobierzChoroby()) });
            Pacjenci.Add(new Pacjent() { Imie = "Nfg", Nazwisko = "Test2" });
            Pacjenci.Add(new Pacjent() { Imie = "AAA", Nazwisko = "BBB" });

            for (int i = 0; i < Pacjenci.Count; i++)
            {
                Pacjenci[i].Id = i;
                Pacjenci[i].DataStworzenia = DateTime.Now;
            }

            return Pacjenci;
        }

        public Pacjent DodajPacjenta(Pacjent pacjent)
        {
            pacjent.Id = Pacjenci.Count > 0 ? Pacjenci.Last().Id + 1 : 1;
            pacjent.DataStworzenia = DateTime.Now;

            Pacjenci.Add(pacjent);
            return pacjent;
        }

        public bool UsunPacjenta(long id)
        {
            Pacjent pacjent = Pacjenci.FirstOrDefault(o => o.Id == id);
            if (pacjent != null)
            {
                Pacjenci.Remove(pacjent);
                return true;
            }
            return false;
        }
        #endregion

        #region Lek
        private static List<Choroba> Choroby = new List<Choroba>();

        public List<Choroba> PobierzChoroby()
        {
            Choroby.Clear();
            Choroby.Add(new Choroba() { Nazwa = "Grozlica", Leki = new ObservableCollection<Lek>(PobierzLeki())});
            Choroby.Add(new Choroba() { Nazwa = "Odra" });
            Choroby.Add(new Choroba() { Nazwa = "Świnka" });

            for (int i = 0; i < Choroby.Count; i++)
            {
                Choroby[i].Id = i;
                Choroby[i].DataStworzenia = DateTime.Now;
            }

            return Choroby;
        }

        public Choroba DodajChorobe(Choroba choroba)
        {
            choroba.Id = Choroby.Count > 0 ? Choroby.Last().Id + 1 : 1;
            choroba.DataStworzenia = DateTime.Now;

            Choroby.Add(choroba);
            return choroba;
        }

        public bool UsunChorobe(long id)
        {
            Choroba choroba = Choroby.FirstOrDefault(o => o.Id == id);
            if (choroba != null)
            {
                Choroby.Remove(choroba);
                return true;
            }
            return false;
        }
        #endregion

        #region Lek
        private static List<Lek> Leki = new List<Lek>();

        public List<Lek> PobierzLeki()
        {
            Leki.Clear();
            Leki.Add(new Lek() { Nazwa = "Ibuprom" });
            Leki.Add(new Lek() { Nazwa = "Apap" });
            Leki.Add(new Lek() { Nazwa = "Test" });

            for (int i = 0; i < Leki.Count; i++)
            {
                Leki[i].Id = i;
                Leki[i].DataStworzenia = DateTime.Now;
            }

            return Leki;
        }

        public Lek DodajLek(Lek lek)
        {
            lek.Id = Leki.Count > 0 ? Leki.Last().Id + 1 : 1;
            lek.DataStworzenia = DateTime.Now;

            Leki.Add(lek);
            return lek;
        }

        public bool UsunLek(long id)
        {
            Lek lek = Leki.FirstOrDefault(o => o.Id == id);
            if (lek != null)
            {
                Leki.Remove(lek);
                return true;
            }
            return false;
        }
        #endregion

        #region Grafik
        private static List<Grafik> Grafiki = new List<Grafik>();

        public List<Grafik> PobierzGrafik(DateTime dateTime)
        {
            if(Grafiki.Count == 0)
            {
                Grafiki.Add(new Grafik() { Lekarz = PobierzLekarzy().First(), Pacjent = PobierzPacjentow().First(), Godzina = new DateTime(2019, 08, 19, 15, 0, 0) });
                Grafiki.Add(new Grafik() { Lekarz = PobierzLekarzy().First(), Pacjent = PobierzPacjentow().First(), Godzina = new DateTime(2019, 08, 19, 16, 0, 0) });
                Grafiki.Add(new Grafik() { Lekarz = PobierzLekarzy().First(), Pacjent = PobierzPacjentow().First(), Godzina = new DateTime(2019, 08, 19, 17, 0, 0) });
                Grafiki.Add(new Grafik() { Lekarz = PobierzLekarzy().First(), Pacjent = PobierzPacjentow().First(), Godzina = new DateTime(2019, 08, 19, 18, 0, 0) });

                Grafiki.Add(new Grafik() { Lekarz = PobierzLekarzy().Last(), Pacjent = PobierzPacjentow().Last(), Godzina = new DateTime(2019, 08, 19, 19, 0, 0) });
                Grafiki.Add(new Grafik() { Lekarz = PobierzLekarzy().Last(), Pacjent = PobierzPacjentow().Last(), Godzina = new DateTime(2019, 08, 19, 20, 0, 0) });

                for (int i = 0; i < Grafiki.Count; i++)
                {
                    Grafiki[i].Id = i + 1;
                    Grafiki[i].DataStworzenia = DateTime.Now;
                }
            }

            List<Grafik> returnGrafiki = new List<Grafik>();
            for (int i = 8; i <= 16; i++)
            {
                returnGrafiki.Add(new Grafik() { Godzina = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, i, 0, 0) });
            }

            foreach (Grafik grafik in Grafiki.Where(o => o.Godzina.Year == dateTime.Year && o.Godzina.Month == dateTime.Month && o.Godzina.Day == dateTime.Day))
            {
                Grafik searchGrafik = returnGrafiki.FirstOrDefault(o => o.Godzina.Hour == grafik.Godzina.Hour);
                if (searchGrafik == null)
                    returnGrafiki.Add(grafik);
                else
                    returnGrafiki[returnGrafiki.IndexOf(searchGrafik)] = grafik;
            }

            return returnGrafiki;
        }

        public Grafik DodajGrafik(Grafik grafik)
        {
            grafik.Id = Leki.Count > 0 ? Leki.Last().Id + 1 : 1;
            grafik.DataStworzenia = DateTime.Now;

            Grafiki.Add(grafik);
            return grafik;
        }

        public bool UsunGrafik(long id)
        {
            Grafik grafik = Grafiki.FirstOrDefault(o => o.Id == id);
            if (grafik != null)
            {
                Grafiki.Remove(grafik);
                return true;
            }
            return false;
        }
        #endregion
    }
}