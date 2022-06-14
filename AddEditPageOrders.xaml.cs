using System;
//using System.Collections.Generic;
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
    /// Логика взаимодействия для AddEditPageOrders.xaml
    /// </summary>
    public partial class AddEditPageOrders : Page
    {
        Order _currentClient;
        public AddEditPageOrders()
        {
            InitializeComponent();
            _currentClient = new Order();
            DataContext = _currentClient;
            _currentClient.StartDate = DateTime.Now;
            ComboType.ItemsSource = MediaCenterEntities.GetContext().Types.ToList();
            ComboClient1.ItemsSource = MediaCenterEntities.GetContext().Clients.ToList();
            ComboManager.ItemsSource = MediaCenterEntities.GetContext().Managers.ToList();


        }
        public AddEditPageOrders(Order order)
        {
            InitializeComponent();
            _currentClient = order;
            DataContext = _currentClient;
            ComboType.ItemsSource = MediaCenterEntities.GetContext().Types.ToList();
            ComboClient1.ItemsSource = MediaCenterEntities.GetContext().Clients.ToList();
            ComboManager.ItemsSource = MediaCenterEntities.GetContext().Managers.ToList();
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(duration.Text)  || (string.IsNullOrWhiteSpace(BDcost.Text)) ||
                (string.IsNullOrWhiteSpace(numberofdays.Text)) || (string.IsNullOrWhiteSpace(number.Text)) || (string.IsNullOrWhiteSpace(startdate.Text)))
                MessageBox.Show("Заполнте все поля", "", MessageBoxButton.OK);
            if (string.IsNullOrWhiteSpace(description.Text))
                MessageBox.Show("Заполнте поле описание", "", MessageBoxButton.OK);


            else
            {
                if (_currentClient.ID == 0)
                    MediaCenterEntities.GetContext().Orders.Add(_currentClient);
                try
                {
                    MediaCenterEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToList()}");
                }
                MessageBox.Show("Данные сохранены");
                Manager1.MainFrame.GoBack();
            }
        }


        
        private void GetSum()
        {
            if (string.IsNullOrWhiteSpace(number.Text) || string.IsNullOrWhiteSpace(duration.Text) || string.IsNullOrWhiteSpace(numberofdays.Text) || ComboType.SelectedItem == null)
                return;

            var cost = MediaCenterEntities.GetContext().Types.ToList().Where(x => x.Type1 == (ComboType.SelectedItem as Type).Type1).Select(x => x.PricePerMinute).First();
            var durationInSecond = int.Parse(duration.Text);
            var countInDay = int.Parse(number.Text);
            var countOfDays = int.Parse(numberofdays.Text);
            var sum = Math.Round(cost / 60 * durationInSecond * countInDay * countOfDays, 2);
            BDcost.Text = $"{sum} Руб.";
            _currentClient.Cost = sum;

        }
        

        private void duration_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetSum();
        }

        private void number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetSum();
        }

        //private void numberofdays_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    GetSum();
        //}

        private void numberofdays_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            GetSum();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //if (MediaCenterEntities.GetContext().Managers.Any(x => x.ID_User == Date.UserID))
            //{
            //    if (MediaCenterEntities.GetContext().Managers.First(x => x.ID_User == Date.UserID).FirstName != " ")
            //        ComboManager.Text = $"{MediaCenterEntities.GetContext().Managers.First(x => x.ID_User == Date.UserID).ID}";
            //    else ComboManager.Visibility = Visibility.Collapsed;
            //}
            //else ComboManager.Visibility = Visibility.Collapsed;
        }

        private void numberofdays_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        //private void ComboManager_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{

        //    var cosin = MediaCenterEntities.GetContext().Managers.First(x => x.ID_User == Date.UserID).ID;
        //    ComboManager.Text = $"{cosin}";

        //    if (MediaCenterEntities.GetContext().Managers.Any(x => x.ID_User == Date.UserID))
        //    {
        //        if (MediaCenterEntities.GetContext().Managers.First(x => x.ID_User == Date.UserID).FirstName != " ")
        //            ComboManager.Text = $"{MediaCenterEntities.GetContext().Managers.First(x => x.ID_User == Date.UserID).FirstName}";
        //        else ComboManager.Visibility = Visibility.Collapsed;
        //    }
        //    else ComboManager.Visibility = Visibility.Collapsed;
        //}







        //private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    ComboClient1.ItemsSource = MediaCenterEntities.GetContext().Clients.Where(x => x.Name.ToString().Contains(Poisk.Text.ToString())).ToList();
        //}

    }
}
