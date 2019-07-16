
using Microsoft.EntityFrameworkCore;
using PaisesWEBAPI.Entities;

namespace PaisesWEBAPI.Context
{
    public class ReportContext : DbContext
    {

        public ReportContext(DbContextOptions<ReportContext> options)
           : base(options)
        {


        }

        public DbSet<TablaDMPrep> TablaDMPrep { get; set; }

   
    }
}
