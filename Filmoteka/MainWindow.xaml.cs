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
            //Films film = new Films("Тупой и еще тупее", 7.2, "Фильм очень смешной. Потраченное время не уйдет в пустую, так как хорошее настроение вам обеспечено. В некоторых моментах создатели перегибают с шутками, но они выглядят более мене уместно на фоне всех остальных шуток в этом фильме.", "Комедия", 1994, "Питер Фаррелли", "E:\обложки\комедия\тиет.jpg");
            //DataBaseMethods.AddToDatabase(film);            

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            IMongoCollection<User> collection = database.GetCollection<User>("Users");

            List<User> list = collection.Find(x => x.email == txtb_email.Text).ToList();
            if (list.Count > 0)
            {
                List<User> list2 = collection.Find(x => x.password == txtb_pass.Password).ToList();
                if (list2.Count > 0) 
                {
                    User.logemail = txtb_email.Text;
                    User.logpass = txtb_pass.Password;

                    MessageBox.Show("Вы успешно залогинены.");
                    Hide();
                    Menu menuWindow = new Menu();
                    menuWindow.Show();

                 

                }
            else
                MessageBox.Show("Данные введены неправильно.");

            }
            else
                MessageBox.Show("Данные введены неправильно.");
        }

        private void btn_registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registrationWindow = new Registration();
            registrationWindow.Show();
            Hide();       
        }
    }
}
