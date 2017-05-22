using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Football
{
    public class Team
    {
        public Team()
        {

        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int points;
        public int Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }
        private List<Player> squad = new List<Player>(0);
        public List<Player> Squad
        {
            get
            {
                return squad;
            }
            set
            {
                squad = value;
            }
        }
        public Team(string name, List<Player>squad, int points)
        {
            this.name = name;
            this.squad = squad;
            this.points = points;
        }
        public void addPlayer(Player player)
        {
            squad.Add(player);
        }
        public void addPlayers(string file)
        {
            FileStream fl = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fl);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Player pl = new Player(line);
                squad.Add(pl);
            }
            sr.Close();
            fl.Close();
        }
        public List<string> getInfo()
        {
            List<string> ans = new List<string>(0);
            ans.Add("Название команды: " + this.Name);
            ans.Add("Количеств очков: " + this.Points);
            ans.Add("Состав:");
            foreach (Player player in this.Squad)
            {
                for (int i = 0; i<player.getInfo().Count; i++)
                {
                    ans.Add(player.getInfo()[i]);
                }
            }
            return ans;
        }
    }
}
