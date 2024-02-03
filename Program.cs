using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json; //add json namespace

namespace Serialization
{

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", 25, "New York"); //make object of student
            
            XmlSerializer serializer = new XmlSerializer(typeof(Student));//serialize object


            using(TextWriter writerJson = new StreamWriter("StudentJson.json"))//serialize object in json
            {
                writerJson.Write(JsonSerializer.Serialize(student));
            }

            using(TextReader readerJson = new StreamReader("StudentJson.json"))//deserialize object from json
            {
                Student studentJson = JsonSerializer.Deserialize<Student>(readerJson.ReadToEnd());
                Console.WriteLine(studentJson.ToString());
            }


            using (TextWriter writerXml = new StreamWriter("student.xml"))//put object in file
            {
                serializer.Serialize(writerXml, student);
            }

            using  (TextReader readerXml = new StreamReader("student.xml"))//deserialize object
            {Student student2 = (Student)serializer.Deserialize(readerXml);
                
                Console.WriteLine(student2.ToString());
            }




        }
    }
}