using Ecommerce.Partials;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppdbContext _context;
        public MoviesController(AppdbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _context.Movies.Include(n=> n.cinema).ToListAsync();
            return View(data);
        }
    }
}

