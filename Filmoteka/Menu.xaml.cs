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
        public Menu()
        {
            InitializeComponent();

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            IMongoCollection<User> collection = database.GetCollection<User>("Users");

            List<User> loguser;

            loguser = collection.Find(x => x.email == User.logemail && x.password == User.logpass).ToList();
            lbllogname.Content = $"Привет, {loguser[0].name}!" ;
        }        
        private void btn_janr1_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = Brushes.Gray;
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_ujasi.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Visible;
        }

        private void btn_janr9_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = Brushes.Gray;
            panel_ujasi.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Hidden;            
            panel_boevik.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Visible;
        }

        private void btn_janr8_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = Brushes.Gray;
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_ujasi.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Hidden;            
            panel_detective.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Visible;
        }

        private void btn_janr7_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = Brushes.Gray;
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_ujasi.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Hidden;            
            panel_drama.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Visible;
        }

        private void btn_janr6_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = Brushes.Gray;
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_ujasi.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Hidden;            
            panel_anim.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Visible;
        }

        private void btn_janr5_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = Brushes.Gray;
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_ujasi.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Hidden;            
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Visible;
        }

        private void btn_janr4_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = Brushes.Gray;
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_triller.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_ujasi.Visibility = Visibility.Visible;
        }

        private void btn_janr3_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr3.Background = Brushes.Gray;
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_ujasi.Visibility = Visibility.Hidden;            
            panel_romantika.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Visible;
        }

        private void btn_janr2_Click(object sender, RoutedEventArgs e)
        {
            btn_janr1.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr2.Background = Brushes.Gray;
            btn_janr3.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr4.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr5.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr6.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr7.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr8.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            btn_janr9.Background = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            panel_ujasi.Visibility = Visibility.Hidden;
            panel_triller.Visibility = Visibility.Hidden;
            panel_romantika.Visibility = Visibility.Hidden;
            panel_drama.Visibility = Visibility.Hidden;
            panel_boevik.Visibility = Visibility.Hidden;
            panel_detective.Visibility = Visibility.Hidden;
            panel_anim.Visibility = Visibility.Hidden;
            panel_kom.Visibility = Visibility.Hidden;
            panel_fant.Visibility = Visibility.Visible;            
        }
             
        private void btn_tiet_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Oblojki oblojkiWindow = new Oblojki();
            oblojkiWindow.Show();            
        }

        private void btn_vvt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_rs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_zndvb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_gryaz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_chshn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_venom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_mstitely_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_inter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ftigoo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_deadpool_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_mortal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_club_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_vremya1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_vizhivshiy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_parazity_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_pd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_yaii_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_bbkuk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_jipkrep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_kkz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_sinister_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_strpriz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_chelmnog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_aot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_onepiece_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ghoul_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_naruto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_unesenpriz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_hxh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_vvrgr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_vtihom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ischez_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_platform_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_poisk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ubpootkr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_vekadal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_vmdod_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_zovimsim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_passajiry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_sumerki_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_titanik_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_brat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_idismotr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_meganlivi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ponakl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_posoobr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_forsaj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_volk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_vremya2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_odarennaya_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_raskopki_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_secret_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_reload_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow registrationWindow = new MainWindow();
            registrationWindow.Show();
        }
    }
}
