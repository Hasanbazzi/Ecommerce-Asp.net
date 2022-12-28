using Ecommerce.Partials;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppdbContext _context;
        public CinemaController(AppdbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _context.cinema.ToListAsync();
            return View(data);
        }
    }
}
