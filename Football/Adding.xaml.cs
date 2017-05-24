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
    /// Interaction logic for Adding.xaml
    /// </summary>
    public partial class Adding : Window
    {
        private List<Team> teams = new List<Team>(0);

        public Adding(List<Team>teams)
        {
            InitializeComponent();
            this.teams = teams;
            textboxes.Add(textBox);
            textboxes.Add(textBox1);
            textboxes.Add(textBox2);
            textboxes.Add(textBox3);
            textboxes.Add(textBox4);
            textboxes.Add(textBox5);
            textboxes.Add(textBox6);
            textboxes.Add(textBox7);
            textboxes.Add(textBox8);
            textboxes.Add(textBox9);
            textboxes.Add(textBox10);
            textboxes.Add(textBox11);
        }
        // Make field + property
        private Team team = new Team();
        public Team Team
        {
            get
            {
                return team;
            }
            set
            {
                team = value;
            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private List<TextBox> textboxes = new List<TextBox>(0);
        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;
            foreach(TextBox element in textboxes)
            {
                if (element.Text=="")
                {
                    flag = false;
                }
            } 
            if (flag==false)
            {
                MessageBox.Show("Некорректные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                //this.Close();
            }
            foreach (Team team in teams)
            {
                if (team.Name==textBox.Text)
                {
                    MessageBox.Show("Команда с таким названием уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            List<Player> squad = new List<Player>();
            foreach (TextBox element in textboxes)
            {
                Player player = new Player(element.Text);
                squad.Add(player);
            }
            team = new Team(textBox.Text, squad, 0);
            DialogResult = true;
        }
    }
}
