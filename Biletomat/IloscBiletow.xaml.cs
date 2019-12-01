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

    static class PojemnikBiletowy
    {
        public static int Ilosc;
        public static double Calosc;
        public static List<string> listaNazw = new List<string>();
        public static List<double> listaCen = new List<double>();
        public static List<int> listaMnoznikow = new List<int>(new int[] { 1, 1, 1, 1, 1 });
    }


    /// <summary>
    /// Interaction logic for IloscBiletow.xaml
    /// </summary>
    public partial class IloscBiletow : Window
    {
        public IloscBiletow()
        {
            InitializeComponent();
            tbTickets.IsEnabled = false;
            tbTickets1.IsEnabled = false;
            tbTickets12.IsEnabled = false;
            tbTickets123.IsEnabled = false;
            tbTickets1234.IsEnabled = false;

            tbPrice.IsEnabled = false;
            tbPrice1.IsEnabled = false;
            tbPrice12.IsEnabled = false;
            tbPrice123.IsEnabled = false;
            tbPrice1234.IsEnabled = false;

            tbNumber.IsEnabled = false;
            tbNumber1.IsEnabled = false;
            tbNumber12.IsEnabled = false;
            tbNumber123.IsEnabled = false;
            tbNumber1234.IsEnabled = false;

            butAdd.IsEnabled = false;
            butAdd1.IsEnabled = false;
            butAdd12.IsEnabled = false;
            butAdd123.IsEnabled = false;
            butAdd1234.IsEnabled = false;

            butSubtract.IsEnabled = false;
            butSubtract1.IsEnabled = false;
            butSubtract12.IsEnabled = false;
            butSubtract123.IsEnabled = false;
            butSubtract1234.IsEnabled = false;

            tbSum.IsEnabled = false;
            tbSum1.IsEnabled = false;
            tbSum12.IsEnabled = false;
            tbSum123.IsEnabled = false;
            tbSum1234.IsEnabled = false;

            int[] teksty = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbNumber.Text = teksty[0].ToString();
            tbNumber1.Text = teksty[1].ToString();
            tbNumber12.Text = teksty[2].ToString();
            tbNumber123.Text = teksty[3].ToString();
            tbNumber1234.Text = teksty[4].ToString();

            labTime.Content = DateTime.Now.ToString();
            //TIMERY DO DATY/ZEGARA
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (PojemnikBiletowy.Ilosc >= 1)
            {
                string[] Nazwy = PojemnikBiletowy.listaNazw.ToArray();
                double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
                int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();

                tbTickets.Text = Nazwy[0];
                tbPrice.Text = Ceny[0].ToString() + " zł";
                butAdd.IsEnabled = true;
                butSubtract.IsEnabled = true;
                tbSum.Text = (Mnozniki[0] * Ceny[0]).ToString() + " zł";
            }
            if (PojemnikBiletowy.Ilosc >= 2)
            {
                string[] Nazwy = PojemnikBiletowy.listaNazw.ToArray();
                double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
                int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();

                tbTickets1.Text = Nazwy[1];
                tbPrice1.Text = Ceny[1].ToString() + " zł";
                butAdd1.IsEnabled = true;
                butSubtract1.IsEnabled = true;
                tbSum1.Text = (Mnozniki[1] * Ceny[1]).ToString() + " zł";
            }
            if (PojemnikBiletowy.Ilosc >= 3)
            {
                string[] Nazwy = PojemnikBiletowy.listaNazw.ToArray();
                double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
                int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();

                tbTickets12.Text = Nazwy[2];
                tbPrice12.Text = Ceny[2].ToString() + " zł";
                butAdd12.IsEnabled = true;
                butSubtract12.IsEnabled = true;
                tbSum12.Text = (Mnozniki[2] * Ceny[2]).ToString() + " zł";
            }
            if (PojemnikBiletowy.Ilosc >= 4)
            {
                string[] Nazwy = PojemnikBiletowy.listaNazw.ToArray();
                double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
                int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();

                tbTickets123.Text = Nazwy[3];
                tbPrice123.Text = Ceny[3].ToString() + " zł";
                butAdd123.IsEnabled = true;
                butSubtract123.IsEnabled = true;
                tbSum123.Text = (Mnozniki[3] * Ceny[3]).ToString() + " zł";
            }
            if (PojemnikBiletowy.Ilosc >= 5)
            {
                string[] Nazwy = PojemnikBiletowy.listaNazw.ToArray();
                double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
                int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();

                tbTickets1234.Text = Nazwy[4];
                tbPrice1234.Text = Ceny[4].ToString() + " zł";
                butAdd1234.IsEnabled = true;
                butSubtract1234.IsEnabled = true;
                tbSum1234.Text = (Mnozniki[4] * Ceny[4]).ToString() + " zł";
            }
            if (Jezyk.EngOrPol == 1)
            {
                butNewTicket.Content = "ADD NEW TICKET";
                butCancel.Content = "CANCEL";
                butPay.Content = "PAY";
                label5.Content = "SUM:";
                label4.Content = "AMOUNT:";
                label22.Content = "CHOSEN TICKETS:";
                label.Content = "Date/hour:";
                label1.Content = "Number of tickets:";
                label2.Content = "Amount to pay:";
                label3.Content = "TICKET PRICE:";
            }
            else
            {
                butNewTicket.Content = "DODAJ NOWY BILET";
                butCancel.Content = "ANULUJ";
                butPay.Content = "ZAPŁAĆ";
                label5.Content = "SUMA:";
                label4.Content = "ILOŚĆ:";
                label22.Content = "WYBRANE BILETY:";
                label.Content = "Data/godzina:";
                label1.Content = "Ilość biletów:";
                label2.Content = "Kwota do zapłaty:";
                label3.Content = "CENA BILETU:";
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            labTime.Content = DateTime.Now.ToString();

            //labNumberAll.Content = PojemnikBiletowy.Ilosc.ToString();
            if (PojemnikBiletowy.Ilosc == 0)
            {
                labNumberAll.Content = PojemnikBiletowy.Ilosc.ToString();
                labPriceAll.Content = PojemnikBiletowy.Calosc.ToString();
            }
            if (PojemnikBiletowy.Ilosc == 1)
            {
                labNumberAll.Content = (Mnozniki[0]).ToString();
                labPriceAll.Content = (Mnozniki[0] * Ceny[0]).ToString() + " zł";
                PojemnikBiletowy.Calosc = Mnozniki[0] * Ceny[0];
            }
            if (PojemnikBiletowy.Ilosc == 2)
            {
                labNumberAll.Content = (Mnozniki[0] + Mnozniki[1]).ToString();
                labPriceAll.Content = (Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1]).ToString() + " zł";
                PojemnikBiletowy.Calosc = Mnozniki[0] * Ceny[0];
            }
            if (PojemnikBiletowy.Ilosc == 3)
            {
                labNumberAll.Content = (Mnozniki[0] + Mnozniki[1] + Mnozniki[2]).ToString();
                labPriceAll.Content = (Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1] + Mnozniki[2] * Ceny[2]).ToString() +" zł";
                PojemnikBiletowy.Calosc = Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1] + Mnozniki[2] * Ceny[2];
            }
            if (PojemnikBiletowy.Ilosc == 4)
            {
                labNumberAll.Content = (Mnozniki[0] + Mnozniki[1] + Mnozniki[2] + Mnozniki[3]).ToString();
                labPriceAll.Content = (Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1] + Mnozniki[2] * Ceny[2] + Mnozniki[3] * Ceny[3]).ToString() + " zł";
                PojemnikBiletowy.Calosc = Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1] + Mnozniki[2] * Ceny[2] + Mnozniki[3] * Ceny[3];
            }
            if (PojemnikBiletowy.Ilosc == 5)
            {
                labNumberAll.Content = (Mnozniki[0] + Mnozniki[1] + Mnozniki[2] + Mnozniki[3] + Mnozniki[4]).ToString();
                labPriceAll.Content = (Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1] + Mnozniki[2] * Ceny[2] + Mnozniki[3] * Ceny[3] + Mnozniki[4] * Ceny[4]).ToString() + " zł";
                PojemnikBiletowy.Calosc = Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1] + Mnozniki[2] * Ceny[2] + Mnozniki[3] * Ceny[3] + Mnozniki[4] * Ceny[4];
            }
        }

        private void butAdd_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Add = new AddingAndSubtracting();
            int max = 10;
            int zmienna = Add.NumericUp(tbNumber, max);

            PojemnikBiletowy.listaMnoznikow.Insert(0, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(1);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum.Text = (Mnozniki[0] * Ceny[0]).ToString() + " zł";

        }


        private void butAdd1_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Add = new AddingAndSubtracting();
            int max = 10;
            int zmienna = Add.NumericUp(tbNumber1, max);

            PojemnikBiletowy.listaMnoznikow.Insert(1, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(2);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum1.Text = (Mnozniki[1] * Ceny[1]).ToString() + " zł";
        }

        private void butAdd12_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Add = new AddingAndSubtracting();
            int max = 10;
            int zmienna = Add.NumericUp(tbNumber12, max);

            PojemnikBiletowy.listaMnoznikow.Insert(2, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(3);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum12.Text = (Mnozniki[2] * Ceny[2]).ToString() + " zł";
        }

        private void butAdd123_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Add = new AddingAndSubtracting();
            int max = 10;
            int zmienna = Add.NumericUp(tbNumber123, max);

            PojemnikBiletowy.listaMnoznikow.Insert(3, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(4);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum123.Text = (Mnozniki[3] * Ceny[3]).ToString() + " zł";
        }

        private void butAdd1234_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Add = new AddingAndSubtracting();
            int max = 10;
            int zmienna = Add.NumericUp(tbNumber1234, max);

            PojemnikBiletowy.listaMnoznikow.Insert(4, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(5);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum1234.Text = (Mnozniki[4] * Ceny[4]).ToString() + " zł";
        }

        private void butSubtract_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Subtrack = new AddingAndSubtracting();
            int zmienna = Subtrack.NumericDown(tbNumber);

            PojemnikBiletowy.listaMnoznikow.Insert(0, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(1);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum.Text = (Mnozniki[0] * Ceny[0]).ToString() + " zł";
        }


        private void butSubtract1_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Subtrack = new AddingAndSubtracting();
            int zmienna = Subtrack.NumericDown(tbNumber1);

            PojemnikBiletowy.listaMnoznikow.Insert(1, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(2);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum1.Text = (Mnozniki[1] * Ceny[1]).ToString() + " zł";
        }

        private void butSubtract12_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Subtrack = new AddingAndSubtracting();
            int zmienna = Subtrack.NumericDown(tbNumber12);

            PojemnikBiletowy.listaMnoznikow.Insert(2, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(3);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum12.Text = (Mnozniki[2] * Ceny[2]).ToString() + " zł";
        }

        private void butSubtract123_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Subtrack = new AddingAndSubtracting();
            int zmienna = Subtrack.NumericDown(tbNumber123);

            PojemnikBiletowy.listaMnoznikow.Insert(3, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(4);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum123.Text = (Mnozniki[3] * Ceny[3]).ToString() + " zł";
        }

        private void butSubtract1234_Click(object sender, RoutedEventArgs e)
        {
            AddingAndSubtracting Subtrack = new AddingAndSubtracting();
            int zmienna = Subtrack.NumericDown(tbNumber1234);

            PojemnikBiletowy.listaMnoznikow.Insert(4, zmienna);
            PojemnikBiletowy.listaMnoznikow.RemoveAt(5);

            double[] Ceny = PojemnikBiletowy.listaCen.ToArray();
            int[] Mnozniki = PojemnikBiletowy.listaMnoznikow.ToArray();
            tbSum1234.Text = (Mnozniki[4] * Ceny[4]).ToString() + " zł";
        }

        private void butNewTicket_Click(object sender, RoutedEventArgs e)
        {
            if(PojemnikBiletowy.Ilosc < 5)
            {
                KolejnyJednorazowy ilosc2dod = new KolejnyJednorazowy();
                ilosc2dod.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Maksymalna liczba możliwych różnych biletów wynosi 5");
            }

        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            //czyszczenie aktualnych
            PojemnikBiletowy.Ilosc = 0;
            PojemnikBiletowy.Calosc = 0;
            PojemnikBiletowy.listaNazw.Clear();
            PojemnikBiletowy.listaCen.Clear();
            PojemnikBiletowy.listaMnoznikow.Clear();
            PojemnikBiletowy.listaMnoznikow = new List<int>(new int[] { 1, 1, 1, 1, 1 });
            //

            MainWindow okno_glowne = new MainWindow();
            okno_glowne.Show();
            this.Close();
        }

        private void butPay_Click(object sender, RoutedEventArgs e)
        {
            //przejście do zaplac 
            KartaGotowka platnosc = new KartaGotowka();
            platnosc.Show();
            this.Close();
        }


    }
}
