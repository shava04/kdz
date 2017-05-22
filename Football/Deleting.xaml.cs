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
    /// Interaction logic for Deleting.xaml
    /// </summary>
    public partial class Deleting : Window
    {
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
        public Deleting(List<Team>teams)
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
            foreach(Team team in teams)
            {
                if (team.Name == textBox.Text)
                {
                    ok = true;
                }
            }
            if (ok==false)
            {
                MessageBox.Show("Команды м таким названием не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            for (int i=0; i<teams.Count; i++)
            {
                if (teams[i].Name == textBox.Text)
                {
                    teams.Remove(teams[i]);
                }
            }
            DialogResult = true;
        }
    }
}
