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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Examen2Parcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlconnection;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Examen2Parcial.Properties.Settings.ERPConnectionString"].ConnectionString;
            sqlconnection = new SqlConnection(connectionString);
        }

        private void BtnCrearUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRemoverUsuario_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
