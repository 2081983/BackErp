using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Data
{
    public class AppDb:DbContext
    {
        public AppDb(DbContextOptions<AppDb> options):base(options) 
        {
        }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Uom> Uoms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProUnit> ProUnits { get; set; }
    }
}
