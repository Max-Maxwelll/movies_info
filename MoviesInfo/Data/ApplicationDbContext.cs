using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public DbSet<ShowModel> Shows { get; set; }
        public DbSet<FavoriteModel> Favorites { get; set; }
        public DbSet<EpisodeModel> Episodes { get; set; }
        public DbSet<DetailsModel> Details { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
