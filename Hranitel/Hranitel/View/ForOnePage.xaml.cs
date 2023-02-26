using Hranitel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для ForOnePage.xaml
    /// </summary>
    public partial class ForOnePage : Page
    {
        public ForOnePage()
        {
            InitializeComponent();
            CmbFio.ItemsSource = HranitelPROEntities.getContext().Users.ToList();
            CmbCel.ItemsSource = HranitelPROEntities.getContext().CelPos.ToList();
            
        }
        private void  newInfUsersZayavk()
        {
            InformationAboutTourist tourist = new InformationAboutTourist();
            tourist.FirstName = TxbName.Text;
            tourist.LastName = TxbLastName.Text;
            tourist.Otchestvo = TxbOtchestvo.Text;
            tourist.Phone = TxbOtchestvo.Text;
            tourist.Email = TxbEmail.Text;
            tourist.Organisation = TxbOrganization.Text;
            tourist.Comment = TxbComment.Text;
            tourist.BirthDay = Convert.ToDateTime(DatePic.Text);
            tourist.SeriaPass = TxbSeria.Text;
            tourist.NomerPass = TxbNomer.Text;
            HranitelPROEntities.getContext().InformationAboutTourists.Add(tourist);

            try
            {
                HranitelPROEntities.getContext().SaveChanges();
                MessageBox.Show("Заявка создана");
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            newInfUsersZayavk();
            Zayavki zayavka = new Zayavki();
            zayavka.Dates = Convert.ToDateTime(DatePic.Text);
            zayavka.Status = "На рассмотрении";
            HranitelPROEntities.getContext().Zayavkis.Add(zayavka);
            try
            {
                HranitelPROEntities.getContext().SaveChanges();

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

    }
}
