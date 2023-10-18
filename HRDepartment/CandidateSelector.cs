using System;
using System.Collections;
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
            var sortedDic = new SortedDictionary<Candidate, bool>(candidates.ToDictionary(candidate => candidate, v => false), new CandidateComparer());

            int i = 0;
            int count = 0;

            while (i < sortedDic.Count && count < quota)
            {
                var candidateData = sortedDic.ElementAt(i);

                if (candidateData.Key.Age >= 18 && candidateData.Key.Age <= 35)
                {
                    sortedDic[candidateData.Key] = true;
                    count++;

                }
                i++;
            }

            return sortedDic;
        }
    }
}
