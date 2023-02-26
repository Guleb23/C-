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
    /// Логика взаимодействия для RegUsers.xaml
    /// </summary>
    public partial class RegUsers : Page
    {
        public RegUsers()
        {
            InitializeComponent();
            DtgUsers.ItemsSource = HranitelPROEntities.getContext().DefUsers.ToList();
        }
    }
}
