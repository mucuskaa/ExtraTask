using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    static class МailSender
    {
        public static void SendApprove(KeyValuePair<Candidate,bool> keyValuePair)
        {
            var age = DateTime.Today.Year - keyValuePair.Key.DateOfBirth.Year;
            if (age < 18)
                throw new TooYoungException("We cannot hire an underage candidate", (byte)age);

            if (keyValuePair.Value)
            {
                ApproveMessage(EmploeeDepartment.CalculateSalary(keyValuePair.Key));
            }
            else
            {
                DisapproveMessage();
            }
        }
        public static void ApproveMessage(uint salary)
        {
            Console.WriteLine($"I am pleased to inform you that your request has been approved.\nYour salary is {salary}");
        }
        public static void DisapproveMessage()
        {
            Console.WriteLine("I regret to inform you that your request has been disapproved.");
        }
    }
}
