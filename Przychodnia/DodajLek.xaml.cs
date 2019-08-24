using Autofac;
using PrzychodniaDLL;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for DodajLek.xaml
    /// </summary>
    public partial class DodajLek : Window
    {
        public Lek Lek { get; set; }



        public DodajLek(Lek lek)
        {
            InitializeComponent();

            DataContext = this;

            Lek = lek;
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
            return !string.IsNullOrEmpty(Lek.Nazwa) && Lek.CzasStosowania > 0;
        }
    }
}