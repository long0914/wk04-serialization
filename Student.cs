namespace Serialization
{
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
        }

        public override string ToString(){
            return Name + " " + Age + " " + Address;
        }
    }
}