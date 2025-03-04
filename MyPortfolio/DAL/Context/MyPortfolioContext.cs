﻿using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BETULCENGIZ.;Database=MyPortfolio;Trusted_Connection=True;TrustServerCertificate=True");
        }
      

        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages  { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias  { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }


    }
}
