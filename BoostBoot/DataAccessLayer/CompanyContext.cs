using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAccessLayer
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("Server=VSTANCIC\\SQLEXPRESS;Database=TestApp.CompanyContext;Trusted_Connection=True;")
        {
        }

        public DbSet<Company> Company { get; set; }
    }
}
