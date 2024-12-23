﻿using PM.WPF.ViewModels;
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

namespace PM.WPF.Views.Pages.Pages_of_MainWindow
{
    /// <summary>
    /// Interaction logic for RecentlyPage.xaml
    /// </summary>
    public partial class RecentlyPage : Page
    {
        public RecentlyPage()
        {
            InitializeComponent();
            this.DataContext = new HomePageViewModel();
        }

        private void ProjectListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}