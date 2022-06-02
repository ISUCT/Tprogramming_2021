using System;


public class Testing : MonoBehaviour
{
    public void Start()
    {
        MyClass myClass = new MyClass();
        TestInterface(myClass);

    }

    private void TestInterface(IMyInterface myInterface)
    {
        myInterface.TestFunction();
    }
}

public class MonoBehaviour
{
}

public interface IMyInterface
{

    void TestFunction()
    {
    }
}

public class MyClass : IMyInterface
{
    public void TestFunction()
    {
        Console.WriteLine("MyClass.TestFunction()");
    }
}

class Program
{

    static void Main(string[] args)
    {
        Testing Testing = new Testing();
        Testing.Start();





    }
}