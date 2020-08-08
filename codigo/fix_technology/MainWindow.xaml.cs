using fix_technology.dao;
using System.Windows;

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
        }
    }
}
