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
using System.Windows.Shapes;

namespace Biletomat
{
    /// <summary>
    /// Interaction logic for Gdzie.xaml
    /// </summary>
    public partial class Gdzie : Window
    {
        public Gdzie()
        {
            InitializeComponent();
            if (Jezyk.EngOrPol == 1)
            {
                button.Content = "Sopot";
                button1.Content = "Rumia";
                button2.Content = "Kosakowo municip";
                button3.Content = "Żukowo municip";
                button4.Content = "Szemud municip";
                button5.Content = "Wejherowe municip";
            }
            else
            {
                button.Content = "Sopot";
                button1.Content = "Rumia";
                button2.Content = "Gm. Kosakowo";
                button3.Content = "Gm. Żukowo";
                button4.Content = "Gm. Szemud";
                button5.Content = "Gm. Wejherowe";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            RodzajNocneOkresoweSopot RNO_Sopot = new RodzajNocneOkresoweSopot();
            RNO_Sopot.Show();
            this.Close();
        }

        private void butUndo_Click(object sender, RoutedEventArgs e)
        {
            Okresowe okresowe = new Okresowe();
            okresowe.Show();
            this.Close();
        }
    }
}
