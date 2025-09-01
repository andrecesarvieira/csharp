using SharpPontoWeb.Models;

namespace SharpPontoWeb.Interfaces
{
    public interface IRegistroRepository
    {
        Task<IEnumerable<Registro>> ObterRegistrosAsync();
        Task<Registro?> ObterPorId(int Id);
        Task<Registro?> ObterPorData(DateOnly data);
        Task<bool> DataExisteAsync(DateOnly data);
        Task InserirRegistroAsync(Registro registro);
        Task AtualizarRegistroAsync(Registro registro);
        Task ExcluirRegistroAsync(int Id);
        Task SalvarMudancasRegistroAsync();
        Task<IEnumerable<Registro>> ObterRegistrosPaginadosAsync(int pagina, int tamanhoPagina);
        Task<int> ObterTotalRegistrosAsync();
    }
}