using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_dgv
{
    public class CChild
    {
        public bool IsSelect { get; set; }
        public string Name { get; set; }
        public CChild(string name)
        {
            Name = name;
        }
    }
}
