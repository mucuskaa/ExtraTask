using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    public class MyCollection <Candidate>: IEnumerable<Candidate>
    {
        private readonly Candidate[] _candidates;
        public MyCollection(Candidate[] newList)
        {
            _candidates = new Candidate[newList.Length];
            _candidates=newList;
        }

        public IEnumerator<Candidate> GetEnumerator()
        {
            foreach (Candidate candidate in _candidates)
            {
                yield return candidate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
