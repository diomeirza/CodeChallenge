class TestClass
{
    private static Student a;
    public TestClass(Student student)
    {
        if (a == null)
            a = student;
    }
    public static void Print()
    {
        Console.WriteLine(a.Name);
    }
}

class Student
{
    public string Name { get; set; } = string.Empty;   
}