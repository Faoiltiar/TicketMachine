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
    /// Interaction logic for Okresowe.xaml
    /// </summary>
    public partial class Okresowe : Window
    {  

        public Okresowe()
        {
            InitializeComponent();
            labTime.Content = DateTime.Now.ToString();
            //TIMERY DO DATY/ZEGARA
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();

            
            
            
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            labTime.Content = DateTime.Now.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RodzajZwyklyOkresowe RZO_Okresowe = new RodzajZwyklyOkresowe();
            RZO_Okresowe.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Gdzie gdzie = new Gdzie();
            gdzie.Show();
            //RodzajNocneOkresoweSopot RNO_Sopot = new RodzajNocneOkresoweSopot();
            //RNO_Sopot.Show();
            this.Close();
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            RodzajNocneOkresoweSiecKom RNO_Sieciowe = new RodzajNocneOkresoweSiecKom();
            RNO_Sieciowe.Show();
            this.Close();
        }

        private void buttonAA_Click(object sender, RoutedEventArgs e)
        {
            
            RodzajNocneOkresoweGdynia RNO_Gdynia = new RodzajNocneOkresoweGdynia();
            RNO_Gdynia.Show();
            this.Close();
        }

        private void button1AA_Click(object sender, RoutedEventArgs e)
        {
            Gdzie1 gdzie1 = new Gdzie1();
            gdzie1.Show();
            //RodzajNocneOkresoweReda RNO_Reda = new RodzajNocneOkresoweReda();
            //RNO_Reda.Show();
            this.Close();
        }

        private void butUndo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow okno_glowne = new MainWindow();
            okno_glowne.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Jezyk.EngOrPol == 1)
            {
                tb1.Text = "Standard within Gdynia city limits";
                tb2.Text = "Night, rapid and standard within Gdynia city limits";
                tb3.Text = "Night, rapid and standardwithin Sopot or Rumia city limitsor Kosakowo muni. or Żukowo muni. or Szemud muni. or Wejherowo muni.";
                tb4.Text = "Night, rapid and standard Rumia, Reda & Wejherowo city limits or Wejherowo municip. & Rumia";
                tb5.Text = "Night, rapid and standard within public transport network [including routes G, N1, 101 i 171]";
                label.Content = "Date/hour:";
                label1.Content = "Card number:";
                label2.Content = "Card type:";
                label3.Content = "Bus route type:";
                label4.Content = "Previously bought ticket";
                //nie ma wczytanej karty = bilet papierowy
                labNumerNULL.Content = "Paper ticket";
                labTypeNULL.Content = "Not selected";
                label5.Content = "No data";
            }
            else
            {
                tb1.Text = "Zwykłe w granicach Gdyni";
                tb2.Text = "Nocne, pospieszne i zwykłe w granicach Gdyn";
                tb3.Text = "Nocne, pospieszne i zwykłe w granicach Sopotu albo Rumii albo Gm.Kosakowo albo Gm.Żukow albo Gm.Szemud albo Gm.Wejherowo";
                tb4.Text = "Nocne, pospieszne i zwykłe w granicach Rumi, Redy i miasta Wejherowa albo Gm. Wejherowo i Rumi";
                tb5.Text = "Nocne, pospieszne i zwykłe w obrębie sieci komunikacyjnej [w tym linie G, N1, 101 i 171]";
                label.Content = "Data/godzina:";
                label1.Content = "Numer karty:";
                label2.Content = "Typ karty:";
                label3.Content = "Rodzaj lini:";
                label4.Content = "Ostatnio kupiony bilet";
                //nie ma wczytanej karty = bilet papierowy
                labNumerNULL.Content = "Bilet papierowy";
                labTypeNULL.Content = "Nie wybrano";
                label5.Content = "Brak Danych";

            }
        }
    }
}
