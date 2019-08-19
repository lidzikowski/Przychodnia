using Autofac;
using PrzychodniaDLL;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for DodajPacjenta.xaml
    /// </summary>
    public partial class DodajPacjenta : Window, INotifyPropertyChanged
    {
        public Pacjent Pacjent { get; set; }

        public Choroba SelectedChoroba { get; set; }



        public DodajPacjenta()
        {
            InitializeComponent();

            DataContext = this;

            Pacjent = MainWindow.Container.Resolve<Pacjent>();
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
            return !string.IsNullOrEmpty(Pacjent.Imie) && !string.IsNullOrEmpty(Pacjent.Nazwisko);
        }

        private void DodajChorobeContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (Pacjent.Choroby == null)
                Pacjent.Choroby = new ObservableCollection<Choroba>();

            WybierzChorobe wybierzChorobe = MainWindow.Container.Resolve<WybierzChorobe>();

            if (wybierzChorobe.ShowDialog() == true)
            {
                Pacjent.Choroby.Add(wybierzChorobe.SelectedChoroba);

                OnPropertyRaised(nameof(Choroba));
            }
        }

        private void UsunChorobeContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedChoroba is Choroba choroba)
                Pacjent.Choroby?.Remove(choroba);

            OnPropertyRaised(nameof(Pacjent));
        }
    }
}