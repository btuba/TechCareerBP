using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public class Report
    {
        public static readonly Report Instance = new Report();

        public int UserCount { get; set; }
        public int DocumentCount { get; set; }
    }
}
