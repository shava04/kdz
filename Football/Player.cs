using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Football
{
    public class Player 
    {
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        private int goals;
        public int Goals
        {
            get
            {
                return goals;
            }
            set
            {
                goals = value;
            }
        }
        public Player(string surname)
        {
            this.surname = surname;
            this.goals = 0;
        }
        public Player()
        {

        }
        public Player(string surname, int goals)
        {
            this.surname = surname;
            this.goals = goals;
        }
        public List<string> getInfo()
        {
            List<string> ans = new List<string>(0);
            ans.Add("Фамилия игрока: " + this.surname);
            ans.Add("Количество голов: " + this.goals);
            return ans;
        }
    }
}
