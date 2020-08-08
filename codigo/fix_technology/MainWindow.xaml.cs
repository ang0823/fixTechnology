using fix_technology.dao;
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

namespace fix_technology
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConexionDb conexion = new ConexionDb();
        public MainWindow()
        {
            InitializeComponent();
            abrirConexion();
        }

        private void abrirConexion()
        {
            bool dbCconectada = conexion.abrir();
            if (dbCconectada)
            {
                Answer.Content = "Se conecto a la base de datos\n\n";
            }
            else
            {
                Answer.Content = "No se conecto a la base de datos. Ver resultado en consola.\n\n";
            }

            bool dbCerrada = conexion.cerrar();

            if (dbCerrada)
            {
                Answer2.Content = "Se desconecto la base de datos\n\n";
            }
            else
            {
                Answer.Content = "No se desconecto la base de datos. Ver resultado en consola.\n\n";
            }
        }
    }
}
