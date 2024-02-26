using Microsoft.EntityFrameworkCore;
using Parcial1_AP1_EliezerTerrero.DAL;
using Parcial1_AP1_EliezerTerrero.Models;
using System.Linq.Expressions;

namespace Parcial1_AP1_EliezerTerrero.Service
{
    public class MetasService
    {
        protected readonly Contexto _contexto;

        public MetasService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> save(Metas meta)
        {
            if (_contexto.Metas.Any(p => p.Descripcion.ToLower() == p.Descripcion.ToLower()))
            {
                return false;
            }

        
            if (meta.MetaId == 0) 
            {
                _contexto.Metas.Add(meta);
            }
            else
            {
                _contexto.Metas.Update(meta);
            }

            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var meta = _contexto.Metas.Find(id);
            _contexto.Metas.Remove(meta);

            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<Metas?> firstIdAsync(int id)
        {
            return await _contexto.Metas.FirstOrDefaultAsync(p => p.MetaId == id);
        }

        public async Task<List<Metas>> GetMetas (Expression<Func<Metas, bool>> expression)
        {
            return await _contexto.Metas
                .AsNoTracking()
                .Where(expression)
                .ToListAsync();
        }
    }
}
