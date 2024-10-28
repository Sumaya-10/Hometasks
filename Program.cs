namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule schedule = new MeetingSchedule();

            try
            {
                schedule.SetMeeting("Suma Mammadova", new DateTime(2024, 10, 25, 9, 0, 0), new DateTime(2024, 10, 25, 10, 0, 0));
                schedule.SetMeeting("Naciba Rasulova", new DateTime(2024, 10, 25, 10, 0, 0), new DateTime(2024, 10, 25, 11, 0, 0));
                schedule.SetMeeting("ruslan bayramov", new DateTime(2023, 10, 25, 9, 30, 0), new DateTime(2023, 10, 25, 12, 30, 0));
            }
            catch (ReservedDateIntervalException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongDateIntervalException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class ReservedDateIntervalException : Exception
    {
        public ReservedDateIntervalException() : base(" tarix intervalinda meeting var") { }
    }

    public class WrongDateIntervalException : Exception
    {
        public WrongDateIntervalException() : base("fromdate todate-den kicik deyil") { }
    }
}
