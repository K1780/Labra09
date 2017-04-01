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

namespace Teht03
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

        private void btnLaske_Click(object sender, RoutedEventArgs e)
        {
            //määritetään
            int korkeus;
            int leveys;
            int karmi;
            //otetaan luvut inputeilta
            bool leveysParse = int.TryParse(txtLeveys.Text, out leveys);
            if (!leveysParse)
            {
                txtLeveys.Text = "Invalid input";
            }
            bool korkeusParse = int.TryParse(txtKorkeus.Text, out korkeus);
            if (!korkeusParse)
            {
                txtKorkeus.Text = "Invalid input";
            }
            bool karmiParse = int.TryParse(txtKarmi.Text, out karmi);
            if (!karmiParse)
            {
                txtKarmi.Text = "Invalid input";
            }
            if (leveysParse && korkeusParse && karmiParse)
            {
                //lasketaan ikkunan pinta-ala, eli lasin leveys + 2karmi * lasin korkeus + 2karmi
                txtIkkunanPintaAla.Text = ((leveys * korkeus) / 10).ToString() + " cm^2";
                //lasketaan lasin pinta-ala
                txtLasinPintaAla.Text = (((leveys - 2 * (karmi)) * (korkeus - 2 * (karmi))) / 10).ToString() + " cm^2";
                //lasketaan karmin piiri, eli 2*(leveys+2karmi)+2*(korkeus+2karmi)
                txtKarminPiiri.Text = (((2 * leveys) + (2 * korkeus)) / 10).ToString() + " cm";
            }

        }
    }
}