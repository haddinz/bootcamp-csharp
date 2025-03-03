class Program
{
    static void Main()
    {
        PersonService peopleService = new PersonService();

        // Menambahkan beberapa orang ke koleksi
        peopleService.AddPerson(new Person("1", "John", "Doe", 30, "john.doe@example.com"));
        peopleService.AddPerson(new Person("2", "Alice", "Smith", 25, "alice.smith@example.com"));
        peopleService.AddPerson(new Person("3", "Bob", "Brown", 40, "bob.brown@example.com"));
        peopleService.AddPerson(new Person("4", "Bob", "Brown", 40, "bob.brown@example.com"));
        peopleService.AddPerson(new Person("5", "Bob", "Brown", 40, "bob.brown@example.com"));
        peopleService.AddPerson(new Person("6", "Bob", "Brown", 40, "bob.brown@example.com"));

        Console.WriteLine("Daftar semua orang before:");
        peopleService.PrintAll();

        PersonDelegate findAlice = (Person p) => p.Firstname == "Alice";
        Person result1 = peopleService.Find(findAlice);
        Console.WriteLine("\nResult find by firstname: " + (result1 != null ? result1.ToString() : "firstname is not found"));

        PersonDelegate olderThan35 = (Person p) => p.Age > 35;
        Person result2 = peopleService.Find(olderThan35);
        Console.WriteLine("\nResult find by age: " + (result1 != null ? result2.ToString() : "age is not found"));

        PersonDelegate findByEmail = (Person p) => p.Email == "john.doe@example.com";
        Person result3 = peopleService.Find(findByEmail);
        Console.WriteLine("\nResult find by email: " + (result1 != null ? result3.ToString() : "email is not found"));

        PersonDelegate findById = (Person p) => p.Id == "2";
        Person personId = peopleService.Find(findById);
        Console.WriteLine("\nResult find by personId: " + (result1 != null ? personId.ToString() : "person id is not found"));

        PersonDelegate removePersonById = (Person p) => p.Id == "5";
        peopleService.Remove(removePersonById);

        Console.WriteLine("\nDaftar semua orang after:");
        peopleService.PrintAll();

        Console.WriteLine("=======================================================================================");

        PersonServiceExsplisit peopleServiceExsplisit = new();

        peopleServiceExsplisit.AddPerson(new Person("4", "John", "Doe", 30, "john.doe@example.com"));
        peopleServiceExsplisit.AddPerson(new Person("5", "Lukas", "Brown", 27, "lukas.brown@example.com"));
        peopleServiceExsplisit.AddPerson(new Person("6", "Bob", "Brown", 40, "bob.brown@example.com"));


        Console.WriteLine("Daftar semua orang:");
        peopleServiceExsplisit.PrintAll();

        Person resultExs1 = peopleServiceExsplisit.FindByFirstname("Alice");
        Console.WriteLine("\nHasil pencarian untuk 'Alice': " + (resultExs1 != null ? resultExs1.ToString() : "Tidak ditemukan"));

        Person resultExs2 = peopleServiceExsplisit.FindByAge(40);
        Console.WriteLine("\nHasil pencarian orang berusia 40 tahun: " + (resultExs2 != null ? resultExs2.ToString() : "Tidak ditemukan"));

        Person resultExs3 = peopleServiceExsplisit.FindByEmail("john.doe@example.com");
        Console.WriteLine("\nHasil pencarian berdasarkan email: " + (resultExs3 != null ? resultExs3.ToString() : "Tidak ditemukan"));

    }
}
