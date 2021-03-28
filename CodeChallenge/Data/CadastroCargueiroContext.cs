using CodeChallenge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Data
{
    public class CadastroCargueiroContext : DbContext
    {
        public CadastroCargueiroContext(DbContextOptions<CadastroCargueiroContext> options) : base(options)
        { }

        public DbSet<Cargueiro> Cargueiros { get; set; }
    }
}
