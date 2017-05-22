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
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Window
    {
        private List<Team> teams = new List<Team>(0);
        private List<string> ans;
        public List<string> Ans
        {
            get
            {
                return ans;
            }
            set
            {
                ans = value;
            }
        }
        public TeamInfo(List<Team>teams)
        {
            InitializeComponent();
            this.teams = teams;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text=="")
            {
                MessageBox.Show("Название команды не введено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            bool ok = false;
            Team answer = new Team();
            foreach (Team team in teams)
            {
                if (textBox.Text == team.Name)
                {
                    ok = true;
                    answer = team;
                    break;
                }
            }
            Ans = answer.getInfo();
            DialogResult = true;
        }
    }
}
