namespace CSharpLearn.Linq
{
    internal class Education
    {
        static void Main(string[] args)
        {
            universityManager um = new universityManager();
            um.MaleStudents();
            um.FemaleStudents();
            Console.ReadKey();
        }
    }
    class universityManager
    {
        public List<Student> Students;
        public List<University> Universities;
        public universityManager()
        {
            Students = new List<Student>();
            Universities = new List<University>();
            // Adding some sample data
            Universities.Add(new University { Id = 1, Name = "Harvard" });
            Universities.Add(new University { Id = 2, Name = "MIT" });
            // Adding some sample students
            Students.Add(new Student
            {
                Id = 1,
                Name = "Alice",
                Gender = "Female",
                Age = 20,
                UniversityId = 1
            });
            Students.Add(new Student
            {
                Id = 2,
                Name = "Bob",
                Gender = "Male",
                Age = 22,
                UniversityId = 2
            });
            Students.Add(new Student 
            { 
                Id = 3, 
                Name = "Charlie", 
                Gender = "Male", 
                Age = 21, 
                UniversityId = 1 });
            Students.Add(new Student
            {
                Id = 4,
                Name = "Deeksha",
                Gender = "Female",
                Age = 23,
                UniversityId = 2
            });
        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in Students where student.Gender == "Male" select student;
            Console.WriteLine("Male - Students:");
            foreach (var student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in Students where student.Gender == "Female" select student;
            Console.WriteLine("Female - students:");
            foreach (var student in femaleStudents)
            {
                student.Print();
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        //foreign key
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("{0} with id {1} is {2} years old and is {3} from university {4}", Name, Id, Age, Gender, UniversityId);
        }
    }
    class University
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("University{0} with id{1}", Name, Id);
        }
    }
}
