using AiTech.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Context
{
    public class AppDbContext:IdentityDbContext<AppUser,AppRole,int>
    {

        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WhyChoise> WhyChoises { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }







    }
}
