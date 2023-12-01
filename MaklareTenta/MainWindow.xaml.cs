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
using static System.Net.Mime.MediaTypeNames;

namespace MaklareTenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int area = 57;
            int price = 4250;

            price = int.Parse(txtPrice.Text);
            if (price.ToString().Length <= 4)
            {
                price *= 1000;
            }
            double ratio = price / area;
            ratio = CalcluateRatio(area, price);
            string result = $"{ratio} kr/kvm";
            string formattedPrice = $"{price:C0}";
            txtPrice.Text = formattedPrice ;

        }

        private double CalcluateRatio(int area, int price)
        {
            return price / area;
        }
    }
}