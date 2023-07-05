class TestRun
{
    public static void Run()
    {
        Student a = new Student();
        a.Name = "Dio";
        TestClass test = new TestClass(a);
        TestClass.Print();
        Student b = new Student();
        b.Name = "allegro";

        a.Name=b.Name;
        test = new TestClass(b);
        TestClass.Print();
        a.Name = "ION";
        test = new TestClass(a);
        TestClass.Print();
    }
}