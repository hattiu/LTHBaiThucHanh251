public class Program
{
    
    private static void Main(string [] args)
    {
        //Khai bao bie kieu string va gan gia tri = Nguyen Van A
       
        string hoTen = "Nguyen Van A";
        //Khai bao bien kieu in vaf gans gia tri  = 123456
        int maSinhVien = 123456;
        Console.WriteLine("Sinh vien: {0} - Ma sinh vien: {1} ",hoTen,maSinhVien);
        
        int a,b,c,d,e;//khai bao 5 bien so a,b,c,d,e kieu int
        //thong bao cho nguoi dung nhap vao a
        System.Console.Write("Toan: ");
        //doc du lieu nhap vao tu ban phism chuyen sang kieu int va gan cho a
        a = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Van: ");
        b = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Anh: ");
        c = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Li: ");
        d = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Hoa: ");
        e = Convert.ToInt32(Console.ReadLine());

        //in ra man hinh diem trung binh
        System.Console.WriteLine("Tong diem: {0} + {1} + {2} + {3} + {4} = {5} ",a,b,c,d,e,a+b+c+d+e);
       
        
       
    }
}
        
