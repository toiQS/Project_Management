﻿using PM.WPF.Models;
using PM.WPF.ViewModels;
using PM.WPF.Views.Windows;
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

namespace PM.WPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        

        public HomePage()
        {
            InitializeComponent();
            
        }

        private void ProjectListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Remove the condition temporarily to see if items are selectable
            if (ProjectListView.SelectedItem is Person person)
            {
                App.Current.MainWindow.Hide();

                var projectWindow = new ProjectWindow();
                projectWindow.ShowDialog();

                App.Current.MainWindow.Show();
            }
        }
    }

}
