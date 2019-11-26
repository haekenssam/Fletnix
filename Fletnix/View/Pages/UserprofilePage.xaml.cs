﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fletnix.View.Pages
{
    /// <summary>
    /// Interaction logic for UserprofilePage.xaml
    /// </summary>
    public partial class UserprofilePage : Page
    {
        public UserprofilePage()
        {
            InitializeComponent();
        }

        public T FindParentOfType<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentDepObj = child;
            do
            {
                parentDepObj = VisualTreeHelper.GetParent(parentDepObj);
                T parent = parentDepObj as T;
                if (parent != null) return parent;
            }
            while (parentDepObj != null);
            return null;
        }

        private void ButtonAddUserprofile_Click(object sender, RoutedEventArgs e)
        {
            new CreateUserprofileWindow().ShowDialog();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            var frame = FindParentOfType<Frame>(this);
            frame.Navigate(new CatalogPage());
        }
    }
}