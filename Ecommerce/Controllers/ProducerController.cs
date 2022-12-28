using Ecommerce.Partials;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppdbContext _context;
        public ProducerController(AppdbContext context)
        {
            _context = context;
        }



          
            public IActionResult Index()
        {  var data = _context.Producer.ToList();
            return View(data);
        }
    }
}
