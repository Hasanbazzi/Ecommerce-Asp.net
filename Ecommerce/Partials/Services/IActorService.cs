using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Partials.Services
{
  public  interface IActorService
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor a);
        Actor Update(int id, Actor n);
        void Delete(int id);
    }
}
