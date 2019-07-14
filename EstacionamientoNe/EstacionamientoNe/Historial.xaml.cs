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
using LiveCharts;
using LiveCharts.Wpf;
using System.Net;
using System.IO;
using System.Windows.Threading;
using LiveCharts.Defaults;
using LiveCharts.Configurations;
using System.Threading;
using System.Timers;


namespace EstacionamientoNe
{
    /// <summary>
    /// Lógica de interacción para Historial.xaml
    /// </summary>
    public partial class Historial : Window
    {
        public Historial()
        {
            InitializeComponent();
            
            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);
        }

        private void BtnRegresarMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow menu = new MainWindow();
            menu.ShowDialog();
        }

      
        internal class ConsumoViewModel
        {
            public List<Consumo> Consumo { get; private set; }

            public ConsumoViewModel(Consumo consumo)
            {
                Consumo = new List<Consumo>();
                Consumo.Add(consumo);
            }
        }

        internal class Consumo
        {
            public string Titulo { get; private set; }
            public int Porcentagem { get; private set; }

            public Consumo()
            {
                Titulo = "Consumo Atual";
                Porcentagem = CalcularPorcentagem();
            }

            private int CalcularPorcentagem()
            {
                return 87; //Calculo da porcentagem de consumo
            }
        }





    }



    
}
