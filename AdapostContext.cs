using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heaven.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Heaven.Repository;

namespace Heaven
{
    public class AdapostContext : IdentityDbContext<IdentityUser>
    {
        public AdapostContext(DbContextOptions<AdapostContext> options) : base(options)
        {

        }
        public DbSet<Adapost> Adaposts { get; set; }

        public DbSet<Caini> Caini { get; set; }

        public DbSet<Pisici> Pisici { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<Doneaza> Doneaza { get; set; }

        public DbSet<Poze> Poze { get; set; }

        public DbSet<Utilizator> Utilizator { get; set; }





    }
}