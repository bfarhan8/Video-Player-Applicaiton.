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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Diagnostics;

namespace Video_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

   private void btnEnglish_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.pageInfo = "English";
            var english = new English();
            english.Show();
            this.Hide();
        }

        private void btnArabic_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.pageInfo = "Arabic";
            var arabic = new Arabic();
            arabic.Show();
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
