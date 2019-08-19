using Autofac;
using Przychodnia.ServiceReference1;
using PrzychodniaDLL;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public static Autofac.IContainer Container { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Lekarz> ListaLekarzy { get; set; } = new ObservableCollection<Lekarz>();
        private Lekarz selectedLekarz;
        public Lekarz SelectedLekarz
        {
            get => selectedLekarz;
            set
            {
                selectedLekarz = value;
                OnPropertyRaised(nameof(SelectedLekarz));
            }
        }

        public ObservableCollection<Pacjent> ListaPacjentow { get; set; } = new ObservableCollection<Pacjent>();
        private Pacjent selectedPacjent;
        public Pacjent SelectedPacjent
        {
            get => selectedPacjent;
            set
            {
                selectedPacjent = value;
                OnPropertyRaised(nameof(SelectedPacjent));
            }
        }

        public ObservableCollection<Choroba> ListaChorob { get; set; } = new ObservableCollection<Choroba>();
        private Choroba selectedChoroba;
        public Choroba SelectedChoroba
        {
            get => selectedChoroba;
            set
            {
                selectedChoroba = value;
                OnPropertyRaised(nameof(SelectedChoroba));
            }
        }

        public ObservableCollection<Lek> ListaLekow { get; set; } = new ObservableCollection<Lek>();
        private Lek selectedLek;
        public Lek SelectedLek
        {
            get => selectedLek;
            set
            {
                selectedLek = value;
                OnPropertyRaised(nameof(SelectedLek));
            }
        }

        public ObservableCollection<Grafik> ListaGrafiki { get; set; } = new ObservableCollection<Grafik>();
        private Grafik selectedGrafik;
        public Grafik SelectedGrafik
        {
            get => selectedGrafik;
            set
            {
                selectedGrafik = value;
                OnPropertyRaised(nameof(SelectedGrafik));
            }
        }

        private DateTime? selectedDateGrafik;
        public DateTime? SelectedDateGrafik
        {
            get => selectedDateGrafik;
            set
            {
                selectedDateGrafik = value;
                OnPropertyRaised(nameof(SelectedDateGrafik));
            }
        }



        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            DI();

            ListaLekarzy = new ObservableCollection<Lekarz>(Container.Resolve<Service1Client>().PobierzLekarzy());

            ListaPacjentow = new ObservableCollection<Pacjent>(Container.Resolve<Service1Client>().PobierzPacjentow());

            ListaChorob = new ObservableCollection<Choroba>(Container.Resolve<Service1Client>().PobierzChoroby());

            ListaLekow = new ObservableCollection<Lek>(Container.Resolve<Service1Client>().PobierzLeki());
        }

        private void DI()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Service1Client>();

            builder.RegisterType<MainWindow>().SingleInstance();
            builder.RegisterType<Exit>();

            builder.RegisterType<DodajLekarza>();
            builder.RegisterType<DodajPacjenta>();
            builder.RegisterType<DodajChorobe>();
            builder.RegisterType<DodajLek>();

            builder.RegisterType<WybierzChorobe>();
            builder.RegisterType<WybierzLek>();

            builder.RegisterType<Lekarz>();
            builder.RegisterType<Pacjent>();
            builder.RegisterType<Choroba>();
            builder.RegisterType<Lek>();
            builder.RegisterType<Grafik>();

            Container = builder.Build();
        }



        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Container.Resolve<Exit>().Show();
        }

        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

        private void WiadomoscBledu()
        {
            MessageBox.Show(Wiadomosci.BladPolaczeniaSerwisu, Wiadomosci.KomunikatBledu, MessageBoxButton.OK, MessageBoxImage.Error);
        }



        // Lekarz
        private void DodajLekarzaContextMenu_Click(object sender, RoutedEventArgs e)
        {
            DodajLekarza dodajLekarza = Container.Resolve<DodajLekarza>();

            if (dodajLekarza.ShowDialog() != true)
                return;

            Lekarz lekarz = Container.Resolve<Service1Client>().DodajLekarza(dodajLekarza.Lekarz);

            if (lekarz != null)
            {
                ListaLekarzy.Add(lekarz);
                SelectedLekarz = lekarz;
            }
            else
            {
                MessageBox.Show(Wiadomosci.BladPolaczeniaSerwisu, Wiadomosci.KomunikatBledu, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UsunLekarzaContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedLekarz is Lekarz lekarz)
            {
                if (Container.Resolve<Service1Client>().UsunLekarza(lekarz.Id))
                {
                    ListaLekarzy.Remove(lekarz);
                }
                else
                {
                    MessageBox.Show(Wiadomosci.BladPolaczeniaSerwisu, Wiadomosci.KomunikatBledu, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }



        // Pacjent
        private void DodajPacjentaContextMenu_Click(object sender, RoutedEventArgs e)
        {
            DodajPacjenta dodajPacjenta = Container.Resolve<DodajPacjenta>();

            if (dodajPacjenta.ShowDialog() != true)
                return;

            Pacjent pacjent = Container.Resolve<Service1Client>().DodajPacjenta(dodajPacjenta.Pacjent);

            if (pacjent != null)
            {
                ListaPacjentow.Add(pacjent);
                SelectedPacjent = pacjent;
            }
            else
                WiadomoscBledu();
        }

        private void UsunPacjentaContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedPacjent is Pacjent pacjent)
            {
                if (Container.Resolve<Service1Client>().UsunPacjenta(pacjent.Id))
                {
                    ListaPacjentow.Remove(pacjent);
                }
                else
                    WiadomoscBledu();
            }
        }


        // Choroba
        private void DodajChorobeContextMenu_Click(object sender, RoutedEventArgs e)
        {
            DodajChorobe dodajChorobe = Container.Resolve<DodajChorobe>();

            if (dodajChorobe.ShowDialog() != true)
                return;

            Choroba choroba = Container.Resolve<Service1Client>().DodajChorobe(dodajChorobe.Choroba);

            if (choroba != null)
            {
                ListaChorob.Add(choroba);
                SelectedChoroba = choroba;
            }
            else
                WiadomoscBledu();
        }

        private void UsunChorobeContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedChoroba is Choroba choroba)
            {
                if (Container.Resolve<Service1Client>().UsunChorobe(choroba.Id))
                {
                    ListaChorob.Remove(choroba);
                }
                else
                    WiadomoscBledu();
            }
        }



        // Lek
        private void DodajLekContextMenu_Click(object sender, RoutedEventArgs e)
        {
            DodajLek dodajLek = Container.Resolve<DodajLek>();

            if (dodajLek.ShowDialog() != true)
                return;

            Lek lek = Container.Resolve<Service1Client>().DodajLek(dodajLek.Lek);

            if (lek != null)
            {
                ListaLekow.Add(lek);
                SelectedLek = lek;
            }
            else
                WiadomoscBledu();
        }

        private void UsunLekContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedLek is Lek lek)
            {
                if (Container.Resolve<Service1Client>().UsunLek(lek.Id))
                {
                    ListaLekow.Remove(lek);
                }
                else
                    WiadomoscBledu();
            }
        }



        // Grafik
        private void DatePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(SelectedDateGrafik is DateTime date)
            {
                ListaGrafiki = new ObservableCollection<Grafik>(Container.Resolve<Service1Client>().PobierzGrafik(date));
                OnPropertyRaised(nameof(ListaGrafiki));
            }
        }

        private void DodajGrafikContextMenu_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void UsunGrafikContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedGrafik is Grafik grafik && grafik.Id > 0)
            {
                if (Container.Resolve<Service1Client>().UsunGrafik(grafik.Id))
                {
                    ListaGrafiki = new ObservableCollection<Grafik>(Container.Resolve<Service1Client>().PobierzGrafik(grafik.Godzina));
                    OnPropertyRaised(nameof(ListaGrafiki));
                }
                else
                    WiadomoscBledu();
            }
        }
    }
}