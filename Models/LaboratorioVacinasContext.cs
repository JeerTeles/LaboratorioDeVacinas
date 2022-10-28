using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaboratorioVacinas.Models;

namespace LaboratorioVacinas.Models
{
    public class LaboratorioVacinasContext:DbContext
    {
        public LaboratorioVacinasContext(DbContextOptions<LaboratorioVacinasContext> options): base(options){}  
        public DbSet<Virus>? Virus { get; set; }
        public DbSet<Vacina>? Vacina { get; set; }
    }
}