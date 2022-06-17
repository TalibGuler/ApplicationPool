using ApplicationPool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationPool.Contex
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDoModel> ToDos { get; set; }

        public ToDoContext(DbContextOptions builder) : base(builder)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Username=abdulmuttalibguler;Password=Ma123456;Database=test;Search Path=yp_aguler;Host=192.168.1.94;Port=54321");
        //    base.OnConfiguring(optionsBuilder);
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("yp_aguler");
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
