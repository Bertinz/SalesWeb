using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb3.Models;

namespace SalesWeb3.Data
{
    public class SalesWeb3Context : DbContext
    {
        public SalesWeb3Context (DbContextOptions<SalesWeb3Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWeb3.Models.Department> Department { get; set; }
    }
}
