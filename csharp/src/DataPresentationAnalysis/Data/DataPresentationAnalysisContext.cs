using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataPresentationAnalysis.Models;

namespace DataPresentationAnalysis.Data
{
    public class DataPresentationAnalysisContext : DbContext
    {
        public DataPresentationAnalysisContext (DbContextOptions<DataPresentationAnalysisContext> options)
            : base(options)
        {
        }

        public DbSet<DataPresentationAnalysis.Models.Account> Account { get; set; }
    }
}
