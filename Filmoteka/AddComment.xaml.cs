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
    /// Логика взаимодействия для AddComment.xaml
    /// </summary>
    public partial class AddComment : Window
    {
        public static Films Films;
        public static User User;
        public AddComment(Films films, User user)
        {
            Films = films;
            User = user;
            InitializeComponent();
            txtb_film.Text = Films.NameOfFilm;
            img_film.Source = new BitmapImage(new Uri(Films.Image, UriKind.RelativeOrAbsolute));
            
        }

        private void btn_addcomm_Click(object sender, RoutedEventArgs e)
        {
            Review review = new Review(Films, User, txtb_comment.Text);
            DataBaseMethods.AddReview(review);
        }
    }
}
