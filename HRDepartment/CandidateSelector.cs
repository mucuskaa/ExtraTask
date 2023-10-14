using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    public static class CandidateSelector
    {
        public static SortedDictionary<Candidate, bool> SelectCandidates(int quota, List<Candidate> candidates)
        {
            var sortedCandidates = candidates.OrderByDescending(candidate => candidate.Experience)
                .Where(candidate => candidate.Age >= 18 && candidate.Age <= 35)
                .Take(quota)
                .ToDictionary(candidate => candidate, v => true);

            return new SortedDictionary<Candidate, bool>(sortedCandidates);
        }
    }
}
