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
using System.Windows.Shapes;

namespace Practica_2
{
    /// <summary>
    /// Lógica de interacción para log.xaml
    /// </summary>
    public partial class log : Window
    {
        public log()
        {
            InitializeComponent();
        }


        private void IdentificarUser(object sender, RoutedEventArgs e)
        {
            string User = this.txtUsuario.Text;
            string Password = this.txtPassword.Password;

            if (User == "" || Password == "")
            {
                MessageBox.Show("Inserte el nombre del usuario o el Password");
                this.txtUsuario.Focus();
                return;
            }
            else
            {
                if (txtUsuario.Text != "Eloy" || txtPassword.Password != "1234")
                {
                    MessageBox.Show("El nombre de usuario o el password es incorrecto");
                    this.txtUsuario.Focus();
                    return;
                }
                else
                MessageBox.Show("Usuario correcto");
                Window main = new MainWindow();

                main.Show();
                this.Close();

                return;
            }
        }


    }
    
}
