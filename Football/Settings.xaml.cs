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

namespace Football
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        private bool music;
        private bool stayornot = true;
        public bool Stayornot
        {
            get
            {
                return stayornot;
            }
            set
            {
                stayornot = value;
            }
        }
        private bool result;
        public bool Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }
        public Settings(bool music)
        {
            InitializeComponent();
            this.music = music;
            this.result = music;
            if (music ==true)
            {
                checkBox1.IsChecked = true;
            }
            else
            {
                checkBox1.IsChecked = false;
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (checkBox1.IsChecked==true)
            {
                this.result = true;
            }
            else
            {
                this.result = false;
            }
            if (music != checkBox1.IsChecked)
            {
                stayornot = false;
            }
            DialogResult = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (music != checkBox1.IsChecked)
            {
                stayornot = false;
            }
            this.result = music;
            DialogResult = false;
            this.Close();
        }
    }
}
