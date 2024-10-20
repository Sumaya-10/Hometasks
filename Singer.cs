namespace _20okttask;

class Singer
{
    public string Name;
    public string Surname;
    public int Age;

    public Singer(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string name
    {
        get => Name;
        private set
        {
            if (Name.Length < 101)
                Name = Name;
            else
                Console.WriteLine("Ad cox uzundur");
        }
        
    }
    public string surname
    {
        get => Name;
        private set
        {
            if (Surname.Length < 101 )
                Name = Name;
            else
                Console.WriteLine("Soyad duzgun deyil!!!");
        }

    }
    public int age
    {
        get => Age;
        private set
        {
            if (Age > 0 || Age < 171)
                Age = age;
            else
                Console.WriteLine("yas yanlisdir!!!");
        }
    }
}
