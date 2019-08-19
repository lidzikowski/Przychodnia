using Autofac;
using System.Windows;

namespace Przychodnia
{
    /// <summary>
    /// Interaction logic for Exit.xaml
    /// </summary>
    public partial class Exit : Window
    {
        public Exit()
        {
            InitializeComponent();
        }



        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Container.Resolve<MainWindow>().Show();
            Close();
        }
    }
}