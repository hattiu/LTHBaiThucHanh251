using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnimalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Person
        public async Task<IActionResult> Index()
        {
              return _context.Animal != null ? 
                          View(await _context.Animal.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Animal'  is null.");
        }
    }
}