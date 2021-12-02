using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_dgv
{
    public class CParent
    {
        public bool IsSelect { get; set; }
        public string Name { get; set; }
        public List<CChild> CList { get; set; }

        public CParent(string name)
        {
            Name = name;
            CList = new List<CChild>();
        }
    }
}
