#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P33_119000321_PhanTrungGiang.Models;

    public class CategoryContext : DbContext
    {
        public CategoryContext (DbContextOptions<CategoryContext> options)
            : base(options)
        {
        }

        public DbSet<P33_119000321_PhanTrungGiang.Models.Category> Category { get; set; }

        public DbSet<P33_119000321_PhanTrungGiang.Models.News> News { get; set; }

        public DbSet<P33_119000321_PhanTrungGiang.Models.Comment> Comment { get; set; }
    }
