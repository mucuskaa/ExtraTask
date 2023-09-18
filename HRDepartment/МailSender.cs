using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    static class МailSender
    {
        public static void Send(Candidate candidate)
        {
            var age = DateTime.Today.Year - candidate.DateOfBirth.Year;
            if (age < 18)
                throw new TooYoungException("We cannot hire an underage candidate", (byte)age);

            if (EmploeeDepartment.ApproveRequest(candidate))
            {
                ApproveMessage(EmploeeDepartment.CalculateSalary(candidate));
            }
            else
            {
                DisapproveMessage();
            }
        }
        private static void ApproveMessage(uint salary)
        {
            Console.WriteLine($"I am pleased to inform you that your request has been approved.\nYour salary is {salary}");
        }
        private static void DisapproveMessage()
        {
            Console.WriteLine("I regret to inform you that your request has been disapproved.");
        }
    }
}
