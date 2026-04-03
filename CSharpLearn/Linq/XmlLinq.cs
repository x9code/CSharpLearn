using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpLearn.Linq
{
    internal class XmlLinq
    {
        static void Main(string[] args)
        {
            string studentXml = @"<Students>
                                <Student>
                                    <Id>1</Id>
                                    <Name>Alice</Name>
                                    <University>Harvard</University>
                                    <year>2024</year>
                                </Student>
                                <Student>
                                    <Id>2</Id>
                                    <Name>Bob</Name>
                                    <University>MIT</University>
                                    <year>2023</year>
                                </Student>
                                <Student>
                                    <Id>3</Id>
                                    <Name>Charlie</Name>
                                    <University>Harvard</University>
                                    <year>2025</year>
                                </Student>
                             </Students>";

            XDocument studentXdoc = XDocument.Parse(studentXml);
            var students = from student in studentXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Id = student.Element("Id").Value,
                               University = student.Element("University").Value,
                               Year = student.Element("year").Value
                           };
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, University: {student.University}, Year: {student.Year}");
            }
            var sortedStudents = from student in students orderby student.Year select student;
            Console.WriteLine("\nSorted Students:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, University: {student.University},Year: {student.Year}");
            }
        }
    }
}
