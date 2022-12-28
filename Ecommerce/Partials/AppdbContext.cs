using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Partials
{
    public class AppdbContext:DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ActorMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            mb.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(m => m.ActorMovie).HasForeignKey(m => m.MovieId);
            mb.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(m => m.ActorMovie).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(mb);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<ActorMovie> ActorMovie { get; set; }
        public DbSet<Cinema> cinema { get; set; }
        public DbSet<Producer> Producer { get; set; }

    }
}
