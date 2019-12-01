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
    /// Interaction logic for RodzajNocneOkresoweReda.xaml
    /// </summary>
    public partial class RodzajNocneOkresoweReda : Window
    {
        KartaGotowka RNO_Reda2platnosc = new KartaGotowka();

        public RodzajNocneOkresoweReda()
        {
            InitializeComponent();
            labTime.Content = DateTime.Now.ToString();
            //TIMERY DO DATY/ZEGARA
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Start();

            if (Jezyk.EngOrPol == 1)
            {
                tb1.Text = "4-monthly valid 7 days a week 01.10-31.01 or 01.02-31.05";
                tb2.Text = "5-monthly valid 7 days a week 1.09-31.01 or 01.02-30.06";
                tb3.Text = "Full price personal ticket valid monday to friday";
                tb4.Text = "Reduced personal ticket valid monday to friday";
                tb5.Text = "Full price personal ticket valid on all weekdays";
                tb6.Text = "Reduced personal ticket valid on all weekdays";
                tb7.Text = "Full price ticket to bearer valid on all weekdays";
                label.Content = "Date/hour:";
                label1.Content = "Card number:";
                label2.Content = "Card type:";
                label5.Content = "Semestral tickets:";
                label6.Content = "Monthly or 30-day tickets:";
                //nie ma wczytanej karty = bilet papierowy
                labNumerNULL.Content = "Paper ticket";
                labTypeNULL.Content = "Not selected";
                butUndo.Content = "Undo";
            }
            else
            {
                tb1.Text = "4-miesięczny ważny we wszystkie dni tygodnia 01.10-31.01 lub 01.02-31.05";
                tb2.Text = "5-miesięczny ważny we wszystkie dni tygodnia 01.09-31.01 lub 01.02-30.06";
                tb3.Text = "Imienny ważny od poniedziałku do piątku normalny";
                tb4.Text = "Imienny ważny od poniedziałku do piątku ulgowy";
                tb5.Text = "Imienny ważny we wszystkie dni tygodnia normalny";
                tb6.Text = "Imienny ważny we wszystkie dni tygodnia ulgowy";
                tb7.Text = "Na okaziciela ważny we wszystkie dni tygodnia normalny";
                label.Content = "Data/godzina:";
                label1.Content = "Numer karty:";
                label2.Content = "Typ karty:";
                label5.Content = "Bilety semestralne:";
                label6.Content = "Bilety miesięczne albo 30-dniowe";
                //nie ma wczytanej karty = bilet papierowy
                labNumerNULL.Content = "Bilet papierowy";
                labTypeNULL.Content = "Nie wybrano";
                butUndo.Content = "Wstecz";
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            labTime.Content = DateTime.Now.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 160;

            RNO_Reda2platnosc.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 74;

            RNO_Reda2platnosc.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 84;

            RNO_Reda2platnosc.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 97;

            RNO_Reda2platnosc.Show();
            this.Close();
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 200;

            RNO_Reda2platnosc.Show();
            this.Close();
        }

        private void button1A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 37;

            RNO_Reda2platnosc.Show();
            this.Close();
        }

        private void button2A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 42;

            RNO_Reda2platnosc.Show();
            this.Close();
        }

        private void butUndo_Click(object sender, RoutedEventArgs e)
        {
            Okresowe powrot = new Okresowe();
            powrot.Show();
            this.Close();
        }
    }
}
