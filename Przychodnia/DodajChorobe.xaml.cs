using Autofac;
using PrzychodniaDLL;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for DodajChorobe.xaml
    /// </summary>
    public partial class DodajChorobe : Window, INotifyPropertyChanged
    {
        public Choroba Choroba { get; set; }

        public Lek SelectedLek { get; set; }



        public DodajChorobe(Choroba choroba)
        {
            InitializeComponent();

            DataContext = this;

            Choroba = choroba;
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
            return !string.IsNullOrEmpty(Choroba.Nazwa);
        }

        private void DodajLekContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (Choroba.Leki == null)
                Choroba.Leki = new ObservableCollection<Lek>();

            WybierzLek wybierzLek = MainWindow.Container.Resolve<WybierzLek>();

            if (wybierzLek.ShowDialog() == true)
            {
                Choroba.Leki.Add(wybierzLek.SelectedLek);

                OnPropertyRaised(nameof(Choroba));
            }
        }

        private void UsunLekContextMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedLek is Lek lek)
                Choroba.Leki?.Remove(lek);

            OnPropertyRaised(nameof(Choroba));
        }
    }
}