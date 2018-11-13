using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vue.Entity.Entities;

namespace Vue.Entity
{
    public class VueContext : DbContext
    {
        public VueContext(DbContextOptions<VueContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
