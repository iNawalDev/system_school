using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- School System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Grade: ");
            double grade = double.Parse(Console.ReadLine());

            students.Add(new Student(id, name, age, grade));
            Console.WriteLine("Student added successfully");
        }

        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found");
                return;
            }

            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var s in students)
            {
                if (s.Id == id)
                {
                    Console.WriteLine(s);
                    return;
                }
            }

            Console.WriteLine("Student not found");
        }

        static void DeleteStudent()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                    Console.WriteLine("Student deleted");
                    return;
                }
            }

            Console.WriteLine("Student not found");
        }
    }

    class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public double Grade;

        public Student(int id, string name, int age, double grade)
        {
            Id = id;
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }
}
