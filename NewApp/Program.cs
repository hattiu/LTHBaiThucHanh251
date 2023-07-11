using  NewApp.Models;

public class Program 
{
    private static void Main(string[] args)
    {
        //khoi tao hai doi tuong tu class Person
        Person ps = new Person();
        
        //gan gia tri ch thuoc tinh doi tuong ps1
        string str = "Nguyen Van A";
        int a  = 22;
        Console.WriteLine("{0} sinh nam {1}", str, ps.GetYearOfBirth(a));
    }
        

}