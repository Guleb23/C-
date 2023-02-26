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
            string email = TxbEmail.Text.Trim();
            var pass = TxbPassword.Password.Trim();
            
            if (!email.Contains("@") || !email.Contains("."))
            {
                TxbEmail.ToolTip = "Некорректный email";
                TxbEmail.Background = Brushes.DarkRed;
            }
            if (pass.Length < 8)
            {
                TxbPassword.ToolTip = "Некорректный пароль";
                TxbPassword.Background = Brushes.DarkRed;
            }
            else
            {
                MessageBox.Show("Успешная регистрация");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string login = TxbLogin.Text.Trim();
        }
    }
}
