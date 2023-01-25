

using System.ComponentModel;
using GroupProject;

List<Person> team = new List<Person>()
{
    new Person("John G", 38),
    new Person("Josh S", 41),
    new Person("Earle F", 54)
};

foreach(Person p in team)
{
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Age);
}

Console.ReadLine();