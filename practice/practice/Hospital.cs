namespace practice;

public class Hospital
{
    private List<Appointment> Appointments { get; set; }


    public Hospital()
    {
        Appointments = new List<Appointment>();
    }
    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
    }
    public void EndAppointment(int no)
    {
        var appointment = Appointments.FirstOrDefault(a => a.No == no);
        if (appointment != null && appointment.EndDate == null)
        {
            appointment.EndDate = DateTime.Now;
            Console.WriteLine($"gorus {no} bitdi.");
        }
        else if (appointment != null)
        {
            Console.WriteLine($"gorus {no} uje bitib.");
        }
        else
        {
            Console.WriteLine($"Gorus {no} yoxdu.");
        }
    }
    public Appointment GetAppointment(int no)
    {
        return Appointments.FirstOrDefault(a => a.No == no);
    }
    public List<Appointment> GetAllAppointments()
    {
        return Appointments;
    }
    public List<Appointment> GetWeeklyAppointments()
    {
        DateTime today = DateTime.Today;
        DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
        DateTime endOfWeek = startOfWeek.AddDays(7);

        List<Appointment> weeklyAppointments = new List<Appointment>();

        foreach (var appointment in Appointments)
        {
            if (appointment.StartDate >= startOfWeek && appointment.StartDate < endOfWeek)
            {
                weeklyAppointments.Add(appointment);
            }
        }
        return weeklyAppointments;
    }
    public List<Appointment> GetTodaysAppointments()
    {
        DateTime today = DateTime.Today;
        DateTime tomorrow = today.AddDays(1);

        List<Appointment> todaysAppointments = new List<Appointment>();

        foreach (var appointment in Appointments)
        {
            if (appointment.StartDate >= today && appointment.StartDate < tomorrow)
            {
                todaysAppointments.Add(appointment);
            }
        }

        return todaysAppointments;
    }
    public List<Appointment> GetAllContinuingAppointments()
    {
        List<Appointment> continuingAppointments = new List<Appointment>();

        foreach (var appointment in Appointments)
        {
            if (appointment.EndDate == null)
            {
                continuingAppointments.Add(appointment);
            }
        }

        return continuingAppointments;
    }
}