using Autofac;
using Przychodnia.ServiceReference1;
using PrzychodniaDLL;
using System.Collections.ObjectModel;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for WybierzLek.xaml
    /// </summary>
    public partial class WybierzLek : Window
    {
        public ObservableCollection<Lek> Leki { get; set; }

        public Lek SelectedLek { get; set; }

        public WybierzLek()
        {
            InitializeComponent();

            DataContext = this;

            Leki = new ObservableCollection<Lek>(MainWindow.Container.Resolve<Service1Client>().PobierzLeki());
        }

        private void WybierzButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Walidacja())
                return;

            DialogResult = true;
            Close();
        }

        private bool Walidacja()
        {
            return SelectedLek != null;
        }
    }
}