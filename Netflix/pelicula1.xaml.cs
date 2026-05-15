using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Lógica de interacción para pelicula1.xaml
    /// </summary>
    /// 
    public partial class pelicula1 : Page, IMyInterface
    {
        public pelicula1()
        {
            InitializeComponent();
        

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

        
    }
}
