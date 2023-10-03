using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    public class Candidate : IComparable<Candidate>
    {
        public string Name { get; }
        public double Experience { get; }
        public DateTime DateOfBirth { get; }
        public int Age => DateTime.Today.Year - DateOfBirth.Year;
        public uint RequestedSalary { get; private set; }

        public Candidate(string name, double expiriance, DateTime dateOfBirth)
        {
            Name = name;
            Experience = expiriance;
            DateOfBirth = dateOfBirth;
        }
        public Candidate(string name, double expiriance, DateTime dateOfBirth, uint requestedSalary)
            : this(name, expiriance, dateOfBirth)
        {
            RequestedSalary = requestedSalary;
        }

        public int CompareTo(Candidate? other)
        {
            if (Experience < other.Experience)
                return -1;
            if (Experience > other.Experience)
                return 1;

            return 0;
        }

    }
}
