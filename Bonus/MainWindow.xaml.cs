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

namespace Bonus
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
            string input = "AXb!sdfgsdfgsd fgdsgsdggsdg sdgf sdg dsg sdgf sd";
            bool isSuccess = HasCorrectFormat(input);
        }

        private bool HasCorrectFormat(string input)
        {
            // typen !, & eller %
            int upperLetters =0, lowerLetters=0, specialSigns=0;

            foreach(char letter in input)
            {
                if (char.IsLower(letter) )
                {
                    lowerLetters++;
                }
                else if (char.IsUpper(letter))
                {
                    upperLetters++;
                } 
                else if(letter == '!' || letter == '&' || letter == '%')
                {
                    specialSigns++;
                }
                if (upperLetters >= 1 && lowerLetters >= 1 && specialSigns >= 1)
                {
                    return true;
                }
            }

            return upperLetters >= 1 && lowerLetters >= 1 && specialSigns >=1;
        }
    }
}