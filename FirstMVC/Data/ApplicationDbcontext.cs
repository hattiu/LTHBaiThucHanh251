using FirstMVC.Models;
using Microsoft.EntityFrameworkCore;
using FirstMVC.Data;

namespace FirstMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<Student> Students {get; set;}
    }
}