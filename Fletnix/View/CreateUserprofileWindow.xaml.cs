using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fletnix.View
{
    /// <summary>
    /// Interaction logic for CreateUserprofileWindow.xaml
    /// </summary>
    public partial class CreateUserprofileWindow : Window
    {
        public CreateUserprofileWindow()
        {
            InitializeComponent();
        }

        private void ButtonSaveUserprofile_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
