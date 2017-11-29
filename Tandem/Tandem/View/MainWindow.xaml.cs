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
using Tandem.View;

namespace Tandem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the component of MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUpCommand(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void CoffeeMeetingCommand(object sender, RoutedEventArgs e)
        {
           CoffeeMeeting coffeeMeeting = new CoffeeMeeting();
            coffeeMeeting.Show();
            this.Close();
        }
    }
}
