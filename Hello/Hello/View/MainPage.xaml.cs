using Hello.Models;
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

namespace Hello.View
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TxbLogin.Text;
            var pass = TxbPassword.Password;
            var user = AppData.bd.user_.FirstOrDefault(u => u.Login == TxbLogin.Text && u.Password == TxbPassword.Password);
            if (user != null)
            {
                NavigationService.Navigate(new WelcomePage());

            }
            else
            {
                MessageBox.Show("Вы не зареггестрированы", "Уведомление");
            }
        }
    }
}
