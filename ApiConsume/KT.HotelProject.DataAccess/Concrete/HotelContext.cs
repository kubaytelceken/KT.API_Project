﻿using KT.HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.HotelProject.DataAccess.Concrete
{
    public class HotelContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=HotelDB;integrated security=true;");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
