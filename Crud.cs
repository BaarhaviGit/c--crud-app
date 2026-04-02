using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== CRUD MENU =====");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Insert();
                    break;
                case 2:
                    Update();
                    break;
                case 3:
                    Delete();
                    break;
                case 4:
                    Display();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void Insert()
    {
        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        students.Add(new Student { Id = id, Name = name });
        Console.WriteLine("Inserted successfully!");
    }

    static void Update()
    {
        Console.Write("Enter Id to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = students.Find(s => s.Id == id);

        if (student != null)
        {
            Console.Write("Enter new Name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Updated successfully!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    static void Delete()
    {
        Console.Write("Enter Id to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = students.Find(s => s.Id == id);

        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Deleted successfully!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    static void Display()
    {
        Console.WriteLine("\n--- Student List ---");

        if (students.Count == 0)
        {
            Console.WriteLine("No data available!");
            return;
        }

        foreach (var s in students)
        {
            Console.WriteLine($"Id: {s.Id}, Name: {s.Name}");
        }
    }
}
