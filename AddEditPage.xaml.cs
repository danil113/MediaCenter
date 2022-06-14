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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Client _currentClient;
        public AddEditPage()
        {
            InitializeComponent();
            _currentClient = new Client();
            DataContext = _currentClient;
        }
        public AddEditPage(Client client )
        {
            InitializeComponent();
            _currentClient = client;
            DataContext = _currentClient;
        }
        
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || (string.IsNullOrWhiteSpace(phone.Text)))
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButton.OK);
                
                
            
            else
            {
                if (_currentClient.ID == 0)
                    MediaCenterEntities.GetContext().Clients.Add(_currentClient);

                try
                {
                    MediaCenterEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToList()}");
                }
                MessageBox.Show("Вы успешно добавили клиента");
                Manager1.MainFrame.GoBack();
            }
        }

        private void phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
