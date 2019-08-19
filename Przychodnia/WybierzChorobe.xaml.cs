using Autofac;
using Przychodnia.ServiceReference1;
using PrzychodniaDLL;
using System.Collections.ObjectModel;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for WybierzChorobe.xaml
    /// </summary>
    public partial class WybierzChorobe : Window
    {
        public ObservableCollection<Choroba> Choroby { get; set; }

        public Choroba SelectedChoroba { get; set; }

        public WybierzChorobe()
        {
            InitializeComponent();

            DataContext = this;

            Choroby = new ObservableCollection<Choroba>(MainWindow.Container.Resolve<Service1Client>().PobierzChoroby());
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
            return SelectedChoroba != null;
        }
    }
}