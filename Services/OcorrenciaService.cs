// OcorrenciaService.cs
using Microsoft.EntityFrameworkCore;
using OnData.Data;
using OnData.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnData.Services
{
    public class OcorrenciaService
    {
        private readonly OnDataDbContext _context;

        public OcorrenciaService(OnDataDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ocorrencia>> GetOcorrenciasAsync()
        {
            return await _context.Ocorrencias.ToListAsync();
        }

        public async Task<Ocorrencia> GetOcorrenciaByIdAsync(int id)
        {
            return await _context.Ocorrencias.FindAsync(id);
        }

        public async Task CreateOcorrenciaAsync(Ocorrencia ocorrencia)
        {
            _context.Ocorrencias.Add(ocorrencia);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOcorrenciaAsync(Ocorrencia ocorrencia)
        {
            _context.Entry(ocorrencia).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOcorrenciaAsync(int id)
        {
            var ocorrencia = await _context.Ocorrencias.FindAsync(id);
            if (ocorrencia != null)
            {
                _context.Ocorrencias.Remove(ocorrencia);
                await _context.SaveChangesAsync();
            }
        }
    }
}