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

namespace Talstelsel
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
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // controleren of input hexadecimale waarde is of backspace
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            string hex = inputTextBox.Text;

            int dec = 0;

            for (int i = 0, j = hex.Length -1 ; i < hex.Length; i++, j--)
            {
                int factor = (int)Math.Pow(16, j);

                if (char.IsDigit(hex[i]))
                {
                    dec += (int)char.GetNumericValue(hex[i]) * factor;
                }
                else
                {
                    switch (hex[i])
                    {
                        case 'A':
                        case 'a':
                            dec += 10 * factor;
                            break;
                        case 'B':
                        case 'b':
                            dec += 11 * factor;
                            break;
                        case 'C':
                        case 'c':
                            dec += 12 * factor;
                            break;
                        case 'D':
                        case 'd':
                            dec += 13 * factor;
                            break;
                        case 'E':
                        case 'e':
                            dec += 14 * factor;
                            break;
                        case 'F':
                        case 'f':
                            dec += 15 * factor;
                            break;
                        default:
                            MessageBox.Show("geef een correcte waarde in!", "waarschuwing");
                            inputTextBox.Clear();
                            inputTextBox.Focus();
                            break;
                    }
                }
              
            }
            outputTextBox.Text = $"{dec:N0}";

            //int lengteInput = input.Length;
            //string[] subs = input.Split();

            // positie karakter bepaalt de macht. Cijfer x 16^(lengteInput-1) + cijfer x 16^(lengteInput--), ...
            // doen zolang lengteInput >= 0

        }

        private void againButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Clear();
            inputTextBox.Clear();
            inputTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
    }
}