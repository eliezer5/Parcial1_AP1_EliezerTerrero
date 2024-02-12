using Microsoft.EntityFrameworkCore;
using Parcial1_AP1_EliezerTerrero.Models;

namespace Parcial1_AP1_EliezerTerrero.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions options) :base(options) { }

        public DbSet<Metas> Metas { get; set; }
    }
}
