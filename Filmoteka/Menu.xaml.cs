using MongoDB.Bson;
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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public static User User;
        public Menu(User user)
        {
            User = user;
            InitializeComponent();            
            loadData();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            IMongoCollection<User> collection = database.GetCollection<User>("Users");
            
            lbllogname.Content = $"Привет, {User.Name}!";            
        }
        private void btn_janr1_Click(object sender, RoutedEventArgs e)
        {
            Filter("Комедия");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Комедия");
            btn_janr1.Background = Brushes.Gray;
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            
        }

        private void btn_janr9_Click(object sender, RoutedEventArgs e)
        {
            Filter("Драма");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Драма");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = Brushes.Gray;
            
        }

        private void btn_janr8_Click(object sender, RoutedEventArgs e)
        {
            Filter("Боевик");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Боевик");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = Brushes.Gray;
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            
        }

        private void btn_janr7_Click(object sender, RoutedEventArgs e)
        {
            Filter("Романтика");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Романтика");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = Brushes.Gray;
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            
        }

        private void btn_janr6_Click(object sender, RoutedEventArgs e)
        {
            Filter("Детектив");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Детектив");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = Brushes.Gray;
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            
        }

        private void btn_janr5_Click(object sender, RoutedEventArgs e)
        {
            Filter("Аниме");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Аниме");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = Brushes.Gray;
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            
        }

        private void btn_janr4_Click(object sender, RoutedEventArgs e)
        {
            Filter("Ужасы");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Ужасы");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = Brushes.Gray;
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            
        }

        private void btn_janr3_Click(object sender, RoutedEventArgs e)
        {
            Filter("Триллер");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Триллер");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = Brushes.Gray;
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            
        }

        private void btn_janr2_Click(object sender, RoutedEventArgs e)
        {
            Filter("Фантастика");
            listFilm.ItemsSource = DataBaseMethods.SearchJanrFilm("Фантастика");
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = Brushes.Gray;
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
                        
        }             
        
        private void btn_reload_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow registrationWindow = new MainWindow();
            registrationWindow.Show();
        }

        private void listFilm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var film = listFilm.SelectedItem as Films;
            Oblojki oblojki = new Oblojki(film, User);
            oblojki.Show();
            this.Close();            
        }
        public async void loadData()
        {            
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var filter = new BsonDocument();
            List<Films> film = new List<Films>();
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var films = cursor.Current;
                    foreach (Films doc in films)
                    {
                        film.Add(new Films(doc.NameOfFilm, doc.Rating, doc.Review, doc.Janr, doc.Year, doc.Rejiser, doc.Image));
                    }
                }
            }
            listFilm.ItemsSource = film.ToList();
        }
        public async void Filter(string Janr)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var filter = new BsonDocument();
            List<Films> film = new List<Films>();
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var people = cursor.Current;
                    foreach (Films doc in people)
                    {
                        film.Add(new Films(doc.NameOfFilm, doc.Rating, doc.Review, doc.Janr, doc.Year, doc.Rejiser, doc.Image));
                    }
                }
            }
            listFilm.ItemsSource = film.ToList().Where(f => f.Janr == Janr);
        }        

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Search(search.Text);
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            //listFilm.ItemsSource = DataBaseMethods.SearchFilm(search.Text).ToList();
        }
        public async void Search(string nameOfFilm)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("UsersEatflex");
            var collection = database.GetCollection<Films>("Films");
            var filter = new BsonDocument();
            List<Films> film = new List<Films>();
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var people = cursor.Current;
                    foreach (Films doc in people)
                    {
                        film.Add(new Films(doc.NameOfFilm, doc.Rating, doc.Review, doc.Janr, doc.Year, doc.Rejiser, doc.Image));
                    }
                }
            }
            listFilm.ItemsSource = film.ToList().Where(f => f.NameOfFilm == nameOfFilm);
        }
    }
}