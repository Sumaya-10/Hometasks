namespace practice;

internal class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        Appointment gorus = new Appointment(1, "Sumaya Mammadova", "Naciba", new DateTime(2024,10,31,9,0,0), new DateTime(2024, 10, 31, 11, 0, 0));
        int code = 0;

        bool proses = true;

        while (proses)
        {
            Console.WriteLine("1. Appointment yarat");
            Console.WriteLine("2. Appointment-i bitir");
            Console.WriteLine("3. Bütün appointment-lərə bax");
            Console.WriteLine("4. Bu həftəki appointment-lərə bax");
            Console.WriteLine("5. Bugünki appointment-lərə bax");
            Console.WriteLine("6. Bitməmiş appointmentlərə bax");
            Console.WriteLine("7. Menudan çıx");
            Console.Write("Seçiminizi edin: "); 
           code = Convert.ToInt32(Console.ReadLine());
            //string choice = Console.ReadLine();

            switch (code)
            {
                case 1:
                    hospital.AddAppointment(gorus);
                    Console.WriteLine("Appointment yaradıldı.");
                    break;
                case 2:
                    hospital.EndAppointment(1);
                    break;
                case 3:
                    hospital.GetAllAppointments();

                    break;

                case 4:
                    hospital.GetWeeklyAppointments();
                    break;
                case 5:
                    hospital.GetTodaysAppointments();
                    break;
                case 6:
                    hospital.GetAllContinuingAppointments();
                    break;
                case 7:
                    proses = false;
                    break;
                default:
                    Console.WriteLine("elcek");
                    break;
            }

        }
    }
}

