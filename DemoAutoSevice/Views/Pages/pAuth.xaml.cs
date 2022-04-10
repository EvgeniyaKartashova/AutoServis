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

namespace DemoAutoSevice.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для pAuth.xaml
    /// </summary>
    public partial class pAuth : Page
    {
        public pAuth()
        {
            InitializeComponent();
        }

        private void tbShowPassword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pbPassword.Visibility = Visibility.Collapsed;
            tbPassword.Visibility = Visibility.Visible;
            tbPassword.Text = pbPassword.Password;

        }

        private void tbShowPassword_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pbPassword.Visibility = Visibility.Visible;
            tbPassword.Visibility = Visibility.Collapsed;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbLogin.Text=="DEMO" && pbPassword.Password=="DEMO")
                {
                    NavigationService.Navigate(new pDemo());
                }
            }
            catch
            { }
        }
    }
}
