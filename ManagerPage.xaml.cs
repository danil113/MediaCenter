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
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
            DGrid.ItemsSource = MediaCenterEntities.GetContext().Managers.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = DGrid.SelectedItems.Cast<Manager>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить ?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    MediaCenterEntities.GetContext().Managers.RemoveRange(clientsForRemoving);
                    MediaCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGrid.ItemsSource = MediaCenterEntities.GetContext().Managers.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                }
            }
        }

        
    }
}
