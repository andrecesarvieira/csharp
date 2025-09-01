using SharpPontoWeb.Models;

namespace SharpPontoWeb.Interfaces
{
    public interface IRegistroService
    {
        Task<IEnumerable<Registro>> ObterTodosRegistrosAsync();
        Task<Registro?> ObterRegistroPorIdAsync(int id);
        Task<Registro?> ObterRegistroDoDiaAsync(DateOnly? data = null);
        Task<bool> RegistrarPontoAsync();
        Task<bool> AtualizarRegistroAsync(Registro registro);
        Task<bool> InserirPontoAsync(Registro registro);
        Task<bool> ExcluirRegistroAsync(int id);
        Task<IEnumerable<Registro>> ObterRegistrosPaginadosAsync(int pagina, int tamanhoPagina);
        Task<int> ObterTotalRegistrosAsync();
    }
}