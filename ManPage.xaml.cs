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
    /// Логика взаимодействия для ManPage.xaml
    /// </summary>
    public partial class ManPage : Page
    {
        Manager _currentClient;
        
        public ManPage()
        {
            InitializeComponent();
            _currentClient = new Manager();
            DataContext = _currentClient;
            ComboID.ItemsSource = MediaCenterEntities.GetContext().Users.ToList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text))
                MessageBox.Show("Заполнте поле длительность", "", MessageBoxButton.OK);
            if (string.IsNullOrWhiteSpace(Surname.Text))
                MessageBox.Show("Заполнте поле количество показов в день", "", MessageBoxButton.OK);
            if (string.IsNullOrWhiteSpace(Patronymic.Text))
                MessageBox.Show("Заполнте поле количество дней", "", MessageBoxButton.OK);
            else
            {
                if (_currentClient.ID == 0)
                    MediaCenterEntities.GetContext().Managers.Add(_currentClient);
                try
                {
                    MediaCenterEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToList()}");
                }
                MessageBox.Show("Вы успешно добавили Менеджера");
                Manager1.MainFrame.GoBack();
            }
        }

        private void ManagerTable_Click(object sender, RoutedEventArgs e)
        {
            Manager1.MainFrame.Navigate(new ManagerPage());
        }
    }
}
