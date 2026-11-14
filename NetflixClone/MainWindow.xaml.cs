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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BReturn.Visibility = Visibility.Hidden;

        }

        private void Click(object sender, RoutedEventArgs e)
        {

            ImageButton.Visibility = Visibility.Hidden;
            ImageButton2.Visibility = Visibility.Hidden;
            ImageButton3.Visibility = Visibility.Hidden;
            ImageButton4.Visibility = Visibility.Hidden;

            texto1.Visibility = Visibility.Hidden;
            texto2.Visibility = Visibility.Hidden;
            texto3.Visibility = Visibility.Hidden;
            texto4.Visibility = Visibility.Hidden;
            texto5.Visibility = Visibility.Hidden;
            Cerrar.Visibility = Visibility.Hidden;
            ejemplo.Content = new Page1();
            ejemplo.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            BReturn.Visibility = Visibility.Visible;



        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            Storyboard nombreVariable;
            nombreVariable = (Storyboard)this.Resources["StoryMenu1"];
            nombreVariable.Begin();


        }



        private void Click2(object sender, RoutedEventArgs e)
        {
            Storyboard nombreVariable;
            nombreVariable = (Storyboard)this.Resources["StoryMenuInv1"];
            nombreVariable.Begin();
        }
 

        private void CircularButton_Click(object sender, RoutedEventArgs e)
        {
            OptionsPopup.IsOpen = true;
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            Window Log = new log();
            Log.Show();
            this.Close();
        }

        private void ClosePopup_Click(object sender, RoutedEventArgs e)
        {
            OptionsPopup.IsOpen = false;
        }
    }
}
