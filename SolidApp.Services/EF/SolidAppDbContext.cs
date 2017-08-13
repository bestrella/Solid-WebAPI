using Microsoft.EntityFrameworkCore;
using SolidApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidApp.Services.EF
{
    public class SolidAppDbContext:DbContext
    {
        public SolidAppDbContext():base()
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
