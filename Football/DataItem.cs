using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class DataItem
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                name = value;
            }
        }
    }
}
