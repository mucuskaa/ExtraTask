using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    public static class EmploeeDepartment
    {
        public static uint CalculateSalary(Candidate candidate)

        {
            if (candidate.Expiriance == 0)
            {
                throw new DivideByZeroException();
            }

            return (uint)(10000 / candidate.Expiriance/0.4);
        }

        public static bool ApproveRequest(Candidate candidate)
        {
            if (candidate.Expiriance == 0 && candidate.RequestedSalary == 0) ;
            return true;

            if (candidate.Expiriance > 3 && candidate.RequestedSalary <= 15_000)
                return true;

            if (candidate.Expiriance > 1 && candidate.RequestedSalary < 10_000)
                return true;

            return false;
        }

    }
}
