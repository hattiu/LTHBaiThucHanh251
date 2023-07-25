using System.Collections;
using System.Collections.Specialized;
using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Person ps = new Person();
        string str = "Nguyen Van A";
        int a = 21;
        System.Console.WriteLine("{0} sinh nam {1}",str,ps.GetYearOfBirth(a));
        
        Student std = new Student();
        std.EnterData();
        std.HienThi();
        Person[] stdArray = new Person[5];
            int[] intArray = new int[4];
            for(int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Nhap phan tu  thu {0}:", i);
                Console.ReadLine();
                intArray[i] = 3;
            }
        //Khoi tao 
        ArrayList PersonList = new ArrayList();
        System.Console.WriteLine("nhap n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        //them 1 phan tu vao ArrayList
        
        PersonList.Add(n);
        //hien thi cac phan tu trong personlist su dung vong lap for
        for(int i=0; i<5; i++)
        {
            Person ps1 = (Person) PersonList[i];
            ps1.EnterData();
        }
        ////hien thi cac phan tu trong personlist su dung vong lap foreach
        foreach(Person ps1 in PersonList)
        {
            //Goi phuong thuc hien thi thong tin cua doi tuong kieu Person
            ps.HienThi();
        }
        Student std = new Student();
        System.Console.WriteLine("nhap : ");
        int n = Convert.ToInt32(Console.ReadLine());

        std.Add(n);
        
    }
}
