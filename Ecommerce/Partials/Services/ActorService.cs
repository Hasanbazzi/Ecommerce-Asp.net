using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Partials.Services
{
    public class ActorService : IActorService
    {
        private readonly AppdbContext _context;
        public ActorService(AppdbContext context)
        {
            _context = context;
        }
        public void Add(Actor a)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetAll()
        {
            var data = _context.Actors.ToList();
            return data;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor n)
        {
            throw new NotImplementedException();
        }
    }
}
