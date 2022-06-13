﻿using MongoDB.Driver;
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
    /// Логика взаимодействия для Personal.xaml
    /// </summary>
    public partial class Personal : Window
    {
        public Personal()
        {
            InitializeComponent();

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersEatflex");
            IMongoCollection<User> collection = database.GetCollection<User>("Users");


        }
    }
}
