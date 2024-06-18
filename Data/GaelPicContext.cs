using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GaelPic.Models;

namespace GaelPic.Data
{
    public class GaelPicContext : DbContext
    {
        public GaelPicContext (DbContextOptions<GaelPicContext> options)
            : base(options)
        {
        }

        public DbSet<GaelPic.Models.User> User { get; set; } = default!;
        public DbSet<GaelPic.Models.TypeMidia> TypeMidia { get; set; } = default!;
        public DbSet<GaelPic.Models.Midia> Midia { get; set; } = default!;
    }
}
