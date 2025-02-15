public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 10;
        int y = 0;
        if (y != 0)
        {
            int z = x / y;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}