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
using System.IO;
using PingPongWindowsForms;
namespace Football
{
    /// <summary>
    /// Interaction logic for Competition.xaml
    /// </summary>
    /// 
    public class Test1
    {
        public int id{get; set;}
        public string name { get; set; }
        public int point { get; set; }
    }
    public class Match
    {
        public string team1 { get; set; }
        public int goal1 { get; set; }
        public int goal2 { get; set; }
        public string team2 { get; set; }
    }
    public partial class Competition : Window
    {
        public void standings()
        {
            dataGrid.Items.Clear(); for (int i = 0; i < teams.Count; i++)
            {
                for (int j = 0; j < teams.Count - 1; j++)
                {
                    Team temp = new Team();
                    if (teams[j].Points < teams[j + 1].Points)
                    {
                        temp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < teams.Count; i++)
            {
                dataGrid.BeginEdit();
                var data = new Test1 { id = i + 1, name = teams[i].Name, point = teams[i].Points };
                dataGrid.Items.Add(data);
            }
        }
        private List<Team> teams = new List<Team>(0);
        private string myTeam;
        private int rounds;
        private string login;
        private bool music = false;
        private int level;
        private int time;
        public Competition(List<Team> teams, string myTeam, int rounds, string login, bool music, int level, int time)
        { 
            InitializeComponent();
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
            comboBox.SelectedIndex = 0;
            comboBox1.SelectedIndex = 1;
            this.teams = teams;
            this.myTeam = myTeam;
            this.rounds = rounds;
            this.login = login;
            this.music = music;
            this.level = level;
            this.time = time;
            this.standings();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            List<Player> players = new List<Player>(0);
            foreach (Team team in teams)
            {
                foreach (Player player in team.Squad)
                {
                    players.Add(player);
                }
            }
            for (int i=0; i<players.Count; i++)
            {
                for (int j=0; j<players.Count-1; j++)
                {
                    if (players[j].Goals<players[j+1].Goals)
                    {
                        Player temp = new Player();
                        temp = players[j];
                        players[j] = players[j+1];
                        players[j+1] = temp;
                    }
                }
            }
            for (int i=0; i<players.Count; i++)
            {
                listBox.Items.Add(players[i].Surname + " " + players[i].Goals);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TeamInfo teamInfo = new TeamInfo(teams);
            var result = teamInfo.ShowDialog();
            if (result == true)
            {
                listBox.Items.Clear();
                foreach (string c in teamInfo.Ans)
                {
                    listBox.Items.Add(c);
                } 
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PlayerInfo playerInfo = new PlayerInfo(teams);
            var result = playerInfo.ShowDialog();
            if (result==true)
            {
                listBox.Items.Clear();
                foreach (string c in playerInfo.Answer)
                {
                    listBox.Items.Add(c);
                }
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            string filename = "C:\\Users\\User\\Desktop\\competitions\\" + login + ".txt";
            FileStream fl = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fl);
            sw.WriteLine(myTeam);
            sw.WriteLine(rounds);
            foreach (Team team in teams)
            {
                sw.WriteLine(team.Name);
                sw.WriteLine(team.Points);
                foreach (Player player in team.Squad)
                {
                    sw.WriteLine(player.Surname);
                    sw.WriteLine(player.Goals);
                }
                sw.WriteLine("####");
            }
            sw.Close();
            fl.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int maxRounds = (teams.Count - (teams.Count + 1) % 2) * 2;
            if (rounds==maxRounds)
            {
                MessageBox.Show("Турнир окончен", "Инфо", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }
            dataGrid1.Items.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                for (int j = 0; j < teams.Count - 1; j++)
                {
                    Team temp = new Team();
                    if (String.Compare(teams[j].Name, teams[j+1].Name)==1)
                    {
                        temp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = temp;
                    }
                }
            }
            int n = teams.Count;
            bool[] used = new bool[n];
            for (int i=0; i<n; i++)
            {
                used[i] = false;
            }
            List<string> matches = new List<string>(0);
            bool d = false;
            if (n%2==1)
            {
                n++;
                d = true;
            }
            for (int i=0; i<n-1; i++)
            {
                int l = i+1;
                int r = n - l + 1;
                if(r==n)
                {
                    r = 1;
                }
                if (used[i]==true)
                {
                    continue;
                }


                for (int j=0; j<rounds; j++)
                {
                    r++;
                    if (r==n)
                    {
                        r = 1;
                    }
                }
                if (l == r)
                {
                    r = n;
                }
                r--;
                if (d==true)
                {
                    if (r==n-1)
                    {
                        continue;
                    }
                }
                used[i] = true;
                used[r] = true;
                matches.Add(teams[i].Name);
                matches.Add(teams[r].Name);
            }
            rounds++;
            if (rounds==maxRounds)
            {
                button4.Content = "Закончить турнир";
            }
            Random rand = new Random();
            for (int i=0; i<matches.Count; i=i+2)
            {
                string teamName1 = matches[i];
                string teamName2 = matches[i + 1];
                int teamGoal1=0;
                int teamGoal2 = 0;
                if (teamName1 == myTeam)
                {
  
                        FileStream fl1 = new FileStream("teams.txt", FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fl1);
                        sw.WriteLine(teamName1);
                        sw.WriteLine(teamName2);
                        sw.WriteLine(level);
                        sw.WriteLine(comboBox.SelectedIndex);
                        sw.WriteLine(comboBox1.SelectedIndex);
                        sw.WriteLine(time);
                        sw.Close();
                        fl1.Close();
                        Form1 game = new Form1();
                        game.ShowDialog();
                        FileStream fl = new FileStream("score.txt", FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fl);
                        teamGoal1 = int.Parse(sr.ReadLine());
                        teamGoal2 = int.Parse(sr.ReadLine());
                        sr.Close();
                        fl.Close();
                        //File.Delete("score.txt");

                }
                else if (teamName2 == myTeam)
                { 
                        FileStream fl1 = new FileStream("teams.txt", FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fl1);
                        sw.WriteLine(teamName2);
                        sw.WriteLine(teamName1);
                        sw.WriteLine(level);
                        sw.WriteLine(comboBox.SelectedIndex);
                        sw.WriteLine(comboBox1.SelectedIndex);
                        sw.WriteLine(time);
                        sw.Close();
                        fl1.Close();
                        Form1 game = new Form1();
                        game.ShowDialog();
                        FileStream fl = new FileStream("score.txt", FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fl);
                        teamGoal2 = int.Parse(sr.ReadLine());
                        teamGoal1 = int.Parse(sr.ReadLine());
                        sr.Close();
                        fl.Close();
                        //File.Delete("score.txt");
                   
                }
                else
                {
                    teamGoal1 = rand.Next(6);
                    teamGoal2 = rand.Next(6);
                }
               
                if (teamGoal1>teamGoal2)
                {
                    foreach(Team team in teams)
                    {
                        if (team.Name==teamName1)
                        {
                            team.Points += 3;
                        }
                    }
                }
                else if (teamGoal2>teamGoal1)
                {
                    foreach (Team team in teams)
                    {
                        if (team.Name == teamName2)
                        {
                            team.Points += 3;
                        }
                    }
                }
                else
                {
                    foreach (Team team in teams)
                    {
                        if (team.Name == teamName1)
                        {
                            team.Points += 1;
                        }
                        if (team.Name == teamName2)
                        {
                            team.Points += 1;
                        }
                    }
                }
                dataGrid.BeginEdit();
                var data = new Match { team1 = teamName1, goal1 = teamGoal1, goal2 = teamGoal2, team2 = teamName2 };
                dataGrid1.Items.Add(data);
                foreach(Team team in teams)
                {
                    if (team.Name == teamName1)
                    {
                        int cnt = team.Squad.Count;
                        for (int j = 0; j<teamGoal1; j++)
                        {
                            team.Squad[rand.Next(cnt)].Goals += 1;
                        }
                    }
                    if (team.Name == teamName2)
                    {
                        int cnt = team.Squad.Count;
                        for (int j = 0; j < teamGoal1; j++)
                        {
                            team.Squad[rand.Next(cnt)].Goals += 1;
                        }
                    }
                }
                this.standings();
            }

        }
    }
}
