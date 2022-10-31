﻿using fakture_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace fakture_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
