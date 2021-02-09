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

namespace Video_Player
{
    /// <summary>
    /// Interaction logic for Login2.xaml
    /// </summary>
    public partial class Login2 : Window
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var settingspage = new Main_Settings();

            if (txtUser.Text == "s-creators" & txtPass.Password.ToString() == "wesam123")
            {

                settingspage.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("User Name OR Password is Wrong", "Issue", MessageBoxButton.OKCancel, MessageBoxImage.Stop);

            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            var englishpage = new English();
            var arabicpage = new Arabic();

            if (Settings.Default.pageInfo == "English")
            {
                englishpage.Show();
                this.Hide();
            }
            if (Settings.Default.pageInfo == "Arabic")
            {
                arabicpage.Show();
                this.Hide();
            }
        }
    }
}
