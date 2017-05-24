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
    /// Interaction logic for Clothes.xaml
    /// </summary>
    public partial class Clothes : Window
    {
        private string teamName1;
        private string teamName2;
        private int cloth1 = 0;
        public int Cloth1
        {
            get
            {
                return cloth1;
            }
            set
            {
                cloth1 = value;
            }
        }
        private int cloth2 = 1;
        public int Cloth2
        {
            get
            {
                return cloth2;
            }
            set
            {
                cloth2 = value;
            }
        }
        public Clothes(string teamName1, string teamName2)
        {
            InitializeComponent();
            this.teamName1 = teamName1;
            this.teamName2 = teamName2;
            label.Content = teamName1;
            label1.Content = teamName2;
            comboBox.Items.Add("black");
            comboBox.Items.Add("orange");
            comboBox.Items.Add("blue");
            comboBox.Items.Add("red");
            comboBox.Items.Add("yellow");
            comboBox1.Items.Add("black");
            comboBox1.Items.Add("orange");
            comboBox1.Items.Add("blue");
            comboBox1.Items.Add("red");
            comboBox1.Items.Add("yellow");



        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            cloth1 = comboBox.SelectedIndex;
            cloth2 = comboBox1.SelectedIndex;
            DialogResult = true;
        }
    }
}
