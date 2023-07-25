using System.ComponentModel.DataAnnotations;
 
 namespace FirstWebMVC.Models
 {
    public class Emloyee
    {
        [Key]

        public string EmpID { get; set; }

        public string EmpName { get; set; }

        public string Address { get; set; }

    }
 }
 