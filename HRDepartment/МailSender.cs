using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    static class МailSender
    {
        private const string DisapprovalMessage = "I regret to inform you that your request has been disapproved.";
        private const string ApprovalMessage = "I am pleased to inform you that your request has been approved.\nYour salary is";

        public static void SendApprove(KeyValuePair<Candidate, bool> candidateData)
        {
            var age = DateTime.Today.Year - candidateData.Key.DateOfBirth.Year;
            if (age < 18)
                throw new TooYoungException("We cannot hire an underage candidate", (byte)age);

            if (candidateData.Value)
            {
                Console.WriteLine($"{ApprovalMessage} {EmploeeDepartment.CalculateSalary(candidateData.Key)}");
            }
            else
            {
                Console.WriteLine(DisapprovalMessage);
            }
        }
    }
}
