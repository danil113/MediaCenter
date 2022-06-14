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
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            DGrid3.ItemsSource = MediaCenterEntities.GetContext().Orders.ToList();
            Filtr.ItemsSource = MediaCenterEntities.GetContext().Types.GroupBy(x => x.Type1).Select(X => X.Key).ToList();
            Filtr11.ItemsSource = MediaCenterEntities.GetContext().Managers.GroupBy(x => x.FirstName).Select(X => X.Key).ToList();

            Sort.ItemsSource = new List<string>
            {
                "Тип рекламы", "Клиент", "Длительность", "Количество показов в день", "Количество дней", "Цена", "Описание", "Дата начала"
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new AddEditPageOrders((sender as Button).DataContext as Order));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new AddEditPageOrders());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = DGrid3.SelectedItems.Cast<Order>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить ?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    MediaCenterEntities.GetContext().Orders.RemoveRange(clientsForRemoving);
                    MediaCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGrid3.ItemsSource = MediaCenterEntities.GetContext().Orders.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        
        
        private void Poisk_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            DGrid3.ItemsSource = MediaCenterEntities.GetContext().Orders.Where(x => x.Client.Name.ToString().Contains(Poisk.Text.ToString())).ToList();
        }





        private void Filtr_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DGrid3.ItemsSource = MediaCenterEntities.GetContext().Orders.Where(x => x.Type.Type1 == Filtr.SelectedItem.ToString()).ToList();
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = DGrid3.ItemsSource.Cast<Order>().ToList();
            switch (Sort.SelectedItem.ToString())
            {
                case "Тип рекламы":
                    DGrid3.ItemsSource = list.OrderBy(x => x.Type.Type1);
                    break;
                case "Клиент":
                    DGrid3.ItemsSource = list.OrderBy(x => x.Client.Name);
                    break;
                case "Длительность":
                    DGrid3.ItemsSource = list.OrderBy(x => x.Duration);
                    break;
                case "Количество показов в день":
                    DGrid3.ItemsSource = list.OrderBy(x => x.NumberOfExitsPerDay);
                    break;
                case "Количество дней":
                    DGrid3.ItemsSource = list.OrderBy(x => x.NumberOfDays);
                    break;
                case "Цена":
                    DGrid3.ItemsSource = list.OrderBy(x => x.Cost);
                    break;
                case "Описание":
                    DGrid3.ItemsSource = list.OrderBy(x => x.Description);
                    break;
                case "Дата начала":
                    DGrid3.ItemsSource = list.OrderBy(x => x.StartDate);
                    break;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            
            BtnDelete.Visibility = Date.isManager() ? Visibility.Visible : Visibility.Collapsed;
            BtnAdd.Visibility = Date.isManager() ? Visibility.Visible : Visibility.Collapsed;
            aye.Visibility = Date.isManager() ? Visibility.Visible : Visibility.Collapsed;
            DGrid3.ItemsSource = MediaCenterEntities.GetContext().Orders.ToList();
        }

        private void Filtr11_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DGrid3.ItemsSource = MediaCenterEntities.GetContext().Orders.Where(x => x.Manager.FirstName == Filtr11.SelectedItem.ToString()).ToList();
        }
    }
}
