using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldLiftoff.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldLiftoff.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext (DbContextOptions<UserDbContext> options)
            : base(options)
        { }
        
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => new { u.username, u.password, u.areaCode, u.UserID });
        }*/
    }
}
