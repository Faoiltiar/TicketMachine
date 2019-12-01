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
    /// Interaction logic for KartaGotowka.xaml
    /// </summary>
    public partial class KartaGotowka : Window
    {
        Zaplac payment = new Zaplac();

        public TextBlock textblock_create(string napis, int fontsize, FontWeight pogrubienie, Color kolor, VerticalAlignment pion, int which_row, int which_column) //dynamiczne tworzenie texboxa
        {
            TextBlock textblock = new TextBlock();
            textblock.Text = napis;
            textblock.FontSize = fontsize;
            textblock.FontWeight = pogrubienie;
            textblock.Foreground = new SolidColorBrush(kolor);
            textblock.VerticalAlignment = pion;
            Grid.SetColumnSpan(textblock, 7);
            Grid.SetRow(textblock, which_row);
            Grid.SetColumn(textblock, which_column);
            return textblock;
        }

        public KartaGotowka()
        {
            InitializeComponent();
            labTime.Content = DateTime.Now.ToString();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
            if (Jezyk.EngOrPol == 1)
            {
                ButGotowka.Content = "CASH";
                ButKarta.Content = "PAYMENT CARD";
                label.Content = "Date/hour:";
                label1.Content = "Make a payment";
            }
            else
            {
                ButGotowka.Content = "GOTÓWKA";
                ButKarta.Content = "KARTA PŁATNICZA";
                label.Content = "Data/godzina:";
                label1.Content = "Dokonaj płatności";
                
            }
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            labTime.Content = DateTime.Now.ToString();
        }
        private void ButKarta_Click(object sender, RoutedEventArgs e)
        {
            Zaplac okno_platnosci = new Zaplac();
            if (Jezyk.EngOrPol == 1)
            {
                TextBlock blok = textblock_create("APPLY YOUR PAYMENT CARD TO THE CARD READER", 30, FontWeights.Bold, Colors.Black, VerticalAlignment.Center, 6, 2);
                okno_platnosci.GridPlatnosci.Children.Add(blok);
            }
            else
            {
                TextBlock blok = textblock_create("PRZYŁÓŻ KARTĘ PŁATNICZĄ DO CZYTNIKA", 30, FontWeights.Bold, Colors.Black, VerticalAlignment.Center, 6, 2);
                okno_platnosci.GridPlatnosci.Children.Add(blok);
            }
            
            okno_platnosci.Show();
            this.Close();
        }

        private void ButGotowka_Click(object sender, RoutedEventArgs e)
        {
            Zaplac okno_platnosci = new Zaplac();
            if (Jezyk.EngOrPol == 1)
            {
                TextBlock blok = textblock_create("TICKET MACHINE ACCEPTS BANKNOTES AND COINS", 30, FontWeights.Bold, Colors.Black, VerticalAlignment.Center, 6, 2);
                TextBlock blok2 = textblock_create("IT IS ALSO GIVING THE CHANGE", 30, FontWeights.Bold, Colors.Black, VerticalAlignment.Center, 7, 2);
                okno_platnosci.GridPlatnosci.Children.Add(blok);
                okno_platnosci.GridPlatnosci.Children.Add(blok2);
            }
            else
            {
                TextBlock blok = textblock_create("BILETOMAT PRZYJMUJE BANKONOTY MONETY", 30, FontWeights.Bold, Colors.Black, VerticalAlignment.Center, 6, 2);
                TextBlock blok2 = textblock_create("WYDAJE TAKŻE RESZTĘ", 30, FontWeights.Bold, Colors.Black, VerticalAlignment.Center, 7, 2);
                okno_platnosci.GridPlatnosci.Children.Add(blok);
                okno_platnosci.GridPlatnosci.Children.Add(blok2);
            }
            okno_platnosci.Show();
            this.Close();
        }
    }
}
