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
        public Oblojki()
        {
            InitializeComponent();
            
        }
        private void image()
        {
            if (DataBaseMethods.FindNameToDatabase == "Тупой и еще тупее")
            {
                image_obl.Source = new BitmapImage(new Uri("E:/обложки/комедия/тиет.jpg", UriKind.Relative));
            }
        }
    }
}
