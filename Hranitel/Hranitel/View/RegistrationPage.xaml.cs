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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {   
        public RegistrationPage()
        {
            InitializeComponent();
            


        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DefUser user = new DefUser();
            user.Login = TxbLogin.Text;
            user.Password = TxbPassword.Text;
            user.Email = TxbEmail.Text;
            HranitelPROEntities.getContext().DefUsers.Add(user);
            try
            {
                HranitelPROEntities.getContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.Navigate(new RegUsers());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
    }
}
