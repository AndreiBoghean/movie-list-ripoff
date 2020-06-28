﻿using System;
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

namespace movie_list_ripoff.Controls
{
    /// <summary>
    /// Interaction logic for MovieCard.xaml
    /// </summary>
    public partial class MovieCard : UserControl
    {
        public MovieCard(BitmapImage image, string name = "NAME NOT FOUND", string rating = "RATING NOT FOUND", string date = "DATE NOT FOUND")
        {
            InitializeComponent();

            Image.Source = image;
            MovieName.Text = name;
            Rating.Text = rating;
            ReleaseDate.Text = date;
        }
        public MovieCard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
