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
using System.Windows.Threading;

namespace EstacionamientoNe
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {

        public Home()
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

        private void BtnRegresarMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }
    }
}
