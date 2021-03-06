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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Football
{
    public class Test
    {
        public int test1 { get; set; }
        public string test2 { get; set; }
    }
    /// <summary>
    /// Interaction logic for Squad.xaml
    /// </summary>
    public partial class Squad : Window
    {
        private bool f = false;
        private string login;
        private bool music;
        private int level;
        private int time;
        public Squad(string log, bool music, int level, int time)
        {
            InitializeComponent();
            login = log;
            this.music = music;
            this.level = level;
            this.time = time;
        }
        private List<Team> teams = new List<Team>(0);
        public List<Team> Teams
        {
            get
            {
                return teams;
            }
            set
            {
                teams = value;
            }
        }
        private void beginbutton_Click(object sender, RoutedEventArgs e)
        {
            if (myTeamBox.Text=="")
            {
                MessageBox.Show("Введите название команды!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (teams.Count<4)
            {
                MessageBox.Show("Слишком мало команд", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string t = myTeamBox.Text;
            bool ok = false;
            for (int i=0; i<teams.Count; i++)
            {
                if (teams[i].Name==t)
                {
                    ok = true;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Данная команда не участвует в турнире", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            /*string filename = "C:\\Users\\User\\Desktop\\competitions\\" + login + ".txt";
            FileStream fl = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fl);
            sw.WriteLine(t);
            sw.WriteLine(0);
            foreach (Team team in teams)
            {
                sw.WriteLine(team.Name);
                sw.WriteLine(0);
                foreach (Player player in team.Squad)
                {
                    sw.WriteLine(player.Surname);
                    sw.WriteLine(0);
                }
                sw.WriteLine("####");
            }
            sw.Close();
            fl.Close();*/
            BinaryFormatter formatter = new BinaryFormatter();
            string filename = login + "savings.dat";
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, myTeamBox.Text);
                formatter.Serialize(fs, 0);
                formatter.Serialize(fs, teams.Count);
                foreach (Team team in teams)
                {
                    formatter.Serialize(fs, team.Name);
                    formatter.Serialize(fs, team.Points);
                    foreach (Player player in team.Squad)
                    {

                        formatter.Serialize(fs, player.Surname);
                        formatter.Serialize(fs, player.Goals);
                    }
                }
            }
            Competition cmp = new Competition(Teams, t, 0, login, music, level, time);
            cmp.Show();
            this.Close();

        }
        int i = 1;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (f==true)
            {
                MessageBox.Show("Команды по умолчанию уже загружены", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            f = true;
            dataGrid.BeginEdit();
            FileStream fl = new FileStream("squad.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fl);
            while (!sr.EndOfStream)
            {
                string teamname = sr.ReadLine();
                var data = new Test { test1 = i, test2 = teamname };
                dataGrid.Items.Add(data);
                i=i+1;
                string filename = "teams\\" + teamname + ".txt";
                FileStream fl1 = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fl1);
                List<Player> players = new List<Player>(0);
                while(!sr1.EndOfStream)
                {
                    string surname = sr1.ReadLine();
                    Player player = new Player(surname);
                    players.Add(player);
                }
                Team team = new Team(teamname, players, 0);
                this.Teams.Add(team);
                sr1.Close();
                fl1.Close();

            }
            sr.Close();
            fl.Close();
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            Adding adding = new Adding(teams);
            var result = adding.ShowDialog();
            if (result.Value)
            {
                // adding.team  
                dataGrid.BeginEdit();
                var data = new Test { test1 = i, test2 = adding.Team.Name };
                dataGrid.Items.Add(data);
                i++;
                this.Teams.Add(adding.Team);
            }
        }

        private void deletebutton_Click(object sender, RoutedEventArgs e)
        {
            Deleting deleting = new Deleting(teams);
            var result = deleting.ShowDialog();
            if (result.Value)
            {
                i--;
                dataGrid.BeginEdit();
                teams = deleting.Teams;
                dataGrid.Items.Clear();
                for (int j = 0; j<teams.Count; j++)
                {
                    var data = new Test { test1 = j + 1, test2 = teams[j].Name };
                    dataGrid.Items.Add(data);
                }
            }
        }
    }
}
