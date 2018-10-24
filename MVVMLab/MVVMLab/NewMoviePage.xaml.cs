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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVMLab
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewMoviePage : Page
    {
        public NewMoviePage()
        {
            this.InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var title = TitleTextBox.Text;
            var director = directorTextBox.Text;
            var description = descrTextBox.Text;
            var movie = new Movie();
            movie.Title = title;
            movie.Director = director;
            movie.Description = description;
            this.Frame.Navigate(typeof(MainPage), movie);
        }
    }
}
