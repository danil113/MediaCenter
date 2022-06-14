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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            DGrid1.ItemsSource = MediaCenterEntities.GetContext().Clients.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new AddEditPage());
            
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = DGrid1.SelectedItems.Cast<Client>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить?", "Внимание",MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    MediaCenterEntities.GetContext().Clients.RemoveRange(clientsForRemoving);
                    MediaCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGrid1.ItemsSource = MediaCenterEntities.GetContext().Clients.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                }
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Client));
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void UpdateClients()
        {
            var currentClients = MediaCenterEntities.GetContext().Clients.ToList();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BtnDelete.Visibility = Date.isManager() ? Visibility.Visible : Visibility.Collapsed;
            BtnAdd.Visibility = Date.isManager() ? Visibility.Visible : Visibility.Collapsed;
            aye.Visibility = Date.isManager() ? Visibility.Visible : Visibility.Collapsed;
            DGrid1.ItemsSource = MediaCenterEntities.GetContext().Clients.ToList();
        }
    }
}
