using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public  class Team
    {
        public Team()
        {
            this.Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator{ get; set; }
        public List<string> Members { get; set; }

    }
}
