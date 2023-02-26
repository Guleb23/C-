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
    /// Логика взаимодействия для SotrudnikPage.xaml
    /// </summary>
    public partial class SotrudnikPage : Page
    {
        public SotrudnikPage()
        {
            InitializeComponent();
            DgridZayavk.ItemsSource = HranitelPROEntities.getContext().Zayavkis.ToList();
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void DgridZayavk_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Zayavki zayavki = e.Row.Item as Zayavki;
            MessageBox.Show($" {zayavki.id} {zayavki.Status} ");
            HranitelPROEntities.getContext().SaveChanges();
            DgridZayavk.ItemsSource = HranitelPROEntities.getContext().Zayavkis.ToList();
        }
    }
}
