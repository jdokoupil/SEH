﻿using System;
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

namespace SEH
{
    /// <summary>
    /// Interaction logic for InputPage.xaml
    /// </summary>
    public partial class InputPage : Page
    {
        public InputPage()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"Your title is {titleBox.Text}");
            //MessageBox.Show($"Your body is {bodyBox.Text}");

            SearchResultsPage searchResultsPage = new SearchResultsPage();
            this.NavigationService.Navigate(searchResultsPage);
        }
    }
}
