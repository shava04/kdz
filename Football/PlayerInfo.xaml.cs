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
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {
        private List<Team> teams = new List<Team>(0);
        private List<string> answer = new List<string>(0);
        public List<string> Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }
        public PlayerInfo(List<Team>teams)
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
            if (textBox1.Text=="")
            {
                MessageBox.Show("Фамилия игрока не введена", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            bool ok = false;
            Player ans = new Player();
            foreach (Team team in teams)
            {
                if (team.Name==textBox.Text)
                {
                    foreach (Player player in team.Squad)
                    {
                        if (player.Surname==textBox1.Text)
                        {
                            ans = player;
                            ok = true;
                        }
                        if (ok==true)
                        {
                            break;
                        }
                    }
                }
                if (ok==true)
                {
                    break;
                }
            }
            if (ok==false)
            {
                answer.Add("Игрок не найден");
            }
            else
            {
                answer = ans.getInfo();
            }
            DialogResult = true;
        }
    }
}
