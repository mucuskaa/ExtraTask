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
            if (candidate.Experience == 0)
            {
                throw new DivideByZeroException();
            }

            return (uint)((10000 / candidate.Experience) / 0.4);
        }

    }
}
