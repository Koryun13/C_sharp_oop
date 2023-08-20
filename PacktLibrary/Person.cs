namespace Packt.Shared;
using System.Collections.Generic;
public  partial class Person : System.Object
{
    public string name;
    public DateTime DateofBirth;
    public AncientWonders FavoriteWonder;
    public AncientWonders BucketList;
    public List<Person> Children = new List<Person>();
    public const string Species = "Homo Sapien";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    //public static string birth

    public  Person()
    {
        name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    static Person()
    {
        Console.WriteLine("this is Static!!!");
    }

    public static Person Procreate(Person p1, Person p2)
    {
        var baby = new Person
        {
            name = $"Baby of {p1.name} and {p2.name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }
    public Person PorcreateWith(Person partner)
    {
        return Procreate(this,partner);
    }


    public static Person operator *(Person p1, Person p2)
    {
        return Person.Procreate(p1,p2);
    }

    public void WriteToConsole()
    {
       Console.WriteLine($"{name} was born on a {DateofBirth:dddd}.");
    }

    public override string ToString()
    {
        return $"{name} is a {base.ToString()}";
    }
}

