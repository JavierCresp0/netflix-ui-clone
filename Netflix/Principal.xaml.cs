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
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Page, IMyInterface
    {
        public Principal()
        {
            InitializeComponent();
            SetVisibility(Visibility.Visible);
            mediaPlayer.UnloadedBehavior = MediaState.Manual;
            mediaPlayer.LoadedBehavior = MediaState.Manual;

            // Demo: requiere archivo de vídeo local en la ruta \video\ del proyecto.
            // mediaPlayer.Source = new Uri(Environment.CurrentDirectory + @"\video\Kimetsu Tengen Tanjiro.mp4", UriKind.RelativeOrAbsolute);
        }

        public void SetVisibility(Visibility value)
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                IMyInterface interfaz = (IMyInterface)Application.Current.MainWindow;
                

                

                if (interfaz != null)
                {
                    interfaz.SetVisibility(Visibility.Visible);
                    
                }
            }));
        }

        private void verPelicula1(object sender, RoutedEventArgs e)
        {
            SetVisibility(Visibility.Visible);

        }

        private void playMedia(object sender, RoutedEventArgs e)
        {
           
            mediaPlayer.Play();
        }

        private void stopMedia(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void pausarVideo(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }
    }
}
