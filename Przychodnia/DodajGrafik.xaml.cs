using Autofac;
using Przychodnia.ServiceReference1;
using PrzychodniaDLL;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for DodajGrafik.xaml
    /// </summary>
    public partial class DodajGrafik : Window, INotifyPropertyChanged
    {
        public Grafik Grafik { get; set; }

        public ObservableCollection<Pacjent> Pacjenci { get; set; }
        public Pacjent SelectedPacjent
        {
            get => Grafik.Pacjent;
            set => Grafik.Pacjent = value;
        }

        public ObservableCollection<Lekarz> Lekarze { get; set; }
        public Lekarz SelectedLekarz
        {
            get => Grafik.Lekarz;
            set => Grafik.Lekarz = value;
        }



        public DodajGrafik()
        {
            InitializeComponent();

            DataContext = this;

            Pacjenci = new ObservableCollection<Pacjent>(MainWindow.Container.Resolve<Service1Client>().PobierzPacjentow());

            Lekarze = new ObservableCollection<Lekarz>(MainWindow.Container.Resolve<Service1Client>().PobierzLekarzy());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Walidacja())
                return;

            DialogResult = true;
            Close();
        }

        private bool Walidacja()
        {
            return SelectedLekarz != null && SelectedPacjent != null;
        }
    }
}