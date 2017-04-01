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

namespace Teht02
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

        private void btnEuro_Click(object sender, RoutedEventArgs e)
        {
            //muunna eurot doubleksi
            double eurot = 0;
            bool success = double.TryParse(txtEuroIO.Text, out eurot);
            if (!success)
            {
                txtEuroIO.Text = "Invalid input..";
            }
            //muunna eurot markoiksi
            double markat = Math.Round((eurot * 5.95), 2);
            //laita markat markkaboxiin
            txtMarkkaIO.Text = markat.ToString();
        }

        private void btnMarkka_Click(object sender, RoutedEventArgs e)
        {
            //muunna markat doubleksi
            double markat = 0;
            bool success = double.TryParse(txtMarkkaIO.Text, out markat);
            if (!success)
            {
                txtMarkkaIO.Text = "Invalid input..";
            }
            //muunna eurot markoiksi
            double eurot = Math.Round((markat / 5.95), 2);
            //laita markat markkaboxiin
            txtEuroIO.Text = eurot.ToString();
        }
    }
}