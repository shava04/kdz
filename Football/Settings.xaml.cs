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
            comboBox.SelectedIndex = time;
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
                checkBox1.IsChecked = true;
            }
            else
            {
                checkBox1.IsChecked = false;
            }
            comboBox.Items.Add("1 минута");
            comboBox.Items.Add("1.5 минут");
            comboBox.Items.Add("3 минуты");
            comboBox.SelectedIndex = time;
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
            time = comboBox.SelectedIndex;
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
