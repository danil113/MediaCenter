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
    /// Логика взаимодействия для AddEditPageType.xaml
    /// </summary>
    public partial class AddEditPageType : Page
    {
        Type _currentType;
        public AddEditPageType()
        {
            InitializeComponent();
            _currentType = new Type();
            DataContext = _currentType;
        }
        public AddEditPageType(Type type)
        {
            InitializeComponent();
            _currentType = type;
            DataContext = _currentType;
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(type.Text) || string.IsNullOrWhiteSpace(price.Text))
                MessageBox.Show("Заполнте поле", "", MessageBoxButton.OK);
            else
            {
                if (_currentType.ID == 0)
                    MediaCenterEntities.GetContext().Types.Add(_currentType);
                try
                {
                    MediaCenterEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToList()}");
                }
                MessageBox.Show("Вы успешно добавили новый тип рекламы");
                Manager1.MainFrame.GoBack();
            }
        }
    }
}
