using System;
using System.Collections.Generic;

class Person
{
    public string Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public Person(string id, string firstname, string lastname, int age, string email)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
        Age = age;
        Email = email;
    }

    public override string ToString()
    {
        return $"Id: {Id}, {Firstname} {Lastname}, Age: {Age}, Email: {Email}";
    }
}
