using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class ActorMovie
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public Movies Movie { get; set; }
    }
}
