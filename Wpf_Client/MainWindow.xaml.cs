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
using Wpf_Client.ServiceCalculate;

namespace Wpf_Client
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b, c;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceCalculateClient client = new ServiceCalculateClient();
            double result = client.Calculate(a, b, c);
            Value_Result.Content = result;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CalculateValue calculateValue = new CalculateValue();
            c = Convert.ToDouble(value_c.Text);

            calculateValue.A = c;
            calculateValue.B = calculateValue.A;

            a = calculateValue.A;
            b = calculateValue.B;

            value_b.Content = calculateValue.B;
            value_a.Content = calculateValue.A;
        }
    }
}
