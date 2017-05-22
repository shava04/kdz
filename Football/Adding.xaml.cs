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

        }
        // Make field + property
        public Team team = new Team();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;
            if (textBox.Text=="")
            {
                flag = false;
            }
            if (textBox1.Text == "")
            {
                flag = false;
            }
            if (textBox2.Text == "")
            {
                flag = false;
            }
            if (textBox3.Text == "")
            {
                flag = false;
            }
            if (textBox4.Text == "")
            {
                flag = false;
            }
            if (textBox5.Text == "")
            {
                flag = false;
            }
            if (textBox6.Text == "")
            {
                flag = false;
            }
            if (textBox7.Text == "")
            {
                flag = false;
            }
            if (textBox8.Text == "")
            {
                flag = false;
            }
            if (textBox9.Text == "")
            {
                flag = false;
            }
            if (textBox10.Text == "")
            {
                flag = false;
            }
            if (textBox11.Text=="")
            {
                flag = false;
            }
            if (flag==false)
            {
                MessageBox.Show("ОНекорректные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
            Player player1 = new Player(textBox1.Text);
            Player player2 = new Player(textBox2.Text);
            Player player3 = new Player(textBox3.Text);
            Player player4 = new Player(textBox4.Text);
            Player player5 = new Player(textBox5.Text);
            Player player6 = new Player(textBox6.Text);
            Player player7 = new Player(textBox7.Text);
            Player player8 = new Player(textBox8.Text);
            Player player9 = new Player(textBox9.Text);
            Player player10 = new Player(textBox10.Text);
            Player player11 = new Player(textBox11.Text);
            List<Player> squad = new List<Player>();
            squad.Add(player1);
            squad.Add(player2);
            squad.Add(player3);
            squad.Add(player4);
            squad.Add(player5);
            squad.Add(player6);
            squad.Add(player7);
            squad.Add(player8);
            squad.Add(player9);
            squad.Add(player10);
            squad.Add(player11);
            team = new Team(textBox.Text, squad, 0);
            DialogResult = true;
        }
    }
}
