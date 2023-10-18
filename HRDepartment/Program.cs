﻿namespace HRDepartment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var candidates = new List<Candidate>
            {
                new Candidate("Lisa", 5, new DateTime(2014, 5, 11),4000),
                new Candidate("Lis", 5.4, new DateTime(2000, 5, 11),5000),
                new Candidate("Alex", 4.2, new DateTime(2004, 12, 1),6000),
                new Candidate("Pammy", 1, new DateTime(2014, 12, 1),1000),
                new Candidate("Tomm", 0, new DateTime(1990, 12, 1),9000),
                new Candidate("Tom", 2, new DateTime(1991, 12, 1),9000)
            };

            var sortedCandidades = CandidateSelector.SelectCandidates(2, candidates);

            foreach (var candidate in sortedCandidades)
            {
                try
                {
                    Console.WriteLine($"{candidate.Key.Name} - {(candidate.Value ? "Employed" : "Not employed")}");
                    МailSender.SendApprove(candidate);
                    Console.WriteLine(new string('-', 20));
                }
                catch (TooYoungException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine(new string('-', 20));
                }
                catch (DivideByZeroException e)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine(new string('-', 20));

                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }

            }
        }
    }
}