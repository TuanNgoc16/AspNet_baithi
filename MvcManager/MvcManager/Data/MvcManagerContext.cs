using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcManager.Models;

namespace MvcManager.Data
{
    public class MvcManagerContext : DbContext
    {
        public MvcManagerContext (DbContextOptions<MvcManagerContext> options)
            : base(options)
        {
        }

        public DbSet<MvcManager.Models.Manager> Manager { get; set; } 
    }
}
