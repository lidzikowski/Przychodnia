using Autofac;
using PrzychodniaDLL;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for DodajLekarza.xaml
    /// </summary>
    public partial class DodajLekarza : Window
    {
        public Lekarz Lekarz { get; set; }



        public DodajLekarza()
        {
            InitializeComponent();

            DataContext = this;

            Lekarz = MainWindow.Container.Resolve<Lekarz>();
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
            return !string.IsNullOrEmpty(Lekarz.Imie) && !string.IsNullOrEmpty(Lekarz.Nazwisko);
        }
    }
}