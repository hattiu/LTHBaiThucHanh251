namespace NewApp.Models
{
    public class Person 
    {
        //khai bao cac thuoc tinh
        public string FullName {get;set;}
        public string Address {get;set;}
        public string Age {get;set;}
        
        

        //khai bao cac phuong thuc
        public void NhapDuLieu()
        {
            System.Console.Write("Full Name = ");
            FullName = Console.ReadLine();

            System.Console.Write("Address = ");
            Address = Console.ReadLine();

            System.Console.Write("Age = ");
            Age = Console.ReadLine();
            
        }

        public int GetYearOfBirth (int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
        

        public void HienThi ()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
            
        }

        public void HienThi (string ten, int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, tuoi);
            
        }
        
        public void HienThi(string ten, string diaChi)
        {
            System.Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, diaChi);
            
        }

        public void EnterData()
        {
            System.Console.Write("Full name = ");
            FullName = Console.ReadLine();

            System.Console.Write("Address = ");
            Address = Console.ReadLine();

            System.Console.Write("Age = ");
            Age = Console.ReadLine();
            try{
                //cau lenhj co the gay ngoai le
                Age = Console.ReadLine();
            }catch(Exception e)
            {
                //cau lenh xu ly ngoai le
                Age = "0";
            }
        } 




        
  
    }

}

