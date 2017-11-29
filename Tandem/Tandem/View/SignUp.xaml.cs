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
using System.Windows.Shapes;

namespace Tandem.View
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        /// <summary>
        /// Initialize the componend for SignUp
        /// </summary>
        public SignUp()
        {
            InitializeComponent();
            
        }

        private void MenuClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// When the user press submits there will a pop up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SubmitButton(object sender, RoutedEventArgs e)
        {
            TablePopup.IsOpen = true;
            string messageBoxText = "By clicking Ok, you agree to the terms and conditions";
            string caption = "Submit";
            MessageBoxButton messageBoxButton = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(messageBoxText, caption, messageBoxButton, icon);
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            TablePopup.IsOpen = false;
        }

        private void HomeButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CoffeeMeetingClick(object sender, RoutedEventArgs e)
        {
            CoffeeMeeting coffeeMeeting = new CoffeeMeeting();
            coffeeMeeting.Show();
            this.Close();
        }
    }
}

