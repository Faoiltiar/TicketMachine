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
    /// Interaction logic for Gdzie1.xaml
    /// </summary>
    public partial class Gdzie1 : Window
    {
        public Gdzie1()
        {
            InitializeComponent();
            if (Jezyk.EngOrPol == 1)
            {
                tb.Text = "Rumia, Reda & Wejherowo city limits";
                tb1.Text = "Wejherowo municip. & Rumia limits";
            }
            else
            {
                tb.Text = "W granicach Rumi, Redy i miasta Wejherowa";
                tb1.Text = "W granicach Gm. Wejherowo i Rumi";
            }
         }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RodzajNocneOkresoweReda RNO_Reda = new RodzajNocneOkresoweReda();
            RNO_Reda.Show();
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
