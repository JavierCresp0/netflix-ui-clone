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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica_2
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();


            //////////////////////////// Dune 2
            play.Visibility = Visibility.Hidden;
            pause.Visibility = Visibility.Hidden;
            stop.Visibility = Visibility.Hidden;
            VolumeSlider.Visibility = Visibility.Hidden;



            MEdaredevil.UnloadedBehavior = MediaState.Manual;
            MEdaredevil.LoadedBehavior = MediaState.Manual;

            // string videoStr = Environment.CurrentDirectory + @"\video\Daredevil.mp4";
            // MEdaredevil.Source = new Uri(Environment.CurrentDirectory + @"\video\Daredevil.mp4", UriKind.RelativeOrAbsolute);
            string videoStr = Environment.CurrentDirectory + @"\Videos\Dune2.mp4";
            MEdaredevil.Source = new Uri(Environment.CurrentDirectory + @"\Videos\Dune2.mp4", UriKind.RelativeOrAbsolute);

            ///////////////////////////////Arcane
            play2.Visibility = Visibility.Hidden;
            pause2.Visibility = Visibility.Hidden;
            stop2.Visibility = Visibility.Hidden;
            VolumeSlider2.Visibility = Visibility.Hidden;

            MEdaredevil2.UnloadedBehavior = MediaState.Manual;
            MEdaredevil2.LoadedBehavior = MediaState.Manual;

            // string videoStr = Environment.CurrentDirectory + @"\video\Daredevil.mp4";
            // MEdaredevil.Source = new Uri(Environment.CurrentDirectory + @"\video\Daredevil.mp4", UriKind.RelativeOrAbsolute);
            string videoStr2 = Environment.CurrentDirectory + @"\Videos\arcane.mp4";
            MEdaredevil2.Source = new Uri(Environment.CurrentDirectory + @"\Videos\arcane.mp4", UriKind.RelativeOrAbsolute);

            ////////////////////////////////Gladiator
            play3.Visibility = Visibility.Hidden;
            pause3.Visibility = Visibility.Hidden;
            stop3.Visibility = Visibility.Hidden;
            VolumeSlider3.Visibility = Visibility.Hidden;

            MEdaredevil3.UnloadedBehavior = MediaState.Manual;
            MEdaredevil3.LoadedBehavior = MediaState.Manual;

            // string videoStr = Environment.CurrentDirectory + @"\video\Daredevil.mp4";
            // MEdaredevil.Source = new Uri(Environment.CurrentDirectory + @"\video\Daredevil.mp4", UriKind.RelativeOrAbsolute);
            string videoStr3 = Environment.CurrentDirectory + @"\Videos\Gladiator.mp4";
            MEdaredevil3.Source = new Uri(Environment.CurrentDirectory + @"\Videos\Gladiator.mp4", UriKind.RelativeOrAbsolute);
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Storyboard nombreVariable;
            nombreVariable = (Storyboard)this.Resources["StoryMenu"];
            nombreVariable.Begin();


        }



        private void Click2(object sender, RoutedEventArgs e)
        {
            Storyboard nombreVariable;
            nombreVariable = (Storyboard)this.Resources["StoryMenuInv2"];
            nombreVariable.Begin();
        }


        private void playDaredevil(object sender, RoutedEventArgs e)
        {

            MEdaredevil.Play();
        }

        private void stopDaredevil(object sender, RoutedEventArgs e)
        {
            MEdaredevil.Stop();
        }

        private void pausarVideo(object sender, RoutedEventArgs e)
        {
            MEdaredevil.Pause();
        }


        private void show(object sender, RoutedEventArgs e)
        {
            play.Visibility = Visibility.Visible;
            pause.Visibility = Visibility.Visible;
            stop.Visibility = Visibility.Visible;
            VolumeSlider.Visibility = Visibility.Visible;
            Dune.Visibility = Visibility.Hidden;
            Arcane.Visibility = Visibility.Hidden;
            Gladiator.Visibility = Visibility.Hidden;
            MEdaredevil.Play();
            MainGrid.Background = null;


        }

        private void show2(object sender, RoutedEventArgs e)
        {
            play2.Visibility = Visibility.Visible;
            pause2.Visibility = Visibility.Visible;
            stop2.Visibility = Visibility.Visible;
            VolumeSlider2.Visibility = Visibility.Visible;
            Dune.Visibility = Visibility.Hidden;
            Arcane.Visibility = Visibility.Hidden;
            Gladiator.Visibility = Visibility.Hidden;
            MEdaredevil2.Play();
            MainGrid.Background = null;


        }

        private void show3(object sender, RoutedEventArgs e)
        {
            play3.Visibility = Visibility.Visible;
            pause3.Visibility = Visibility.Visible;
            stop3.Visibility = Visibility.Visible;
            VolumeSlider3.Visibility = Visibility.Visible;
            Dune.Visibility = Visibility.Hidden;
            Arcane.Visibility = Visibility.Hidden;
            Gladiator.Visibility = Visibility.Hidden;
            MEdaredevil3.Play();
            MainGrid.Background = null;


        }


        private void playDaredevil2(object sender, RoutedEventArgs e)
        {

            MEdaredevil2.Play();
        }

        private void stopDaredevil2(object sender, RoutedEventArgs e)
        {
            MEdaredevil2.Stop();
        }

        private void pausarVideo2(object sender, RoutedEventArgs e)
        {
            MEdaredevil2.Pause();
        }



        private void playDaredevil3(object sender, RoutedEventArgs e)
        {

            MEdaredevil3.Play();
        }

        private void stopDaredevil3(object sender, RoutedEventArgs e)
        {
            MEdaredevil3.Stop();
        }

        private void pausarVideo3(object sender, RoutedEventArgs e)
        {
            MEdaredevil3.Pause();
        }



        private void LogIn(object sender, RoutedEventArgs e)
        {

            //this.Close();
            Window Log = new log();
            Log.Show();
        }


    }
}

