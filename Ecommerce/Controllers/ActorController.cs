using Ecommerce.Partials;
using Ecommerce.Partials.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _service;
        public ActorController(IActorService service)
        {
            _service = service;
        }
        
                   
        
        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
