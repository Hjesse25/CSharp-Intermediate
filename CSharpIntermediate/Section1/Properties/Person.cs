namespace Properties;

public class Person
{
    // Auto implemented properties
    public DateTime Birthdate { get; private set; }
    public string? Name { get; set; }
    public string? Username { get; set; }

    // Constructor
    public Person(DateTime birthdate)
    {
        Birthdate = birthdate;
    }

    // Calculated properties
    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }
}
