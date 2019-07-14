using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection sqlconnection;
        public Home()
        {
            InitializeComponent();

            string connectionString = @"server=DESKTOP-M6GR8FE\SQLEXPRESS02;Initial Catalog=Estacionamiento;Integrated Security=True";
            sqlconnection = new SqlConnection(connectionString);

            MostrarTipoVehiculo();
        }

        private void BtnRegresarMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }


        private void MostrarTipoVehiculo()
        {
            try
            {
                string query = "SELECT * FROM Tipo_Vehiculo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlconnection);

                using (sqlDataAdapter)
                {
                    DataTable tablaVehi = new DataTable();
                    sqlDataAdapter.Fill(tablaVehi);

                    txtvehi.DisplayMemberPath = "Tipo";
                    txtvehi.SelectedValuePath = "Id";
                    txtvehi.ItemsSource = tablaVehi.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "INSERT INTO Vehiculo(Num_Placa,Tipo_Vehiculo) VALUES(@placa,@vehiculo)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);


                sqlconnection.Open();

                

                sqlCommand.Parameters.AddWithValue("@placa", placanum.Text);
                sqlCommand.Parameters.AddWithValue("@vehiculo", txtvehi.SelectedValue);
                sqlCommand.ExecuteNonQuery();


                placanum.Text = String.Empty;

                MessageBox.Show("Guardado Exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este numero de placa ya existe");
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        
    }
}
