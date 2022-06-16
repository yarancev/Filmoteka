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
    /// Логика взаимодействия для Redaktirovanie.xaml
    /// </summary>
    public partial class Redaktirovanie : Window
    {
        public static Films Films;
        public static User User;
        public Redaktirovanie(Films film, User user)
        {
            Films = film;
            User = user;
            InitializeComponent();
            txtb_name.Text = Films.NameOfFilm;
            txtb_review.Text = Films.Review;
        }

        private void btn_prim_Click(object sender, RoutedEventArgs e)
        {
            DataBaseMethods.EditFilm(Films.NameOfFilm, txtb_review.Text, txtb_name.Text);
            MessageBox.Show("Информация изменена");
            Films.NameOfFilm = txtb_name.Text;
            Films.Review = txtb_review.Text;
            Oblojki oblojki = new Oblojki(Films, User);
            oblojki.Show();
            this.Close();
        }
    }
}
