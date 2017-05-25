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
        private int level;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        private int time = 2;
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        public Settings(bool music, int level, int time)
        {
            InitializeComponent();
            this.music = music;
            this.result = music;
            this.time = time;
            this.level = level;
            timeBox.SelectedIndex = time;
            if (level==1)
            {
                radioButton4.IsChecked = true;
            }
            else if (level==2)
            {
                radioButton5.IsChecked = true;
            }
            else if (level==3)
            {
                radioButton6.IsChecked = true;
            }
            else
            {
                radioButton7.IsChecked = true;
            }
            if (music ==true)
            {
                musicBox.IsChecked = true;
            }
            else
            {
                musicBox.IsChecked = false;
            }
            timeBox.Items.Add("1 минута");
            timeBox.Items.Add("1.5 минут");
            timeBox.Items.Add("3 минуты");
            timeBox.SelectedIndex = time;
        }
        private void submitbutton_Click(object sender, RoutedEventArgs e)
        {

            if (musicBox.IsChecked==true)
            {
                this.result = true;
            }
            else
            {
                this.result = false;
            }
            if (music != musicBox.IsChecked)
            {
                stayornot = false;
            }
            if (radioButton4.IsChecked==true)
            {
                this.level = 1;
            }
            if (radioButton5.IsChecked==true)
            {
                this.level = 2;
            }
            if (radioButton6.IsChecked==true)
            {
                this.level = 3;
            }
            if (radioButton7.IsChecked == true)
            {
                this.level = 4;
            }
            time = timeBox.SelectedIndex;
            DialogResult = true;
        }

        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            if (music != musicBox.IsChecked)
            {
                stayornot = false;
            }
            this.result = music;
            DialogResult = false;
            this.Close();
        }
    }
}
