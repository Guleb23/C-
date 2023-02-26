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

namespace HranitelPro.View
{
    /// <summary>
    /// Логика взаимодействия для SecurityPage.xaml
    /// </summary>
    public partial class SecurityPage : Page
    {
        public SecurityPage()
        {
            InitializeComponent();
        }

        private void NewProp(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new NewPropPage());
        }
    }
}
