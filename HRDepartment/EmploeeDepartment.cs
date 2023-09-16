using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    public static class EmploeeDepartment
    {
        public static uint CalculateSalary(Candidate candidate)=> (uint)(10000 / candidate.Expiriance);
        

        public static bool ApproveRequest(Candidate candidate)
        {
            if (candidate.Name.Length>3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
