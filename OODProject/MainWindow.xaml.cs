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

namespace OODProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Movie> movies = new List<Movie>();
        List<Movie> selectedMovie = new List<Movie>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Creating the movie objects
            Movie m1 = new Movie()
            {
                Name = "1917",
                Cost = 8m, 
                Actors = "George McKay, Dean-Charles Chapman, Richard Madden, Benedict Cumberbatch", 
                Director = "Sam Mendes",
                Times = "17:30, 20:30",
                Rating = "15A",
                TypeOfGenre = Genre.Drama
            };

            Movie m2 = new Movie()
            {
                Name = "Bad Boys for Life",
                Cost = 8m,
                Actors = "Will Smith, Martin Lawrence",
                Director = "Bilall Fallah, Adil El Arbi",
                Times = "18:00, 20:45",
                Rating = "16",
                TypeOfGenre = Genre.Action
            };

            Movie m3 = new Movie()
            {
                Name = "The Turning",
                Cost = 8m,
                Actors = "Mackenzie Davis, Finn Wolfhard, Brooklynn Prince",
                Director = "Floria Sigismondi",
                Times = "18:30, 21:00",
                Rating = "16",
                TypeOfGenre = Genre.Horror
            };

            Movie m4 = new Movie()
            {
                Name = "The Grudge",
                Cost = 8m,
                Actors = "Betty Gilpin, Andrea Riseborough, William Sadler",
                Director = "Nicolas Pesce",
                Times = "17:15, 20:30",
                Rating = "18",
                TypeOfGenre = Genre.Horror
            };

            Movie m5 = new Movie()
            {
                Name = "The Grudge",
                Cost = 8m,
                Actors = "Betty Gilpin, Andrea Riseborough, William Sadler",
                Director = "Nicolas Pesce",
                Times = "17:15, 20:30",
                Rating = "18",
                TypeOfGenre = Genre.Horror
            };

            Movie m6 = new Movie()
            {
                Name = "Just Mercy",
                Cost = 8m,
                Actors = "Michael B Jordan, Jamie Foxx, Brie Larson",
                Director = "Destin Daniel Cretton",
                Times = "20:15",
                Rating = "12A",
                TypeOfGenre = Genre.Drama
            };

            Movie m7 = new Movie()
            {
                Name = "Doolittle",
                Cost = 8m,
                Actors = "Robert Downey Jr, Tom Holland, Michael Sheen",
                Director = "Stephen Gaghan",
                Times = "17:45, 20:15",
                Rating = "PG",
                TypeOfGenre = Genre.Comedy
            };

            Movie m8 = new Movie()
            {
                Name = "Jumanji",
                Cost = 8m,
                Actors = "Dwayne Johnson, Kevin Hart, Jack Black, Karen Gillan",
                Director = "Jake Kasdan",
                Times = "17:15",
                Rating = "12A",
                TypeOfGenre = Genre.Comedy
            };

            Movie m9 = new Movie()
            {
                Name = "Star Wars: The Rise of Skywalker",
                Cost = 8m,
                Actors = "Daisey Ridley, Adam Driver, John Boyega, Billie Lourd",
                Director = "J.J. Abrams",
                Times = "17:00",
                Rating = "12A",
                TypeOfGenre = Genre.Action
            };

            //Adding movies to the list
            movies.Add(m1);
            movies.Add(m2);
            movies.Add(m3);
            movies.Add(m4);
            movies.Add(m5);
            movies.Add(m6);
            movies.Add(m7);
            movies.Add(m8);
            movies.Add(m9);

            //Sort by alphabetical order
            movies.Sort();

            //Display the activities in the listbox
            lbxMoviesOptions.ItemsSource = null;
            lbxMoviesOptions.ItemsSource = movies;
        }

        //CLicking on a movie name will display the movie details
        private void lbxMoviesOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selectedMovie = lbxMoviesOptions.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                tblkRatingDetails.Text = selectedMovie.Rating;
                tblkActorsDetails.Text = selectedMovie.Actors;
                tblkDirectorDetails.Text = selectedMovie.Director;
                tblkTimeDetails.Text = selectedMovie.Times;
            }
        }
    }
}
