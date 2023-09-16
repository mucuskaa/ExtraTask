using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    public class Candidate
    {
        public string Name { get; }  
        public byte Expiriance { get; }
        public DateTime DateOfBirth { get; }
        public uint RequestedSalary { get; set; }

        public Candidate(string name,byte expiriance, DateTime dateOfBirth) 
        {
            Name=name;
            Expiriance = expiriance;
            DateOfBirth = dateOfBirth;
        }
        public Candidate(string name, byte expiriance, DateTime dateOfBirth, uint requestedSalary)
            :this(name, expiriance, dateOfBirth)
        {
            RequestedSalary = requestedSalary;
        }
    }
}
