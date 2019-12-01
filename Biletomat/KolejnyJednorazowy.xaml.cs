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
    /// Interaction logic for KolejnyJednorazowy.xaml
    /// </summary>
    public partial class KolejnyJednorazowy : Window
    {
        IloscBiletow main2ilosc = new IloscBiletow();
        KolejnyJednorazowyMetro main2metro = new KolejnyJednorazowyMetro();

        public KolejnyJednorazowy()
        {
            InitializeComponent();
            //TIMERY DO DATY/ZEGARA
            labTime.Content = DateTime.Now.ToString();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();

            if (Jezyk.EngOrPol == 1)
            {
                tb1.Text = "Standard";
                tb1a.Text = "Standard";
                tb2.Text = "Night, rapid, special and standard";
                tb2a.Text = "Night, rapid, special and standard";
                tb3.Text = "Standard";
                tb3a.Text = "Standard";
                tb4.Text = "Night, rapid, special and standard";
                tb4a.Text = "Night, rapid, special and standard";
                tb5.Text = "Night, rapid, special and standard";
                tb5a.Text = "Night, rapid, special and standard";
                label5.Content = "Reduced";
                label4.Content = "Full price";
                label6.Content = "Single fares";
                label7.Content = "1-hour";
                label8.Content = "24-hour";
                tb6.Text = "Single metropolitan MZKZG tickets";
                butUndo.Content = "Undo";
                label.Content = "Date/hour:";
                label1.Content = "Number of tickets:";
                label2.Content = "Amount to pay:";
                label3.Content = "Tickets ZKM Gdynia:";
            }
            else
            {
                tb1.Text = "Zwykły";
                tb1a.Text = "Zwykły";
                tb2.Text = "Nocny, pospieszny, specialny i zwykły";
                tb2a.Text = "Nocny, pospieszny, specialny i zwykły";
                tb3.Text = "Zwykły";
                tb3a.Text = "Zwykły";
                tb4.Text = "Nocny, pospieszny, specialny i zwykły";
                tb4a.Text = "Nocny, pospieszny, specialny i zwykły";
                tb5.Text = "Nocny, pospieszny, specialny i zwykły";
                tb5a.Text = "Nocny, pospieszny, specialny i zwykły";
                label5.Content = "Ulgowy";
                label4.Content = "Normalny";
                label6.Content = "Jednoprzejazdowy";
                label7.Content = "1-godzinny";
                label8.Content = "24-godzinny";
                tb6.Text = "Bilety jednorazowe metropolitalne MZKZG";
                butUndo.Content = "Wstecz";
                label.Content = "Data/godzina:";
                label1.Content = "Ilość biletów:";
                label2.Content = "Kwota do zapłaty:";
                label3.Content = "Bilety ZKM w Gdyni:";
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
                labPriceAll.Content = (Mnozniki[0] * Ceny[0] + Mnozniki[1] * Ceny[1] + Mnozniki[2] * Ceny[2]).ToString() + " zł";
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Standard/Single fares/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Zwykly/Jednoprzejazdowy/Normalny");
            PojemnikBiletowy.listaCen.Add(3.2);
            main2ilosc.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Special/Single fares/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Specjalny/Jednoprzejazdowy/Normalny");
            PojemnikBiletowy.listaCen.Add(4.2);
            main2ilosc.Show();
            this.Close();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Standard/1-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Zwykly/1-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(3.8);
            main2ilosc.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Special/1-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Specjalny/1-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(4.8);
            main2ilosc.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Special/24-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Specjalny/24-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(13);
            main2ilosc.Show();
            this.Close();
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Standard/Single fares/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Zwykly/Jednoprzejazdowy/Ulgowy");
            PojemnikBiletowy.listaCen.Add(1.6);
            main2ilosc.Show();
            this.Close();
        }

        private void button1A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Special/Single fares/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Specjalny/Jednoprzejazdowy/Ulgowy");
            PojemnikBiletowy.listaCen.Add(2.1);
            main2ilosc.Show();
            this.Close();
        }

        private void button2A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Standard/1-hour/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Zwykly/1-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(1.9);
            main2ilosc.Show();
            this.Close();
        }

        private void button3A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Special/1-hour/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Specjalny/1-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(2.4);
            main2ilosc.Show();
            this.Close();
        }

        private void button4A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc += 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Special/24-hour/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Specjalny/24-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(6.5);
            main2ilosc.Show();
            this.Close();
        }

        private void buttonAA_Click(object sender, RoutedEventArgs e)
        {
            main2metro.Show();
            this.Close();
        }

        private void butUndo_Click(object sender, RoutedEventArgs e)
        {
            main2ilosc.Show();
            this.Close();
        }
    }
}
