#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeVanNghia.Model;

    public class CategoryContext : DbContext
    {
        public CategoryContext (DbContextOptions<CategoryContext> options)
            : base(options)
        {
        }

        public DbSet<LeVanNghia.Model.Category> Category { get; set; }
        public DbSet<LeVanNghia.Model.comment> comment { get; set; }
        public DbSet<LeVanNghia.Model.News> News { get; set; }
    }
