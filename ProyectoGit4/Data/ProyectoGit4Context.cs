#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoGit4.Models;

namespace ProyectoGit4.Data
{
    public class ProyectoGit4Context : DbContext
    {
        public ProyectoGit4Context (DbContextOptions<ProyectoGit4Context> options)
            : base(options)
        {
        }

        public DbSet<ProyectoGit4.Models.Persona> Persona { get; set; }
    }
}
