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

namespace пр10
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

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGeneration_Click(object sender, RoutedEventArgs e)
        {
            int numberOfElements;

            if(int.TryParse(tbKolvoZnacheniy.Text, out numberOfElements) && numberOfElements > 0)
            {
                Random random = new Random();
                List<int> mas = new List<int>(); // Используем коллекцию List<int> для хранения значений

                for (int i = 0; i < numberOfElements; i++)
                {
                    mas.Add(random.Next(0, 11));

                }

                string a = " ";
                for (int i = 0; i < numberOfElements; i++)
                {
                    a += mas[i].ToString();
                    if (i < numberOfElements - 1)
                    {
                        a += ", ";
                    }
                }
                tbMassiv.Text = a;
            }
            tbCount5.Clear();
            tbCount7.Clear();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int countFive = tbMassiv.Text.Count(c => c == '5');
            int countSeven = tbMassiv.Text.Count(c => c == '7');

            // Отображаем результаты
            tbCount5.Text = countFive.ToString();
            tbCount7.Text = countSeven.ToString();
        }
    }
}