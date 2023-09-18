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
        public double Expiriance { get; }
        public DateTime DateOfBirth { get; }
        public uint RequestedSalary { get; set; }

        public Candidate(string name, double expiriance, DateTime dateOfBirth)
        {
            Name = name;
            Expiriance = expiriance;
            DateOfBirth = dateOfBirth;
        }
        public Candidate(string name, double expiriance, DateTime dateOfBirth, uint requestedSalary)
            : this(name, expiriance, dateOfBirth)
        {
            RequestedSalary = requestedSalary;
        }


        public int CompareTo(Candidate? other)
        {
            if ((int)this.Expiriance > (int)other.Expiriance)
                return 1;
            if ((int)this.Expiriance < (int)other.Expiriance)
                return -1;
            return 0;
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Candidate;
            return (int)Expiriance == (int)other.Expiriance;
        }
       
        public override int GetHashCode()
        {
            return (int)Expiriance.GetHashCode();
        }

        public static bool operator ==(Candidate candidate1,Candidate candidate2)
        {
            return candidate1.Equals(candidate2);
        }
        public static bool operator !=(Candidate candidate1,Candidate candidate2)
        {
            return !candidate1.Equals(candidate2);
        }
    }
}
