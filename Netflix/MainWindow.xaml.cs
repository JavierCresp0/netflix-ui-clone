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

namespace Netflix
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMyInterface
    {
       


        public MainWindow()
        {
            InitializeComponent();
            
            boton1.Visibility = Visibility.Hidden;
            boton2.Visibility = Visibility.Hidden;
            //marco1.Content = new Principal();

        }

        public Frame Getcontenedor()
        {
            marco1.Content = new Principal();
            return marco1;
        }

        public ContentControl GetContentControl()
        {
            controlContenido.Content = new Principal();
            return controlContenido;


        }

        public void SetVisibility(Visibility value)
        {
           
            boton1.Visibility = value;
            boton2.Visibility = value;
           
        }

        private void cargarPelicula1(object sender, RoutedEventArgs e)
        {
            // marco1.Content = new pelicula1();
            marco1.Visibility = Visibility.Collapsed;
            controlContenido.Visibility = Visibility.Visible;
            controlContenido.Content = new UCpelicula1();
            
        }

        private void cargarPelicula2(object sender, RoutedEventArgs e)
        {
            controlContenido.Visibility = Visibility.Collapsed;
            marco1.Visibility = Visibility.Visible;
            marco1.Content = new pelicula2();
        }

        private void verPrincipal(object sender, RoutedEventArgs e)
        {
            marco1.Visibility = Visibility.Visible;
            marco1.Content= new Principal();
            controlContenido.Visibility = Visibility.Collapsed;
        }
    }
}
