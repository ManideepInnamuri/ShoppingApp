using Microsoft.EntityFrameworkCore;
using ShoppingApplication.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.Entities.Data
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
