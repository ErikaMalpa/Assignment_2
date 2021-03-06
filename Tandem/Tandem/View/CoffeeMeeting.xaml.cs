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
using System.Windows.Shapes;
using Tandem.Model;

namespace Tandem.View
{
    /// <summary>
    /// Interaction logic for CoffeeMeeting.xaml
    /// </summary>
    public partial class CoffeeMeeting : Window
    {
        /// <summary>
        /// Initializes the component of CoffeeMeeting
        /// </summary>
        public CoffeeMeeting()
        {
            InitializeComponent();
        }

        private void SignUpClick(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void HomeButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
