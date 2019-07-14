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
using System.Windows.Threading;

namespace EstacionamientoNe
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startclock();

        }


        private void startclock()
        {
            DispatcherTimer d = new DispatcherTimer();
            d.Interval = TimeSpan.FromSeconds(1);
            d.Tick += tickevent;
            d.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            if(Opciones.Width==200)
            {
                Opciones.Width = 70;
            }
            else
            {
                Opciones.Width = 200;
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Home h = new Home();
            h.Owner = this;
            h.Show();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Precios p = new Precios();
            p.Owner = this;
            p.Show();
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Cobro cobro = new Cobro();
            cobro.Owner = this;
            cobro.Show();
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Historial his = new Historial();
            his.Owner = this;
            his.Show();
        }
    }
}
