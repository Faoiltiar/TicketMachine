﻿using System;
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
    /// Interaction logic for Jednorazowe.xaml
    /// </summary>
    public partial class Jednorazowe : Window
    {
        IloscBiletow metro2ilosc = new IloscBiletow();
        Okresowe metro2okresowe = new Okresowe();


        public Jednorazowe()
        {
            InitializeComponent();

            labTime.Content = DateTime.Now.ToString();
            //TIMERY DO DATY/ZEGARA
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0 , 100);
            dispatcherTimer.Start();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Jezyk.EngOrPol == 1)
            {
                tb1.Text = "Standard";
                tb1a.Text = "Standard";
                tb2.Text = "Night, rapid, special and standard";
                tb2a.Text = "Night, rapid, special and standard";
                tb3.Text = "Municipal";
                tb3a.Text = "Municipal";
                tb4.Text = "Rail and municipal of two organizers";
                tb4a.Text = "Rail and municipal of two organizers";
                tb5.Text = "Rail and municipal of all organizers";
                tb5a.Text = "Rail and municipal of all organizers";
                tb6.Text = "Municipal";
                tb6a.Text = "Municipal";
                tb7.Text = "Rail and municipal of all organizers";
                tb7a.Text = "Rail and municipal of all organizers";
                tb8.Text = "Single tickets ZKM Gdynia";
                tb9.Text = "Season tickets (city card)";
                label5.Content = "Reduced";
                label4.Content = "Full price";
                label6.Content = "Single fares";
                label7.Content = "24-hour";
                label8.Content = "72-hour";
                butUndo.Content = "Undo";
                label.Content = "Date/hour:";
                label1.Content = "Number of tickets:";
                label2.Content = "Amount to pay:";
                label3.Content = "Metropolitan tickets MZKZG:";
            }
            else
            {
                tb1.Text = "Zwykły";
                tb1a.Text = "Zwykły";
                tb2.Text = "Nocny, pospieszny, specialny i zwykły";
                tb2a.Text = "Nocny, pospieszny, specialny i zwykły";
                tb3.Text = "Komunalny";
                tb3a.Text = "Komunalny";
                tb4.Text = "Kolejowo-komunalny dwóch organizatorów";
                tb4a.Text = "Kolejowo-komunalny dwóch organizatorów";
                tb5.Text = "Kolejowo-komunalny wszystkich organizatorów";
                tb5a.Text = "Kolejowo-komunalny wszystkich organizatorów";
                tb6.Text = "Komunalny";
                tb6a.Text = "Komunalny";
                tb7.Text = "Kolejowo-komunalny wszystkich organizatorów";
                tb7a.Text = "Kolejowo-komunalny wszystkich organizatorów";
                tb8.Text = "Bilety jednorazowe ZKM w Gdyni";
                tb9.Text = "Bilety okresowe (obsługa karty miejskiej)";
                label5.Content = "Ulgowy";
                label4.Content = "Normalny";
                label6.Content = "Jednoprzejazdowy";
                label7.Content = "24-godzinny";
                label8.Content = "72-godzinny";
                butUndo.Content = "Wstecz";
                label.Content = "Data/godzina:";
                label1.Content = "Ilość biletów:";
                label2.Content = "Kwota do zapłaty:";
                label3.Content = "Bilety metropolitalne MZKZG";
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            labTime.Content = DateTime.Now.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Standard/Single fares/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Zwykly/Jednoprzejazdowy/Normalny");
            PojemnikBiletowy.listaCen.Add(3.4);
            metro2ilosc.Show();
            this.Close();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Special/Single fares/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Specjalny/Jednoprzejazdowy/Normalny");
            PojemnikBiletowy.listaCen.Add(4.4);
            metro2ilosc.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Municipal/24-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Komunalny/24-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(15);
            metro2ilosc.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/2-organizers/24-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/2-organizatorów/24-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(20);
            metro2ilosc.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/All-organizers/24-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Wszystkich-organizatorów/24-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(23);
            metro2ilosc.Show();
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Municipal/72-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Komunalny/72-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(30);
            metro2ilosc.Show();
            this.Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/All-organizers/72-hour/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Wszystkich-organizatorów/72-godzinny/Normalny");
            PojemnikBiletowy.listaCen.Add(46);
            metro2ilosc.Show();
            this.Close();
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Standard/Single fares/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Zwykly/Jednoprzejazdowy/Ulgowy");
            PojemnikBiletowy.listaCen.Add(3.4);
            metro2ilosc.Show();
            this.Close();

        }

        private void button1A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Special/Single fares/Full price");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Specjalny/Jednoprzejazdowy/Ulgowy");
            PojemnikBiletowy.listaCen.Add(4.4);
            metro2ilosc.Show();
            this.Close();
        }

        private void button2A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Municipal/24-hours/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Komunalny/24-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(15);
            metro2ilosc.Show();
            this.Close();
        }

        private void button3A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/2-organizers/24-hours/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/2-organizatorów/24-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(20);
            metro2ilosc.Show();
            this.Close();
        }

        private void button4A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/All-organizers/24-hours/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Wszystkich-organizatorów/24-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(23);
            metro2ilosc.Show();
            this.Close();
        }

        private void button5A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/Municipal/72-hours/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Komunalny/72-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(30);
            metro2ilosc.Show();
            this.Close();
        }

        private void button6A_Click(object sender, RoutedEventArgs e)
        {
            PojemnikBiletowy.Ilosc = 1;
            if (Jezyk.EngOrPol == 1)
                PojemnikBiletowy.listaNazw.Add("Metro/All-organizers/72-hours/Reduced");
            else
                PojemnikBiletowy.listaNazw.Add("Metro/Wszystkich-organizatorów/72-godzinny/Ulgowy");
            PojemnikBiletowy.listaCen.Add(46);
            metro2ilosc.Show();
            this.Close();
        }

        private void buttonAA_Click(object sender, RoutedEventArgs e)
        {
            MainWindow okno_glowne = new MainWindow();
            okno_glowne.Show();
            this.Close();
        }

        private void button1AA_Click(object sender, RoutedEventArgs e)
        {
            metro2okresowe.Show();
            this.Close();
        }

        private void butUndo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow okno_glowne = new MainWindow();
            okno_glowne.Show();
            this.Close();
        }
    }
}
