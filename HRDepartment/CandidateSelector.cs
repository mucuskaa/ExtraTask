using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    public class CandidateSelector
    {
        public SortedDictionary<Candidate, bool> SelectCandidates(int quota, MyCollection<Candidate> candidates)
        {
            var selectedCandidates = new SortedDictionary<Candidate, bool>();
            candidates.OrderBy(c => c.Experience).ToList();

            foreach (var candidate in candidates)
            {
                if (quota > 0 && candidate.Age >= 18 && candidate.Age <= 35)
                {
                    selectedCandidates[candidate] = true;
                    quota--;
                }
                else
                {
                    selectedCandidates[candidate] = false;
                }

            }

            return selectedCandidates;
        }
    }
}
