using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PFPOO.Models;

namespace PFPOO.Models
{
    public class PFPOOContext : DbContext
    {
        public PFPOOContext (DbContextOptions<PFPOOContext> options)
            : base(options)
        {
        }

        public DbSet<PFPOO.Models.Te> Te { get; set; }

        public DbSet<PFPOO.Models.Usuario> Usuario { get; set; }
    }
}
