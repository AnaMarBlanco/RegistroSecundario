using Microsoft.EntityFrameworkCore;
using RegistroSecundario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroSecundario.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Paises> Paises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(" Data Source = Data.db");
        }
    }
}
