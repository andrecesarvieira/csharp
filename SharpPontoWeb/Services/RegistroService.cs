using SharpPontoWeb.Interfaces;
using SharpPontoWeb.Models;

namespace SharpPontoWeb.Services
{
    public class RegistroService(IRegistroRepository repository) : IRegistroService
    {
        private readonly IRegistroRepository _repository = repository;
        private readonly TimeOnly _tempoVazio = TimeOnly.FromDateTime(DateTime.MinValue);

        public async Task<IEnumerable<Registro>> ObterTodosRegistrosAsync()
        {
            return await _repository.ObterRegistrosAsync();
        }

        public async Task<Registro?> ObterRegistroPorIdAsync(int id)
        {
            return await _repository.ObterPorId(id);
        }

        public async Task<Registro?> ObterRegistroDoDiaAsync(DateOnly? data = null)
        {
            DateOnly dataConsulta = data ?? DateOnly.FromDateTime(DateTime.Now);
            return await _repository.ObterPorData(dataConsulta);
        }

        public async Task<bool> RegistrarPontoAsync()
        {
            DateOnly dataHoje = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly horaAtual = TimeOnly.FromDateTime(DateTime.Now);

            // Verifica se já existe registro para hoje
            bool registroExiste = await _repository.DataExisteAsync(dataHoje);

            if (!registroExiste)
            {
                var novoRegistro = new Registro
                {
                    Data = dataHoje,
                    Entrada = horaAtual,
                    Almoco = _tempoVazio,
                    Retorno = _tempoVazio,
                    Saida = _tempoVazio,
                    Manha = _tempoVazio,
                    Tarde = _tempoVazio,
                    TotalDia = _tempoVazio
                };

                await _repository.InserirRegistroAsync(novoRegistro);
            }
            else
            {
                // Atualizar registro existente
                Registro? registro = await _repository.ObterPorData(dataHoje);

                if (registro is null)
                {
                    return false;
                }

                // Preenche o próximo campo vazio na sequência
                if (registro.Entrada == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Entrada = horaAtual;
                else if (registro.Almoco == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Almoco = horaAtual;
                else if (registro.Retorno == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Retorno = horaAtual;
                else if (registro.Saida == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Saida = horaAtual;

                Registro reg = CalcularHorasService.CalcularHorasRegistro(registro);

                await _repository.AtualizarRegistroAsync(reg);
            }

            await _repository.SalvarMudancasRegistroAsync();
            return true;
        }

        public async Task<bool> InserirPontoAsync(Registro registro)
        {
            // Verifica se já existe registro com a mesma data
            bool registroExiste = await _repository.DataExisteAsync(registro.Data);

            if (!registroExiste)
            {
                Registro reg = CalcularHorasService.CalcularHorasRegistro(registro);

                await _repository.InserirRegistroAsync(reg);
                await _repository.SalvarMudancasRegistroAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> ExcluirRegistroAsync(int id)
        {
            await _repository.ExcluirRegistroAsync(id);
            await _repository.SalvarMudancasRegistroAsync();
            return true;
        }

        public async Task<bool> AtualizarRegistroAsync(Registro registro)
        {
            var registroCalculado = CalcularHorasService.CalcularHorasRegistro(registro);
            await _repository.AtualizarRegistroAsync(registroCalculado);
            await _repository.SalvarMudancasRegistroAsync();
            return true;
        }
        public async Task<IEnumerable<Registro>> ObterRegistrosPaginadosAsync(int pagina, int tamanhoPagina)
        {
            return await _repository.ObterRegistrosPaginadosAsync(pagina, tamanhoPagina);
        }

        public async Task<int> ObterTotalRegistrosAsync()
        {
            return await _repository.ObterTotalRegistrosAsync();
        }
    }
}