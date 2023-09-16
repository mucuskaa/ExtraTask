namespace HRDepartment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var candidates = new List<Candidate>()
            {
                new Candidate("Lisa", 5, new DateTime(2015, 5, 11)),
                new Candidate("Alex", 3, new DateTime(2004, 12, 1)),
                new Candidate("Pammy", 1, new DateTime(2001, 12, 1)),
                new Candidate("Tomm", 0, new DateTime(2001, 12, 1))
            };

            foreach (var candidade in candidates)
            {
                try
                {
                    МailSender.Send(candidade);
                }
                catch (TooYoungException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
                catch (DivideByZeroException e)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();

                }
                catch (Exception)
                {
                    Console.WriteLine("Smt went wrong");
                }
            }
        }
    }
}