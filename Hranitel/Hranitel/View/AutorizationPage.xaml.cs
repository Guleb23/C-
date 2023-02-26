﻿using Hranitel.Models;
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
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
            DgridZayavk.ItemsSource = HranitelPROEntities.getContext().Zayavkis.ToList();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void News(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OneOrCollectivePage());
        }
    }
}
