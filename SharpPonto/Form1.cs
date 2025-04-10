using SharpPonto.Entidades;
using System.Data;
using System.Text;

namespace SharpPonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["gridManha"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            dataGridView1.Columns["gridTarde"].HeaderCell.Style.BackColor = Color.LightSteelBlue;
            dataGridView1.Columns["gridTotal"].HeaderCell.Style.BackColor = Color.LightGoldenrodYellow;
            
            Dados.Database.CriarBancoDeDados();
            Dados.Database.CriarTabela();
            Dados.Database.LerRegistros();
            ExibirDados();
            lblPath.Text = Dados.Database.path;

            dataGridView1.ClearSelection();
        }

        private void ExibirDados()
        {
            try
            {
                dataGridView1.DataSource = Dados.Database.LerRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler a tabela" + ex.Message);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            registro.Data = DateOnly.FromDateTime(DateTime.Now);
            registro.Entrada = TimeOnly.FromDateTime(DateTime.Now);
            registro.Almoco = TimeOnly.FromDateTime(DateTime.Now);
            registro.Retorno = TimeOnly.FromDateTime(DateTime.Now);
            registro.Saida = TimeOnly.FromDateTime(DateTime.Now);

            DataTable dt = new DataTable();

            try
            {
                string dataFmt = registro.Data.ToString("yyyy/MM/dd");
                dt = Dados.Database.LerRegistro(dataFmt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o registro pela chave: " + ex.Message);
            }

            int n = 0;

            if (dt.Rows.Count == 0)
            {
                n = 1;
            }
            else if (dt.Rows[0]["Almoco"] == DBNull.Value)
            {
                string hrInicial = (dt.Rows[0]["Entrada"]).ToString()!;
                string hrFinal = registro.Almoco.ToString("HH:mm");

                registro.Manha = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal));

                n = 2;
            }
            else if (dt.Rows[0]["Retorno"] == DBNull.Value)
            {
                n = 3;
            }
            else if (dt.Rows[0]["Saida"] == DBNull.Value)
            {
                string hrInicial = (dt.Rows[0]["Retorno"]).ToString()!;
                string hrFinal = registro.Saida.ToString("HH:mm");

                registro.Tarde = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal));

                string totalManha = (dt.Rows[0]["Manha"]).ToString()!;
                string totalTarde = registro.Tarde.ToString("HH:mm");

                registro.TotalDia = TimeOnly.FromTimeSpan(CalcularTotalDia(totalManha, totalTarde));

                n = 4;
            }

            try
            {
                Dados.Database.InserirRegistro(registro, n);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o dado: " + ex.Message);
            }
        }

        private TimeSpan CalcularPeriodo(string hrInicial, string hrFinal)
        {
            try
            {
                var inicio = TimeOnly.Parse(hrInicial);
                var fim = TimeOnly.Parse(hrFinal);

                return fim.ToTimeSpan() - inicio.ToTimeSpan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o tempo percorrido: " + ex.Message);
            }

            return TimeSpan.Zero;
        }

        private TimeSpan CalcularTotalDia(string totalManha, string totalTarde)
        {
            try
            {
                var inicio = TimeOnly.Parse(totalManha);
                var fim = TimeOnly.Parse(totalTarde);

                return inicio.ToTimeSpan() + fim.ToTimeSpan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o tempo total: " + ex.Message);
            }

            return TimeSpan.Zero;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    // Obtém o valor da coluna "Data" da linha selecionada
                    string? dataFmt = dataGridView1.SelectedRows[0].Cells["gridData"].Value?.ToString();

                    if (string.IsNullOrEmpty(dataFmt))
                    {
                        MessageBox.Show("O valor da data selecionada é inválido ou nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirmação antes de excluir
                    DialogResult result = MessageBox.Show("Deseja realmente excluir o registro do dia " + dataFmt + "?",
                                                        "Confirmar exclusão",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Dados.Database.ExcluirRegistro(dataFmt);
                        ExibirDados();
                        dataGridView1.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!DateOnly.TryParse(textData.Text, out var data) ||
                !TimeOnly.TryParse(textEntrada.Text, out var entrada) ||
                !TimeOnly.TryParse(textAlmoco.Text, out var almoco) ||
                !TimeOnly.TryParse(textRetorno.Text, out var retorno) ||
                !TimeOnly.TryParse(textSaida.Text, out var saida))
            {
                MessageBox.Show("Preencha todos os campos com valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Registro registro = new Registro();

            registro.Data = DateOnly.Parse(textData.Text);
            registro.Entrada = TimeOnly.Parse(textEntrada.Text);
            registro.Almoco = TimeOnly.Parse(textAlmoco.Text);
            registro.Retorno = TimeOnly.Parse(textRetorno.Text);
            registro.Saida = TimeOnly.Parse(textSaida.Text);

            DataTable dt = new DataTable();

            try
            {
                string dataFmt = registro.Data.ToString("yyyy/MM/dd");
                dt = Dados.Database.LerRegistro(dataFmt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o registro pela chave: " + ex.Message);
            }

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Já existe registro para a data.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string hrInicial = registro.Entrada.ToString("HH:mm");
                string hrFinal = registro.Almoco.ToString("HH:mm");

                registro.Manha = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal));

                hrInicial = registro.Retorno.ToString("HH:mm");
                hrFinal = registro.Saida.ToString("HH:mm");

                registro.Tarde = TimeOnly.FromTimeSpan(CalcularPeriodo(hrInicial, hrFinal));

                string totalManha = registro.Manha.ToString("HH:mm");
                string totalTarde = registro.Tarde.ToString("HH:mm");

                registro.TotalDia = TimeOnly.FromTimeSpan(CalcularTotalDia(totalManha, totalTarde));
            }

            try
            {
                Dados.Database.InserirRegistro(registro, 5);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o dado: " + ex.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Função auxiliar para pegar o texto da célula com segurança
            string GetCellText(int row, int col)
            {
                var cell = dataGridView1.Rows[row].Cells[col];
                if (cell.Value != null)
                {
                    return cell.Value.ToString()!;
                }
                return "";
            }

            // Verifica se há itens selecionados
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um registro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Identifica as linhas únicas selecionadas
            var linhasSelecionadas = new HashSet<int>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                linhasSelecionadas.Add(cell.RowIndex);
            }

            // Nome do arquivo: pontos_yyyymm.csv (ano e mês corrente)
            string nomeArquivo = $"Timesheet_{DateTime.Now:yyyyMM}.csv";
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            try
            {
                using (var writer = new StreamWriter(caminhoArquivo, false, Encoding.UTF8))
                {
                    foreach (int linha in linhasSelecionadas.OrderBy(l => l))
                    {
                        // Usa a função auxiliar para recuperar o valor de cada coluna
                        string dataStr = GetCellText(linha, 0); // data
                        string entrada = GetCellText(linha, 1); // entrada
                        string almoco = GetCellText(linha, 2); // almoço
                        string retorno = GetCellText(linha, 3); // retorno
                        string saida = GetCellText(linha, 4); // saída
                        string manha = GetCellText(linha, 5); // manhã
                        string tarde = GetCellText(linha, 6); // tarde

                        // Verifica se a data está preenchida antes de converter
                        string dataFormatada = "";
                        if (!string.IsNullOrEmpty(dataStr))
                        {
                            try
                            {
                                var dt = DateTime.ParseExact(dataStr, "yyyy/MM/dd", null);
                                dataFormatada = dt.ToString("dd/MMM/yy", new System.Globalization.CultureInfo("pt-BR"));
                                dataFormatada = dataFormatada.Replace("/", "/").Replace("jan", "Jan").Replace("fev", "Fev")
                                    .Replace("mar", "Mar").Replace("abr", "Abr").Replace("mai", "Mai").Replace("jun", "Jun")
                                    .Replace("jul", "Jul").Replace("ago", "Ago").Replace("set", "Set").Replace("out", "Out")
                                    .Replace("nov", "Nov").Replace("dez", "Dez").Replace(".","");
                            }
                            catch
                            {
                                dataFormatada = dataStr;
                            }
                        }

                        // Monta as duas linhas conforme o padrão informado
                        string linhaTarde = dataFormatada + "#|#APROVADO#|#" + retorno + "#|#" + saida + "#|#" + tarde +
                                            "#|#00:00#|#0000#|#0000-0000#|#SIM#|#0000#|#ANALISE DE SISTEMAS#|#";
                        string linhaManha = dataFormatada + "#|#APROVADO#|#" + entrada + "#|#" + almoco + "#|#" + manha +
                                            "#|#00:00#|#0000#|#0000-0000#|#SIM#|#0000#|#ANALISE DE SISTEMAS#|#";

                        // Escreve cada período em uma linha do arquivo
                        writer.WriteLine(linhaTarde);
                        writer.WriteLine(linhaManha);
                    }
                }

                MessageBox.Show($"Arquivo exportado com sucesso:\n{caminhoArquivo}", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
