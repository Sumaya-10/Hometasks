namespace ExceptionTask;

public class MeetingSchedule
{
    private List<Meeting> Meetings { get; set; } = new List<Meeting>();
    public void SetMeeting( string fullName, DateTime fromDate, DateTime toDate)
    {

        if (fromDate >= toDate)
        {
            throw new WrongDateIntervalException();
        }
        foreach (var meeting in Meetings)
        {
            if ((fromDate < meeting.ToDate) && (toDate > meeting.FromDate))
            {
                throw new ReservedDateIntervalException();
            }
        }
            var newMeeting = new Meeting(fromDate, toDate, fullName);
            Meetings.Add(newMeeting);
        Console.WriteLine(fullName+"  elave edildi");
    }
}
