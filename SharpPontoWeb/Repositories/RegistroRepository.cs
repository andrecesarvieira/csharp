using Microsoft.EntityFrameworkCore;
using SharpPontoWeb.Data;
using SharpPontoWeb.Interfaces;
using SharpPontoWeb.Models;

namespace SharpPontoWeb.Repositories
{
    public class RegistroRepository(AppDbContext context) : IRegistroRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<bool> DataExisteAsync(DateOnly data)
        {
            return await _context.Registros.AnyAsync(x => x.Data == data);
        }

        public async Task InserirRegistroAsync(Registro registro)
        {
            await _context.Registros.AddAsync(registro);
        }

        public Task AtualizarRegistroAsync(Registro registro)
        {
            _context.Registros.Update(registro);
            return Task.CompletedTask;
        }

        public async Task ExcluirRegistroAsync(int id)
        {
            var registro = await ObterPorId(id);
            if (registro is not null)
            {
                _context.Registros.Remove(registro);
            }
        }

        public async Task<IEnumerable<Registro>> ObterRegistrosAsync()
        {
            return await _context.Registros.OrderByDescending(x => x.Data).ToListAsync();
        }

        public async Task<Registro?> ObterPorData(DateOnly data)
        {
            return await _context.Registros.FirstOrDefaultAsync(x => x.Data == data);
        }

        public async Task<Registro?> ObterPorId(int id)
        {
            return await _context.Registros.FindAsync(id);
        }

        public async Task SalvarMudancasRegistroAsync()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Registro>> ObterRegistrosPaginadosAsync(int pagina, int tamanhoPagina)
        {
            return await _context.Registros
                .OrderByDescending(x => x.Data)
                .Skip((pagina - 1) * tamanhoPagina)
                .Take(tamanhoPagina)
                .ToListAsync();
        }

        public async Task<int> ObterTotalRegistrosAsync()
        {
            return await _context.Registros.CountAsync();
        }
    }
}