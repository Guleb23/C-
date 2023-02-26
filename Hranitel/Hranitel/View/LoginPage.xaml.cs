using Hranitel.Models;
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

namespace Hranitel.View
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var currentDefUser = HranitelPROEntities.getContext().DefUsers.FirstOrDefault( u=> u.Login == TxbLogin.Text && u.Password == TxbPassword.Password );
            var currentUser = HranitelPROEntities.getContext().Users.FirstOrDefault(u => u.Login == TxbLogin.Text && u.Password == TxbPassword.Password);
            if(currentDefUser != null)
            {
                Manager.MainFrame.Navigate(new AutorizationPage());
            }
            else if (currentUser != null)
            {
                MessageBox.Show("Добро пожаловать сотрудник");
                Manager.MainFrame.Navigate(new SotrudnikPage());
            }
            else
            {
                MessageBox.Show("Вы Не зареганы");
            }
           
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RegistrationPage());
        }
    }
}
