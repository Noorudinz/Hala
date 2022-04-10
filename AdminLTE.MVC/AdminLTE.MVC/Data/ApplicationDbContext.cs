using System;
using System.Collections.Generic;
using System.Text;
using AdminLTE.MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerMaster> CustomerMaster { get; set; }
        public DbSet<HomeBannerRTB> Contents { get; set; }
        public DbSet<ProductMaster> Product { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Sepcification> Sepcification { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<ProductsColor> ProductsColor { get; set; }
    }
}
