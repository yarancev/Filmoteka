using MongoDB.Driver;
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

namespace Filmoteka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, RoutedEventArgs e)
        {           
                    var user = DataBaseMethods.UserIsExists(txtb_email.Text, txtb_pass.Password);
                    if (user != null)
                    {
                        Menu menuWindow = new Menu(user);
                        menuWindow.Show();
                    }               
        }

        private void btn_registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registrationWindow = new Registration();
            registrationWindow.Show();
            Hide();       
        }
    }
}
