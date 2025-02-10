
public class Person
{
    public int age { get; set; }
    public string name { get; set; }
}

public class Student: Person
{
    public int rollName { get; set; }
    public string course {  get; set; }
}

public class GraduateStudent : Student
{
    public String thesisTitle { get; set; }
    public int graduationYear { get; set; }

    public void display()
    {
        Console.WriteLine($"Student Name = {name}, Age = {age}, Roll = {rollName} , Course = {course}, Thesis Title = {thesisTitle} and Graduation Year = {graduationYear} ");
    }
}

public class Program
{
    public static void Main()
    {
        GraduateStudent student = new GraduateStudent 
        { age = 24, 
          name = "Arian",
          rollName = 1904115, 
          course = "Machine Learning",
          thesisTitle = "Livestock Disease Prediction using Machine Learning and Explainable AI", 
          graduationYear = 2025 
        };
        student.display();

    }
}