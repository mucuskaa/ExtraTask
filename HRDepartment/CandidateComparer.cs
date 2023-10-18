using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    internal class CandidateComparer : IComparer<Candidate>
    {
        public int Compare(Candidate? x, Candidate? y)
        {
            if (x == null || y == null) return 0;
            return y.Experience.CompareTo(x.Experience);
        }
    }
}
