using Microsoft.EntityFrameworkCore;
using PassSafe.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSafe.data.model
{
    public class PassItemContext : DbContext
    {
        public DbSet<PassItem> passItem { get; set; }

        public string path = @"C:\Temp\passItems.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={path}");
    }
}
