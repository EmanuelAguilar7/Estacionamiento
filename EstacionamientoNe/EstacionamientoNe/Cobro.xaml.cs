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

namespace EstacionamientoNe
{
    /// <summary>
    /// Lógica de interacción para Cobro.xaml
    /// </summary>
    public partial class Cobro : Window
    {
        public Cobro()
        {
            InitializeComponent();
        }

        private void BtnRegresarMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow menu = new MainWindow();
            menu.ShowDialog();
        }
    }
}
