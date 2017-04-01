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

namespace Labra09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int CarsCount = 0;
        public int TrucksCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // add 1 to TrucksCount 
            TrucksCount++;
            // show output to output1
            trucksTextBlock.Text = "Trucks " + TrucksCount;


        }

        private void carsButton_Click(object sender, RoutedEventArgs e)
        {
            // add 1 to CarsCount
            CarsCount++;
            // Show output
            carsTextBlock.Text = "Cars " + CarsCount;

        }
    }
}
