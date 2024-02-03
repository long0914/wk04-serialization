using System;
using System.IO;
using System.Xml.Serialization;

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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", 25, "New York"); //make object of student
            Student student1 = new Student("long", 36, "New York");
            XmlSerializer serializer = new XmlSerializer(typeof(Student));//serialize object
            XmlSerializer serializer1 = new XmlSerializer(typeof(Student));
            using (TextWriter writer = new StreamWriter("student.xml"))//put object in file
            {
                serializer.Serialize(writer, student);
                serializer1.Serialize(writer, student1);
            }
        }
    }
}