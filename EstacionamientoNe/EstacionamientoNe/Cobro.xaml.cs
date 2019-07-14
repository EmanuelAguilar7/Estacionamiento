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

namespace EstacionamientoNe
{
    /// <summary>
    /// Lógica de interacción para Cobro.xaml
    /// </summary>
    public partial class Cobro : Window
    {
        SqlConnection sqlconnection;
        public Cobro()
        {
            InitializeComponent();

            string connectionString = @"server=DESKTOP-M6GR8FE\SQLEXPRESS02;Initial Catalog=Estacionamiento;Integrated Security=True";
            sqlconnection = new SqlConnection(connectionString);

            Mostrar();
        }

        private void BtnRegresarMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow menu = new MainWindow();
            menu.ShowDialog();
        }

        private void Mostrar()
        {
            try
            {
                
                string query = "SELECT * FROM Vehiculo";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlconnection);

                using (sqlDataAdapter)
                {

                    DataTable tablaUsuario = new DataTable();


                    sqlDataAdapter.Fill(tablaUsuario);

                    dgbuscar.DisplayMemberPath = "Num_Placa";
                    dgbuscar.DisplayMemberPath = "Hora_Ingreso";
                    dgbuscar.DisplayMemberPath = "Tipo_Vehiculo";
                    dgbuscar.SelectedValuePath = "Num_Placa";
                    dgbuscar.ItemsSource = tablaUsuario.DefaultView;
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
                string query = "SELECT * FROM Vehiculo WHERE Num_Placa = @placa ";


             
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

             
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
             
                    sqlCommand.Parameters.AddWithValue("@placa", txtbuscar.Text);

                    
                    DataTable tablaVehi = new DataTable();

                    
                    sqlDataAdapter.Fill(tablaVehi);

                    
                    dgbuscar.DisplayMemberPath = "Num_Placa";
                    dgbuscar.DisplayMemberPath = "Hora_Ingreso";
                    dgbuscar.DisplayMemberPath = "Tipo_Vehiculo";
                    dgbuscar.SelectedValuePath = "Num_Placa";
                    dgbuscar.ItemsSource = tablaVehi.DefaultView;
                }
                txtbuscar.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Vehiculo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlconnection);

                using (sqlDataAdapter)
                {
                    DataTable tablaVehi = new DataTable();
                    sqlDataAdapter.Fill(tablaVehi);

                    dgbuscar.DisplayMemberPath = "Num_Placa";
                    dgbuscar.DisplayMemberPath = "Hora_Ingreso";
                    dgbuscar.DisplayMemberPath = "Tipo_Vehiculo";
                    dgbuscar.SelectedValuePath = "Num_Placa";
                    dgbuscar.ItemsSource = tablaVehi.DefaultView;
                }

                txtbuscar.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btnretirar_Click(object sender, RoutedEventArgs e)
        {
            if (txtbuscar.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el numero de placa.");
                txtbuscar.Focus();
            }
            else
            {
                try
                {
                    string query = "UPDATE Vehiculo SET Hora_Salida = GETDATE() WHERE Num_Placa = @placa";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);



                    sqlconnection.Open();

                    sqlCommand.Parameters.AddWithValue("@placa", txtbuscar.Text);
                    sqlCommand.ExecuteNonQuery();

                    txtbuscar.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    sqlconnection.Close();
                    Mostrar();
                }
            }
        }

        


    }
}
