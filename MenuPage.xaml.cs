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

namespace КурсС4
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {

        public MenuPage()
        {
            InitializeComponent();
        }

        private void BtnSupp_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new ClientPage());
        }
        private void BtnSupp1_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new TypePage());
        }
        private void BtnSupp2_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new OrdersPage());
        }
        private void BtnManager_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new ManPage());
        }


        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            BtnManager.Visibility = Date.isAdmin() ? Visibility.Visible : Visibility.Collapsed;

        }

        private void BtnSupp33_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new AutPage());
        }

        private void welkom_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var cosin = MediaCenterEntities.GetContext().Managers.First(x => x.ID_User == Date.UserID).FirstName;
            welkom.Text = $"Добро пожаловать {cosin}";
            
        }
    }
}
