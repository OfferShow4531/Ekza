using Microsoft.EntityFrameworkCore;
using ProjectAid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAid.Data
{
    public class TitleContext : DbContext
    {
        public TitleContext(DbContextOptions<TitleContext> options)
            : base(options)
        {
        }

        public DbSet<Title> Titles { get; set; }
    }
}
