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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Login.Text) && !MediaCenterEntities.GetContext().Users.Where(x => x.login == Login.Text).Any())
            {
                User user = new User();
                user.login = Login.Text;
                user.password = Password.Password;
                MediaCenterEntities.GetContext().Users.Add(user);
                MediaCenterEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы успешно зарегистрировались!");
                Manager1.MainFrame.GoBack();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
        }
    }
}
