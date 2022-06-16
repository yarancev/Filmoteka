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
    /// Логика взаимодействия для Oblojki.xaml
    /// </summary>
    public partial class Oblojki : Window
    {
        public static Films Films;
        public static User User;
        public Oblojki(Films films, User user)
        {
            InitializeComponent();
            if (User.Email == "admin") 
            {
                btn_redakt.Visibility = Visibility.Visible;
                btn_delete.Visibility = Visibility.Visible;
            }
                        
            txt_review.TextWrapping = TextWrapping.Wrap;
            Films = films;
            User = user;
            txt_nameOfFilm.Text = $"Название: {films.NameOfFilm}";
            txt_janr.Text = $"Жанр: {films.Janr}";
            txt_review.Text = $"Рецензия: {films.Review}";
            txt_rating.Text = $"Рейтинг: {films.Rating}";
            txt_year.Text = $"Год: {films.Year}";
            txt_rejiser.Text = $"Режиссер: {films.Rejiser}";            
            image_obl.Source = new BitmapImage(new Uri(films.Image, UriKind.RelativeOrAbsolute));
        }

        private void btn_nazad_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Menu menuWindow = new Menu(User);
            menuWindow.Show();
        }

        private void btn_redakt_Click(object sender, RoutedEventArgs e)
        {
            Redaktirovanie redaktirovanie = new Redaktirovanie(Films, User);
            redaktirovanie.Show();
            this.Close();
        }
        public void Refresh()
        {
            txt_nameOfFilm.Text = null;
            txt_review.Text = null;
            txt_nameOfFilm.Text = $"Название: {Films.NameOfFilm}";
            txt_review.Text = $"Рецензия: {Films.Review}";
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            DataBaseMethods.DeleteFilm(Films.NameOfFilm);
            MessageBox.Show($"{Films.NameOfFilm} - удален");
            Menu menu = new Menu(User);
            menu.Show();
            this.Close();
        }

        private void btn_otziv_Click(object sender, RoutedEventArgs e)
        {
            AddComment addcomment = new AddComment(Films, User);
            addcomment.Show();
        }
    }
}
