public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Student(string name, int age, string address)
    {
        this.Name = name;
        this.Age = age;
        this.Address = address;
    }

    public Student()
{
    Name = "Default Name";
    Address = "Default Address";
}// Corrected parameterless constructor
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("John", 25, "New York");
    }
}