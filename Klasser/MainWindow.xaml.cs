using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Klasser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Broker _broker = new Broker();
        public MainWindow()
        {
            InitializeComponent();
            lstRealEstates.ItemsSource = _broker.GetRealEstates(10,20);
                // Jag får inte till att visa listan.
                // gör den därför publik som jag är van

           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RealEstate estate = new RealEstate()
            {
                Address="Sågstigen 1",
                Area=350,
                Rooms=10
            };

            if(!_broker.AddRealEstate(estate, "Södermalm"))
            {
                MessageBox.Show("ogiltigt värde");
            }
            lstRealEstates.ItemsSource = _broker.GetRealEstates();
        }
    }
}