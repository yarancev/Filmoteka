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
using System.Windows.Shapes;

namespace Filmoteka
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
       
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_log1_Click(object sender, RoutedEventArgs e)
        {
            bool checkright = true;
            string name = txtb_name.Text.Trim();
            string number = txtb_number.Text.Trim();
            string email = txtb_email.Text.Trim().ToLower();
            string password = txtb_pass.Password.Trim();

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            IMongoCollection<User> collection = database.GetCollection<User>("Users");

            List<User> list = collection.Find(x => x.number == txtb_number.Text).ToList();
            if (list.Count > 0 || number.Length < 11 || number.Length > 11)
            {
                txtb_number.ToolTip = "Номер некорректный";
                txtb_number.Background = Brushes.DarkRed;
                checkright = false;
            }
            else
            {
                txtb_number.ToolTip = "";
                txtb_number.Background = Brushes.Transparent;
            }
           
            List<User> list2 = collection.Find(x => x.email == txtb_email.Text).ToList();
            if (list.Count > 0 || !email.Contains("@") || !email.Contains("."))
            {
                checkright = false;
                txtb_email.ToolTip = "Почта некорректная";
                txtb_email.Background = Brushes.DarkRed;
            }
            else
            {
                txtb_email.ToolTip = "";
                txtb_email.Background = Brushes.Transparent;
            }

            if (txtb_name.Text == "" || txtb_number.Text == "" || txtb_email.Text == "" || txtb_pass.Password == "")
            {
                checkright = false;               
                MessageBox.Show("Поля пустые");

            }

            if (checkright == true)
            {
                User.logemail = txtb_email.Text;
                User.logpass = txtb_pass.Password;

                collection.InsertOne(new User(txtb_name.Text, txtb_number.Text, txtb_email.Text, txtb_pass.Password));
                //Extensions.AddToDataBase(txtb1.Text, txtb2.Text, txtb3.Text, txtb4.Text, txtb5.Text);
                txtb_name.Clear();
                txtb_number.Clear();
                txtb_email.Clear();
                txtb_pass.Clear();
                MessageBox.Show("Вы успешно зарегистрировались");

                Hide();
                Menu menuWindow = new Menu();
                menuWindow.Show();
            }
        }
        private void btn_registration1_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow registrationWindow = new MainWindow();
            registrationWindow.Show();
        }
    }
}
