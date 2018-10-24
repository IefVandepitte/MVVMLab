using MVVMLab.dummydata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MVVMLab
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Movie> movies = DummyDataSource.Movies;

        public MainPage()
        {
            this.InitializeComponent();
            
            moviesListView.ItemsSource = movies;
            moviesListView.Width = Window.Current.CoreWindow.Bounds.Width -200;
            moviesListView.Height = Window.Current.CoreWindow.Bounds.Height -200;
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewMoviePage));

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e != null && e.Parameter.GetType() == typeof(Movie)) {
                movies.Add(e.Parameter as Movie);
                moviesListView.InvalidateArrange();
            }
        }
    }
}
