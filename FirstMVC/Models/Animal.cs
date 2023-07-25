using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        public string AnimalName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}