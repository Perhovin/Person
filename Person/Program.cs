using System.Runtime.CompilerServices;

class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set 
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }

    public Person(string name, int age)
    {
        Name = name; 
        Age = age; 
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name {Name}, Age {Age}");
    }
}
class Program
{
    static void Main()
    {
         Person Person1 = new Person("Misha", 18);
         Person1.PrintInfo();
    }

}