using Ecommerce.Partials;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Movies
    {
        [Key]

        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
       
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema cinema { get; set; }
        public int producerId { get; set; }
        [ForeignKey("producerId")]
        public Producer producer { get; set; }
        
        public MovieCategory MovieCategory { get; set; }
        public List<ActorMovie> ActorMovie { get; set; }
       

    }
  
}
