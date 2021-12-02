using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_dgv
{
    public class CParentGroup
    {
        public List<CParent> PList { get; set; }

        public CParentGroup()
        {
            PList = new List<CParent>();
        }
    }
}
