using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Tournament
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
        public Tournament(List<Team> teams)
        {
            this.Teams = teams;
        }
    }
}
