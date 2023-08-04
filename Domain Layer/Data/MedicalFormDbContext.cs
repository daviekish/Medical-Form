using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Data
{
    public class MedicalFormDbContext : DbContext
    {
        public MedicalFormDbContext(DbContextOptions options) : base(options)

        {
            
        }

        public DbSet<MedicalFromModel> MedicalFrom { get; set; }

        
    }
}
