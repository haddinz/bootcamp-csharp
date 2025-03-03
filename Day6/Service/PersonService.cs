delegate bool PersonDelegate(Person p);

class PersonService
{
    private List<Person> people = new();

    public void AddPerson(Person person)
    {
        people.Add(person);
    }

    public Person Find(PersonDelegate selector)
    {
        foreach (var p in people)
        {
            if (selector(p))
                return p;
        }
        return null;
    }

    public void Remove(PersonDelegate selector) {
        Person person = Find(selector);
        if (person != null) {
            people.Remove(person);
            Console.WriteLine($"\nRemove Id {person.Id} Successfully");
        } else {
            Console.WriteLine("\nRemove Person Id Not Found");
        }
    }

    public void PrintAll()
    {
        foreach (var p in people)
        {
            Console.WriteLine(p);
        }
    }
}
