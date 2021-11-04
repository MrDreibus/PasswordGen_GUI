using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;


namespace PasswordGen
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
    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }
    private void Gen_Password(object sender, RoutedEventArgs e)
        {
            String password = "";

            for (int i = 0; i < int.Parse(LenghtBox.Text); i++) {
                var random = new Random();
                var value = random.Next(1, 4);

                if (value == 1) {
                    int letter = (int) random.Next(60, 90);
                    password +=  (char) letter;
                } else if (value == 2) {
                    int letter = (int)random.Next(97, 122);
                    password += (char)letter;
                }  else if (value == 3)  {
                    int letter = (int)random.Next(33, 46); 
                    password += (char)letter;

                } else {
                    int letter = (int)random.Next(48, 57);
                    password += (char) letter;
                }
            }
            Password.Text = password;
        }
    }
}
