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
using System.Data.SqlClient;
using System.Data;

namespace EstacionamientoNe
{
    /// <summary>
    /// Lógica de interacción para Historial.xaml
    /// </summary>
    public partial class Historial : Window
    {
        SqlConnection sqlconnection;
        public Historial()
        {
            InitializeComponent();
            string connectionString = @"server=DESKTOP-M6GR8FE\SQLEXPRESS02;Initial Catalog=Estacionamiento;Integrated Security=True";
            sqlconnection = new SqlConnection(connectionString);

            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);

            Mostrar();
            
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
                Titulo = "Disponibilidad Actual";
                Porcentagem = CalcularPorcentagem();
            }

            private int CalcularPorcentagem()
            {
                
                return 87; 
            }
        }
        
        private void Mostrar()
        {
            try
            {
                string query = "SELECT * FROM Vehiculo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlconnection);

                using (sqlDataAdapter)
                {
                    DataTable tablaVehi = new DataTable();
                    sqlDataAdapter.Fill(tablaVehi);

                    llenar.DisplayMemberPath = "Num_Placa";
                    llenar.DisplayMemberPath = "Hora_Ingreso";
                    llenar.DisplayMemberPath = "Tipo_Vehiculo";
                    llenar.SelectedValuePath = "Num_Placa";
                    llenar.ItemsSource = tablaVehi.DefaultView;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }



    
}
