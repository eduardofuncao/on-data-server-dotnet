using Microsoft.EntityFrameworkCore;
using OnData.Data;
using OnData.Models;

namespace on_data_server_dotnet.service;

public class PacienteService
{
    private readonly OnDataDbContext _context;

    public PacienteService(OnDataDbContext context)
    {
        _context = context;
    }

    public async Task<List<Paciente>> GetPacientesAsync()
    {
        return await _context.Pacientes.ToListAsync();
    }

    public async Task<Paciente> GetPacienteByIdAsync(int id)
    {
        return await _context.Pacientes.FindAsync(id);
    }

    public async Task CreatePacienteAsync(Paciente paciente)
    {
        _context.Pacientes.Add(paciente);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePacienteAsync(Paciente paciente)
    {
        _context.Entry(paciente).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletePacienteAsync(int id)
    {
        var paciente = await _context.Pacientes.FindAsync(id);
        if (paciente != null)
        {
            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
        }
    }
}