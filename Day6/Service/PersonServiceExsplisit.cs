class PersonServiceExsplisit
{
    private List<Person> people = new();

    public void AddPerson(Person person)
    {
        people.Add(person);
    }

    public void PrintAll()
    {
        foreach (var p in people)
        {
            Console.WriteLine(p);
        }
    }

    public Person FindByFirstname(string firstname)
    {
        foreach (var p in people)
        {
            if (p.Firstname.Equals(firstname, StringComparison.OrdinalIgnoreCase))
                return p;
        }
        return null;
    }

    public Person FindByAge(int age)
    {
        foreach (var p in people)
        {
            if (p.Age == age)
                return p;
        }
        return null;
    }

    public Person FindByEmail(string email)
    {
        foreach (var p in people)
        {
            if (p.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                return p;
        }
        return null;
    }
}
