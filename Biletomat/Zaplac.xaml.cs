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
    /// Interaction logic for Zaplac.xaml
    /// </summary>
    public partial class Zaplac : Window
    {
        public Zaplac()
        {
            InitializeComponent();

            //blokowanie do zaplaty, zaplacono itp.
            textBox.IsEnabled = false;
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = false;


            labTime.Content = DateTime.Now.ToString();
            //TIMERY DO DATY/ZEGARA
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Start();

            if (Jezyk.EngOrPol == 1)
            {
                label.Content = "Date/hour:";
                label1.Content = "Make a payment";
                label22.Content = "Sum payment";
                label282.Content = "Paid:";
                label292.Content = "To pay:";
                tb1.Text = "Press the button below if you want to receive the confirmation of sale";
                button.Content = "Confirmation";
                ButUndo.Content = "Undo";
            }
            else
            {
                label.Content = "Data/godzina:";
                label1.Content = "Dokonaj płatności";
                label22.Content = "Suma płatności";
                label282.Content = "Pobrano";
                label292.Content = "Do zapłaty:";
                tb1.Text = "Naciśnij poniższy przycisk, jeżeli chcesz otrzymać potwierdzenie sprzedaży";
                button.Content = "Potwierdzenie";
                ButUndo.Content = "Wstecz";
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = PojemnikBiletowy.Calosc + " zł";
            textBox1.Text = "0 zł";
            textBox2.Text = PojemnikBiletowy.Calosc + " zł";
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            labTime.Content = DateTime.Now.ToString();
        }

        private void ButUndo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow okno_glowne = new MainWindow();
            okno_glowne.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Jezyk.EngOrPol == 1)
                button.Content = "SELECTED";
            else
                button.Content = "WYBRANO";
            button.IsEnabled = false;
        }
    }
}
