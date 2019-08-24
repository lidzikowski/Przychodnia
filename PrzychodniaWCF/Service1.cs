using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PrzychodniaDLL;

namespace PrzychodniaWCF
{
    public class Service1 : IService1
    {
        private static Random random = new Random();

        #region Lekarz
        private static List<Lekarz> Lekarze = new List<Lekarz>();

        public List<Lekarz> PobierzLekarzy()
        {
            if (Lekarze.Count == 0)
            {
                Lekarze.Clear();
                Lekarze.Add(new Lekarz() { Imie = "Alan", Nazwisko = "Wierzbicki" });
                Lekarze.Add(new Lekarz() { Imie = "Oliwia", Nazwisko = "Kaczmarek" });
                Lekarze.Add(new Lekarz() { Imie = "Bartek", Nazwisko = "Marek" });
                Lekarze.Add(new Lekarz() { Imie = "Bartek", Nazwisko = "Jabłoński" });
                Lekarze.Add(new Lekarz() { Imie = "Tomasz", Nazwisko = "Zając" });
                Lekarze.Add(new Lekarz() { Imie = "Aleksandra", Nazwisko = "Duda" });
                Lekarze.Add(new Lekarz() { Imie = "Laura", Nazwisko = "Kowalczyk" });
                Lekarze.Add(new Lekarz() { Imie = "Gabriela", Nazwisko = "Michałowska" });
                Lekarze.Add(new Lekarz() { Imie = "Klaudia", Nazwisko = "Rutkowska" });

                for (int i = 0; i < Lekarze.Count; i++)
                {
                    Lekarze[i].Id = i + 1;
                    Lekarze[i].DataStworzenia = DateTime.Now;
                }
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
            if (Pacjenci.Count == 0)
            {
                Pacjenci.Clear();
                PobierzChoroby();
                Pacjenci.Add(new Pacjent() { Imie = "Andrzej", Nazwisko = "Zieliński", Choroby = RandomChoroby() });
                Pacjenci.Add(new Pacjent() { Imie = "Janusz", Nazwisko = "Maciejewski", Choroby = RandomChoroby() });
                Pacjenci.Add(new Pacjent() { Imie = "Stefan", Nazwisko = "Nowakowski", Choroby = RandomChoroby() });
                Pacjenci.Add(new Pacjent() { Imie = "Antoni", Nazwisko = "Sobolewska", Choroby = RandomChoroby() });
                Pacjenci.Add(new Pacjent() { Imie = "Ewa", Nazwisko = "Gołębiowska", Choroby = RandomChoroby() });
                Pacjenci.Add(new Pacjent() { Imie = "Karol", Nazwisko = "Sikorski", Choroby = RandomChoroby() });
                Pacjenci.Add(new Pacjent() { Imie = "Mateusz", Nazwisko = "Sadowski", Choroby = RandomChoroby() });
                Pacjenci.Add(new Pacjent() { Imie = "Marianna", Nazwisko = "Kubiak", Choroby = RandomChoroby() });

                for (int i = 0; i < Pacjenci.Count; i++)
                {
                    Pacjenci[i].Id = i + 1;
                    Pacjenci[i].DataStworzenia = DateTime.Now;
                }

                ObservableCollection<Choroba> RandomChoroby()
                {
                    int ilosc = random.Next(0, 8);
                    ObservableCollection<Choroba> choroby = new ObservableCollection<Choroba>();
                    for (int i = 0; i < ilosc; i++)
                    {
                        choroby.Add(Choroby[random.Next(0, Choroby.Count - 1)]);
                    }
                    return choroby;
                }
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
            if (Choroby.Count == 0)
            {
                Choroby.Clear();
                PobierzLeki();
                Choroby.Add(new Choroba() { Nazwa = "Grozlica", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Gigantyzm", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Menopauza", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Świnka", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Alkaptonuria", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Odra", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Mukowiscydoza", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Lęk", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Synestezja", Leki = RandomLeki() });
                Choroby.Add(new Choroba() { Nazwa = "Amyloidoza", Leki = RandomLeki() });

                for (int i = 0; i < Choroby.Count; i++)
                {
                    Choroby[i].Id = i + 1;
                    Choroby[i].DataStworzenia = DateTime.Now;
                }

                ObservableCollection<Lek> RandomLeki()
                {
                    int ilosc = random.Next(0, 8);
                    ObservableCollection<Lek> leki = new ObservableCollection<Lek>();
                    for (int i = 0; i < ilosc; i++)
                    {
                        leki.Add(Leki[random.Next(0, Leki.Count - 1)]);
                    }
                    return leki;
                }
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
            if (Leki.Count == 0)
            {
                Leki.Clear();
                Leki.Add(new Lek() { Nazwa = "Ibuprom", CzasStosowania = 1 });
                Leki.Add(new Lek() { Nazwa = "Apap", CzasStosowania = 3 });
                Leki.Add(new Lek() { Nazwa = "Amol", CzasStosowania = 7 });
                Leki.Add(new Lek() { Nazwa = "Test", CzasStosowania = 2 });
                Leki.Add(new Lek() { Nazwa = "Hitaxa", CzasStosowania = 4 });
                Leki.Add(new Lek() { Nazwa = "Abra", CzasStosowania = 5 });
                Leki.Add(new Lek() { Nazwa = "ABSENOR", CzasStosowania = 3 });
                Leki.Add(new Lek() { Nazwa = "Cirrus", CzasStosowania = 2 });
                Leki.Add(new Lek() { Nazwa = "Clatra", CzasStosowania = 4 });
                Leki.Add(new Lek() { Nazwa = "Aspicam", CzasStosowania = 6 });
                Leki.Add(new Lek() { Nazwa = "Acenol", CzasStosowania = 2 });
                Leki.Add(new Lek() { Nazwa = "MIG", CzasStosowania = 3 });
                Leki.Add(new Lek() { Nazwa = "Kofepar", CzasStosowania = 4 });
                Leki.Add(new Lek() { Nazwa = "Nalgesin", CzasStosowania = 7 });
                Leki.Add(new Lek() { Nazwa = "Atywia", CzasStosowania = 4 });
                Leki.Add(new Lek() { Nazwa = "Fitoprost", CzasStosowania = 5 });
                Leki.Add(new Lek() { Nazwa = "Aclexa", CzasStosowania = 3 });

                for (int i = 0; i < Leki.Count; i++)
                {
                    Leki[i].Id = i + 1;
                    Leki[i].DataStworzenia = DateTime.Now;
                }
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
                PobierzLekarzy();
                PobierzPacjentow();

                if (Lekarze.Count != 0 && Pacjenci.Count != 0)
                {
                    for (int i = 8; i <= 16; i++)
                    {
                        if (i > random.Next(8, 15))
                            continue;

                        DateTime godzina = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, i, 0, 0);

                        Grafiki.Add(new Grafik()
                        {
                            Lekarz = Lekarze[random.Next(0, Lekarze.Count - 1)],
                            Pacjent = Pacjenci[random.Next(0, Pacjenci.Count - 1)],
                            Godzina = godzina
                        });
                    }

                    for (int i = 0; i < Grafiki.Count; i++)
                    {
                        Grafiki[i].Id = i + 1;
                        Grafiki[i].DataStworzenia = DateTime.Now;
                    }
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
            grafik.Id = Grafiki.Count > 0 ? Grafiki.Last().Id + 1 : 1;
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