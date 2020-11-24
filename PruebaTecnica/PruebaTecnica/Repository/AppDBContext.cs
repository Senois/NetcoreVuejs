using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Repository
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }  

        public DbSet<Permit> Permit { get; set; }
        public DbSet<PermitType> PermitType { get; set; }

    }
}
