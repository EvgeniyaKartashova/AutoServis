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
using DemoAutoSevice.Utils;

namespace DemoAutoSevice.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для pDemo.xaml
    /// </summary>
    public partial class pDemo : Page
    {
        public pDemo()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lvOrders.ItemsSource = AppData.db.Order.ToList();
        }
    }
}
