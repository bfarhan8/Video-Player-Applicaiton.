using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Video_Player.Properties;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Video_Player
{
    /// <summary>
    /// Interaction logic for Arabic.xaml
    /// </summary>
    public partial class Arabic : Window
    {
        public Arabic()
        {
            InitializeComponent();

            // Settings of Button Text

            movie1.Content = Settings.Default.btnAMovie1;
            movie2.Content = Settings.Default.btnAMovie2;
            movie3.Content = Settings.Default.btnAMovie3;
            movie4.Content = Settings.Default.btnAMovie4;
            movie5.Content = Settings.Default.btnAMovie5;
            movie6.Content = Settings.Default.btnAMovie6;
            movie7.Content = Settings.Default.btnAMovie7;
            movie8.Content = Settings.Default.btnAMovie8;
            movie9.Content = Settings.Default.btnAMovie9;
            movie10.Content = Settings.Default.btnAMovie10;
            movie11.Content = Settings.Default.btnAMovie11;
            movie12.Content = Settings.Default.btnAMovie12;

            // Settings of Button Font

            movie1.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie2.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie3.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie4.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie5.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie6.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie7.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie8.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie9.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie10.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie11.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);
            movie12.FontSize = Convert.ToDouble(Settings.Default.btnAFont1);

            // Settings of Button Color

            movie1.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie2.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie3.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie4.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie5.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie6.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie7.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie8.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie9.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie10.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie11.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;
            movie12.Foreground = new BrushConverter().ConvertFromString(Settings.Default.btnAColor1) as SolidColorBrush;




            if (Settings.Default.vA1 == true)
            {
                movie1.Visibility = Visibility.Visible;
            }
            else
            {
                movie2.Visibility = Visibility.Hidden;
            }

            if (Settings.Default.vA2 == true)
            {
                movie2.Visibility = Visibility.Visible;
            }
            else
            {
                movie3.Visibility = Visibility.Hidden;
            }


            if (Settings.Default.vA3 == true)
            {
                movie3.Visibility = Visibility.Visible;
            }
            else
            {
                movie4.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA4 == true)
            {
                movie4.Visibility = Visibility.Visible;
            }
            else
            {
                movie5.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA5 == true)
            {
                movie5.Visibility = Visibility.Visible;
            }
            else
            {
                movie6.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA6 == true)
            {
                movie6.Visibility = Visibility.Visible;
            }
            else
            {
                movie7.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA7 == true)
            {
                movie7.Visibility = Visibility.Visible;
            }
            else
            {
                movie8.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA8 == true)
            {
                movie8.Visibility = Visibility.Visible;
            }
            else
            {
                movie1.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA9 == true)
            {
                movie9.Visibility = Visibility.Visible;
            }
            else
            {
                movie9.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA10 == true)
            {
                movie10.Visibility = Visibility.Visible;
            }
            else
            {
                movie10.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA11 == true)
            {
                movie11.Visibility = Visibility.Visible;
            }
            else
            {
                movie11.Visibility = Visibility.Hidden;
            }
            if (Settings.Default.vA12 == true)
            {
                movie12.Visibility = Visibility.Visible;
            }
            
            else
            {
                movie12.Visibility = Visibility.Hidden;

            }



           



        }

        Media_Player Media_Player = new Media_Player();
        public void showOnMonitor(int Number)
        {

            try
            {
                Screen s = Screen.AllScreens[Number];

                System.Drawing.Rectangle r = s.WorkingArea;
                Media_Player.Top = r.Top;
                Media_Player.Left = r.Left;

                Media_Player.Height = r.Height;
                Media_Player.Width = r.Width;

                Media_Player.Show();

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Please Make Sure System Display Settings are Extented" + ex.ToString());
                Close();
            }
        }

        private void movie1_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie1A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie2_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie2A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie3_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie3A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie4_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie4A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie5_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie5A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie6_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie6A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie7_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie7A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie8_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie8A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie9_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie9A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie10_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie10A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie11_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie11A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void movie12_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.url = Settings.Default.Movie12A;
            Settings.Default.Save();
            Media_Player.mediaplayer.Source = new Uri(Settings.Default.url.ToString(), UriKind.RelativeOrAbsolute);
            Media_Player.mediaplayer.Play();
            showOnMonitor(1);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var language = new MainWindow();
            language.Show();

            Media_Player.mediaplayer.Close();
            Media_Player.Close();

            this.Close();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void clickme_TouchDown(object sender, TouchEventArgs e)
        {
            var login = new Login2();
            login.Show();
            this.Hide();
        }

        private void clickme_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var login = new Login2();
            login.Show();
            this.Hide();
        }
    }
}
