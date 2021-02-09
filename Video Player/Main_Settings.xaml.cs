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
    /// Interaction logic for Main_Settings.xaml
    /// </summary>
    public partial class Main_Settings : Window
    {
        public Main_Settings()
        {
            InitializeComponent();

            // Generate the content of Page combo box
           
            cmbSlctPage.Items.Add("English");
            cmbSlctPage.Items.Add("Arabic");

            // Generate the items for Font Combo box

            cmbFont.Items.Add("1");
            cmbFont.Items.Add("2");
            cmbFont.Items.Add("4");
            cmbFont.Items.Add("8");
            cmbFont.Items.Add("12");
            cmbFont.Items.Add("16");
            cmbFont.Items.Add("18");
            cmbFont.Items.Add("22");
            cmbFont.Items.Add("24");
            cmbFont.Items.Add("30");
            cmbFont.Items.Add("38");
            cmbFont.Items.Add("42");


            // Generate the Items for Button Combo box

            cmbText.Items.Add("Button 1");
            cmbText.Items.Add("Button 2");
            cmbText.Items.Add("Button 3");
            cmbText.Items.Add("Button 4");
            cmbText.Items.Add("Button 5");
            cmbText.Items.Add("Button 6");
            cmbText.Items.Add("Button 7");
            cmbText.Items.Add("Button 8");
            cmbText.Items.Add("Button 9");
            cmbText.Items.Add("Button 10");
            cmbText.Items.Add("Button 11");
            cmbText.Items.Add("Button 12");

            // Generate the Items for Button Combo box

            cmbbtn.Items.Add("Button 1");
            cmbbtn.Items.Add("Button 2");
            cmbbtn.Items.Add("Button 3");
            cmbbtn.Items.Add("Button 4");
            cmbbtn.Items.Add("Button 5");
            cmbbtn.Items.Add("Button 6");
            cmbbtn.Items.Add("Button 7");
            cmbbtn.Items.Add("Button 8");
            cmbbtn.Items.Add("Button 9");
            cmbbtn.Items.Add("Button 10");
            cmbbtn.Items.Add("Button 11");
            cmbbtn.Items.Add("Button 12");


            cmbbtnS.Items.Add("1");
            cmbbtnS.Items.Add("2");
            cmbbtnS.Items.Add("3");
            cmbbtnS.Items.Add("4");
            cmbbtnS.Items.Add("5");
            cmbbtnS.Items.Add("6");
            cmbbtnS.Items.Add("7");
            cmbbtnS.Items.Add("8");
            cmbbtnS.Items.Add("9");
            cmbbtnS.Items.Add("10");
            cmbbtnS.Items.Add("11");
            cmbbtnS.Items.Add("12");

        }

        private void btnSaveFont_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSlctPage.Text != "--Select Page--")
            {
                if (cmbSlctPage.Text == "English")
                {
                    if (cmbFont.Text != "--Select Font Size--")
                    {
                        Settings.Default.btnEFont1 = cmbFont.Text;
                        Settings.Default.Save();
                        MessageBox.Show("Done","Information",MessageBoxButton.OK,MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Select the Font Size First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                        cmbFont.Focus();
                    }
                }
                else if (cmbSlctPage.Text == "Arabic")
                {
                    if (cmbFont.Text != "--Select Font Size--")
                    {
                        Settings.Default.btnAFont1 = cmbFont.Text;
                        Settings.Default.Save();
                        MessageBox.Show("Done", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Select the Font Size First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                        cmbFont.Focus();
                    }
                }
            
            }
            else
            {
                MessageBox.Show("Please Select a Page First","Stop",MessageBoxButton.OK,MessageBoxImage.Stop);
                cmbSlctPage.Focus();
            }

        }

        private void btnSaveColor_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSlctPage.Text != "--Select Page--")
            {
                if (cmbSlctPage.Text == "English")
                {
                    if (cmbColor.Text != "--Select Color--")
                    {
                        Settings.Default.btnEColor1 = cmbColor.Text;
                        Settings.Default.Save();
                        MessageBox.Show("Done", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Select the Color First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                        cmbColor.Focus();
                    }
                }
                else if (cmbSlctPage.Text == "Arabic")
                {
                    if (cmbColor.Text != "--Select Color--")
                    {
                        Settings.Default.btnAColor1 = cmbColor.Text;
                        Settings.Default.Save();
                        MessageBox.Show("Done", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Select the Color First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                        cmbColor.Focus();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select a Page First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                cmbSlctPage.Focus();
            }

        }

        private void btnSaveText_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSlctPage.Text != "--Select Page--")
            {
                if (cmbSlctPage.Text == "English")
                {
                    if (cmbText.Text != "--Select Button--")
                    {
                        if (cmbText.Text == "Button 1")
                        {
                            Settings.Default.btnEMovie1 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 2")
                        {
                            Settings.Default.btnEMovie2 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 3")
                        {
                            Settings.Default.btnEMovie3 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 4")
                        {
                            Settings.Default.btnEMovie4 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 5")
                        {
                            Settings.Default.btnEMovie5 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 6")
                        {
                            Settings.Default.btnEMovie6 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 7")
                        {
                            Settings.Default.btnEMovie7 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 8")
                        {
                            Settings.Default.btnEMovie8 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 9")
                        {
                            Settings.Default.btnEMovie9 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 10")
                        {
                            Settings.Default.btnEMovie10 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 11")
                        {
                            Settings.Default.btnEMovie11 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 12")
                        {
                            Settings.Default.btnEMovie12 = txtText.Text;
                        }

                        Settings.Default.Save();
                        MessageBox.Show("Done", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Select the Button First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                        cmbText.Focus();
                    }
                }
                else if (cmbSlctPage.Text == "Arabic")
                {
                    if (cmbText.Text != "--Select Button--")
                    {
                        if (cmbText.Text == "Button 1")
                        {
                            Settings.Default.btnAMovie1 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 2")
                        {
                            Settings.Default.btnAMovie2 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 3")
                        {
                            Settings.Default.btnAMovie3 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 4")
                        {
                            Settings.Default.btnAMovie4 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 5")
                        {
                            Settings.Default.btnAMovie5 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 6")
                        {
                            Settings.Default.btnAMovie6 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 7")
                        {
                            Settings.Default.btnAMovie7 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 8")
                        {
                            Settings.Default.btnAMovie8 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 9")
                        {
                            Settings.Default.btnAMovie9 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 10")
                        {
                            Settings.Default.btnAMovie10 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 11")
                        {
                            Settings.Default.btnAMovie11 = txtText.Text;
                        }
                        if (cmbText.Text == "Button 12")
                        {
                            Settings.Default.btnAMovie12 = txtText.Text;
                        }

                        Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Please Select the Button First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                        cmbText.Focus();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select a Page First", "Stop", MessageBoxButton.OK, MessageBoxImage.Stop);
                cmbSlctPage.Focus();
            }
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Settings.Default.pageInfo == "English")
            {
                var English = new English();
                English.Show();
                this.Close();
            }
            else
            {
                var Arabic = new Arabic();
                Arabic.Show();
                this.Close();
            }
        }

        private void Label_TouchDown(object sender, TouchEventArgs e)
        {
            if (Settings.Default.pageInfo == "English")
            {
                var English = new English();
                English.Show();
                this.Close();
            }
            else
            {
                var Arabic = new Arabic();
                Arabic.Show();
                this.Close();
            }
        }

        private void btnSelectVideo_Click(object sender, RoutedEventArgs e)
        {
            string filename;
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Title = "Please Select a file";
            Nullable<bool> result = openFileDialog.ShowDialog();
            if (result == true)
            {
                filename = openFileDialog.FileName;
            if (cmbSlctPage.Text != "--Select Page--")
            {
                if (cmbSlctPage.Text == "English")
                {
                    if (cmbbtn.Text =="Button 1")
                    {
                            Settings.Default.Movie1E = filename; 
                    }
                    if (cmbbtn.Text == "Button 2")
                    {
                            Settings.Default.Movie2E = filename;
                        }
                    if (cmbbtn.Text == "Button 3")
                    {
                            Settings.Default.Movie3E = filename;
                        }
                    if (cmbbtn.Text == "Button 4")
                    {
                            Settings.Default.Movie4E = filename;
                        }
                    if (cmbbtn.Text == "Button 5")
                    {
                            Settings.Default.Movie5E = filename;
                        }
                    if (cmbbtn.Text == "Button 6")
                    {
                            Settings.Default.Movie6E = filename;
                        }
                    if (cmbbtn.Text == "Button 7")
                    {
                            Settings.Default.Movie7E = filename;
                        }
                    if (cmbbtn.Text == "Button 8")
                    {
                            Settings.Default.Movie8E = filename;
                        }
                    if (cmbbtn.Text == "Button 9")
                    {
                            Settings.Default.Movie9E = filename;
                        }
                    if (cmbbtn.Text == "Button 10")
                    {
                            Settings.Default.Movie10E = filename;
                        }
                    if (cmbbtn.Text == "Button 11")
                    {
                            Settings.Default.Movie11E = filename;
                        }
                    if (cmbbtn.Text == "Button 12")
                    {
                            Settings.Default.Movie12E = filename;
                    }
                        Settings.Default.Save();


                }
                else if(cmbSlctPage.Text == "Arabic")
                {
                        if (cmbbtn.Text == "Button 1")
                        {
                            Settings.Default.Movie1A = filename;
                        }
                        if (cmbbtn.Text == "Button 2")
                        {
                            Settings.Default.Movie2A = filename;
                        }
                        if (cmbbtn.Text == "Button 3")
                        {
                            Settings.Default.Movie3A = filename;
                        }
                        if (cmbbtn.Text == "Button 4")
                        {
                            Settings.Default.Movie4A = filename;
                        }
                        if (cmbbtn.Text == "Button 5")
                        {
                            Settings.Default.Movie5A = filename;
                        }
                        if (cmbbtn.Text == "Button 6")
                        {
                            Settings.Default.Movie6A = filename;
                        }
                        if (cmbbtn.Text == "Button 7")
                        {
                            Settings.Default.Movie7A = filename;
                        }
                        if (cmbbtn.Text == "Button 8")
                        {
                            Settings.Default.Movie8A = filename;
                        }
                        if (cmbbtn.Text == "Button 9")
                        {
                            Settings.Default.Movie9A = filename;
                        }
                        if (cmbbtn.Text == "Button 10")
                        {
                            Settings.Default.Movie10A = filename;
                        }
                        if (cmbbtn.Text == "Button 11")
                        {
                            Settings.Default.Movie11A = filename;
                        }
                        if (cmbbtn.Text == "Button 12")
                        {
                            Settings.Default.Movie12A = filename;
                        }
                        Settings.Default.Save();

                    }
                }
            else
            {
                MessageBox.Show("Please Select the Page First","Information",MessageBoxButton.OK,MessageBoxImage.Stop);
                cmbSlctPage.Focus();
            }
            }

        }

        private void btnSelectVideo_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSlctPage.Text != "--Select Page--")
            {
                if (cmbSlctPage.Text == "English")
                {
                    if (cmbbtnS.Text == "1")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                        Settings.Default.vE1 = false;
                    }

                    if (cmbbtnS.Text == "2")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = false;
                        Settings.Default.vE4 = false;
                        Settings.Default.vE5 = false;
                        Settings.Default.vE6 = false;
                        Settings.Default.vE7 = false;
                        Settings.Default.vE8 = false;
                        Settings.Default.vE9 = false;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "3")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = false;
                        Settings.Default.vE5 = false;
                        Settings.Default.vE6 = false;
                        Settings.Default.vE7 = false;
                        Settings.Default.vE8 = false;
                        Settings.Default.vE9 = false;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "4")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = false;
                        Settings.Default.vE6 = false;
                        Settings.Default.vE7 = false;
                        Settings.Default.vE8 = false;
                        Settings.Default.vE9 = false;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "5")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = false;
                        Settings.Default.vE7 = false;
                        Settings.Default.vE8 = false;
                        Settings.Default.vE9 = false;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "6")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = true;
                        Settings.Default.vE7 = false;
                        Settings.Default.vE8 = false;
                        Settings.Default.vE9 = false;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "7")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = true;
                        Settings.Default.vE7 = true;
                        Settings.Default.vE8 = false;
                        Settings.Default.vE9 = false;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "8")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = true;
                        Settings.Default.vE7 = true;
                        Settings.Default.vE8 = true;
                        Settings.Default.vE9 = false;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "9")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = true;
                        Settings.Default.vE7 = true;
                        Settings.Default.vE8 = true;
                        Settings.Default.vE9 = true;
                        Settings.Default.vE10 = false;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "10")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = true;
                        Settings.Default.vE7 = true;
                        Settings.Default.vE8 = true;
                        Settings.Default.vE9 = true;
                        Settings.Default.vE10 = true;
                        Settings.Default.vE11 = false;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "11")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = true;
                        Settings.Default.vE7 = true;
                        Settings.Default.vE8 = true;
                        Settings.Default.vE9 = true;
                        Settings.Default.vE10 = true;
                        Settings.Default.vE11 = true;
                        Settings.Default.vE12 = false;
                    }

                    if (cmbbtnS.Text == "12")
                    {
                        Settings.Default.vE1 = true;
                        Settings.Default.vE2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vE4 = true;
                        Settings.Default.vE5 = true;
                        Settings.Default.vE6 = true;
                        Settings.Default.vE7 = true;
                        Settings.Default.vE8 = true;
                        Settings.Default.vE9 = true;
                        Settings.Default.vE10 = true;
                        Settings.Default.vE11 = true;
                        Settings.Default.vE12 = true;
                    }
                }
                else if(cmbSlctPage.Text == "Arabic")


                {
                    if (cmbbtnS.Text == "1")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                        Settings.Default.vA1 = false;
                    }

                    if (cmbbtnS.Text == "2")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = false;
                        Settings.Default.vA4 = false;
                        Settings.Default.vA5 = false;
                        Settings.Default.vA6 = false;
                        Settings.Default.vA7 = false;
                        Settings.Default.vA8 = false;
                        Settings.Default.vA9 = false;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "3")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vE3 = true;
                        Settings.Default.vA4 = false;
                        Settings.Default.vA5 = false;
                        Settings.Default.vA6 = false;
                        Settings.Default.vA7 = false;
                        Settings.Default.vA8 = false;
                        Settings.Default.vA9 = false;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "4")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = false;
                        Settings.Default.vA6 = false;
                        Settings.Default.vA7 = false;
                        Settings.Default.vA8 = false;
                        Settings.Default.vA9 = false;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "5")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = false;
                        Settings.Default.vA7 = false;
                        Settings.Default.vA8 = false;
                        Settings.Default.vA9 = false;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "6")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = true;
                        Settings.Default.vA7 = false;
                        Settings.Default.vA8 = false;
                        Settings.Default.vA9 = false;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "7")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = true;
                        Settings.Default.vA7 = true;
                        Settings.Default.vA8 = false;
                        Settings.Default.vA9 = false;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "8")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = true;
                        Settings.Default.vA7 = true;
                        Settings.Default.vA8 = true;
                        Settings.Default.vA9 = false;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "9")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = true;
                        Settings.Default.vA7 = true;
                        Settings.Default.vA8 = true;
                        Settings.Default.vA9 = true;
                        Settings.Default.vA10 = false;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "10")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = true;
                        Settings.Default.vA7 = true;
                        Settings.Default.vA8 = true;
                        Settings.Default.vA9 = true;
                        Settings.Default.vA10 = true;
                        Settings.Default.vA11 = false;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "11")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = true;
                        Settings.Default.vA7 = true;
                        Settings.Default.vA8 = true;
                        Settings.Default.vA9 = true;
                        Settings.Default.vA10 = true;
                        Settings.Default.vA11 = true;
                        Settings.Default.vA12 = false;
                    }

                    if (cmbbtnS.Text == "12")
                    {
                        Settings.Default.vA1 = true;
                        Settings.Default.vA2 = true;
                        Settings.Default.vA3 = true;
                        Settings.Default.vA4 = true;
                        Settings.Default.vA5 = true;
                        Settings.Default.vA6 = true;
                        Settings.Default.vA7 = true;
                        Settings.Default.vA8 = true;
                        Settings.Default.vA9 = true;
                        Settings.Default.vA10 = true;
                        Settings.Default.vA11 = true;
                        Settings.Default.vA12 = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select the Page First", "Information", MessageBoxButton.OK, MessageBoxImage.Stop);
                cmbSlctPage.Focus();
            }
        }
    }
}
