using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

namespace FrontendEscolar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        //Diseño de la pagina

        private void ClickCerrar(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void ClickMinimizar(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void MostrarToolTip(object sender, MouseEventArgs e)
        {
            ToolTip tt = (ToolTip)((Image)sender).ToolTip;
            tt.IsOpen = true;
        }
        private void OcultarToolTip(object sender, MouseEventArgs e)
        {
            ToolTip tt = (ToolTip)((Image)sender).ToolTip;
            tt.IsOpen = false;
        }

        //configuracion del textbox y del passwordbox
        private void pwdBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == "Contraseña")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = Brushes.Black;
            }
        }
        private void pwdBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Password = "Contraseña";
                passwordBox.Foreground = Brushes.Gray;
            }
        }
        private void TL_Usuario_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Usuario")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }
        private void TL_Usuario_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Usuario";
                textBox.Foreground = Brushes.Gray;
            }
        }

    }
}
