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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Media;
using PingPongWindowsForms;
namespace Football
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool music = true;
        public MainWindow()
        {
            InitializeComponent();
            if (music)
            {
                    SoundPlayer sp = new SoundPlayer("C:\\Users\\User\\Desktop\\music\\music1.wav");
                    sp.Play();
                
            }
            
        }
        public string log = "";
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            log = Autorization.log;
            if (log=="")
            {
                MessageBox.Show("Перед тем как начать играть авторизутесь!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string filename = "C:\\Users\\User\\Desktop\\competitions\\" + log + ".txt";
            if (File.Exists(filename))
            {
                FileStream fl = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fl);
                List<Team> teams = new List<Team>(0);
                Team team = new Team();
                Player player = new Player();
                int i = 0;
                string myTeam = sr.ReadLine();
                int rounds = int.Parse(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line =="####")
                    {
                        teams.Add(team);
                        i = 0;
                        team = new Team();
                        continue;
                    }
                    if (i==0)
                    {
                        team.Name = line;
                    }
                    else if (i==1)
                    {
                        team.Points = int.Parse(line);
                    }
                    else
                    {
                        if (i%2==0)
                        {
                            player.Surname = line;
                        }
                        else
                        {
                            player.Goals = int.Parse(line);
                            team.addPlayer(player);
                            player = new Player();
                        }
                    }
                    i++;
                }
                Competition comp = new Competition(teams, myTeam, rounds, log, music);
                comp.Show();
                return;
            }
            Squad cmp = new Squad(log, music);
            cmp.Show();
        }
        Random r = new Random();
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Settings st = new Settings(music);
            st.ShowDialog();
            string filename = "C:\\Users\\User\\Desktop\\music\\music" + (r.Next(2)+1).ToString() + ".wav";
            SoundPlayer sp = new SoundPlayer(filename);
            if (st.checkBox1.IsChecked==true && st.Stayornot==false && st.Result==true)
            {
                music = true;
               
                sp.Play();
            }
            else
            {
                if (st.Result==false)
                {
                    music = false;
                    sp.Stop();
                }
              
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Autorization a = new Autorization();
            a.Show();
        }
    }
}
