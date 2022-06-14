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
    /// Логика взаимодействия для TypePage.xaml
    /// </summary>
    public partial class TypePage : Page
    {
        public TypePage()
        {
            InitializeComponent();
            DGrid2.ItemsSource = MediaCenterEntities.GetContext().Types.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new AddEditPageType());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = DGrid2.SelectedItems.Cast<Type>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить ?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    MediaCenterEntities.GetContext().Types.RemoveRange(clientsForRemoving);
                    MediaCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGrid2.ItemsSource = MediaCenterEntities.GetContext().Types.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new AddEditPageType((sender as Button).DataContext as Type));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BtnDelete.Visibility = Date.isAdmin() ? Visibility.Visible : Visibility.Collapsed;
            BtnAdd.Visibility = Date.isAdmin() ? Visibility.Visible : Visibility.Collapsed;
            aye.Visibility = Date.isAdmin() ? Visibility.Visible : Visibility.Collapsed;
            DGrid2.ItemsSource = MediaCenterEntities.GetContext().Types.ToList();
        }
    }
}
