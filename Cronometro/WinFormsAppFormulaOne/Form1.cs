namespace WinFormsAppFormulaOne
{
    /// <summary>
    /// Representa o formulário principal da aplicação WinFormsAppFormulaOne.
    /// Esta classe gerencia a interface do usuário e interage com a classe Carro,
    /// permitindo o controle e monitoramento de um veículo virtual.
    /// </summary>
    /// <remarks>
    /// A classe Form1 encapsula toda a lógica de interação com o usuário,
    /// incluindo a atualização da interface gráfica, o processamento de entradas
    /// do usuário e a comunicação com a instância da classe Carro.
    /// </remarks>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instância da classe Carro que representa o veículo sendo gerenciado.
        /// Esta instância mantém o estado atual do carro, incluindo sua matrícula,
        /// quilometragem, nível de combustível e outras propriedades relevantes.
        /// </summary>
        private Carro carro;

        /// <summary>
        /// Inicializa uma nova instância do formulário Form1.
        /// Este construtor configura o formulário, cria uma instância de Carro com valores iniciais
        /// e atualiza a interface do usuário para refletir o estado inicial do carro.
        /// </summary>
        /// <remarks>
        /// Durante a inicialização, um novo carro é criado com uma matrícula padrão "49-81-PC",
        /// capacidade de depósito de 50 litros e consumo médio de 6 litros por 100 km.
        /// Após a criação do carro, os métodos AtualizarDadosVeiculo e AtualizarInfoDetalhada
        /// são chamados para sincronizar a interface do usuário com o estado inicial do carro.
        /// </remarks>
        public Form1()
        {
            InitializeComponent();            
            carro = new Carro("49-81-PC", 6);            
            AtualizarDadosVeiculo();
            AtualizarInfoDetalhada();
        }

        /// <summary>
        /// Atualiza os campos de texto do formulário com os dados atuais do carro.
        /// Este método é responsável por sincronizar a interface do usuário com o estado atual do objeto carro.
        /// </summary>
        /// <remarks>
        /// Os seguintes campos são atualizados:
        /// - txtQuilometragem: Exibe a quilometragem total do carro.
        /// - txtCapacidade: Mostra a capacidade total do depósito de combustível.
        /// - txtLitros: Indica a quantidade atual de combustível no depósito.
        /// - txtConsumo: Apresenta o consumo médio do carro.
        /// - txtMatricula: Exibe a matrícula atual do carro.
        /// Este método deve ser chamado sempre que houver uma mudança no estado do carro
        /// que precise ser refletida na interface do usuário.
        /// </remarks>
        private void AtualizarDadosVeiculo()
        {
            txtQuilometragem.Text = carro.QuilometragemTotal.ToString();
            txtCapacidade.Text = carro.CapacidadeDeposito.ToString();
            txtLitros.Text = carro.LitrosNoDeposito.ToString();
            txtConsumo.Text = carro.ConsumoMedio.ToString();
            txtMatricula.Text = carro.Matricula;
        }

        /// <summary>
        /// Manipula o evento de clique no botão de cálculo do custo médio por quilômetro.
        /// Este método calcula e exibe o custo médio por quilômetro com base no custo por litro fornecido pelo usuário.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de cálculo do custo médio.</param>
        /// <param name="e">Argumentos do evento, que contêm informações adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O método realiza as seguintes operações:
        /// 1. Tenta converter o texto do campo txtCustoPorLitro para um valor double.
        /// 2. Se a conversão for bem-sucedida, calcula o custo médio por quilômetro usando o método CalcularCustoMedioPorKm do carro.
        /// 3. Exibe o resultado formatado no campo txtResultado.
        /// 4. Se a conversão falhar, exibe uma mensagem de erro solicitando um valor válido.
        /// 5. Atualiza os dados do veículo na interface, chamando AtualizarDadosVeiculo.
        /// Este método é crucial para fornecer ao usuário informações sobre a eficiência econômica do veículo.
        /// </remarks>
        private void btnCustoMedio_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCustoPorLitro.Text, out double custoPorLitro))
            {
                double custoMedio = carro.CalcularCustoMedioPorKm(custoPorLitro);
                txtResultado.Text = $"Custo médio por quilómetro: {custoMedio:F2} €";
            }
            else
            {
                txtResultado.Text = "Insira um valor válido para o custo por litro.";
            }
            AtualizarDadosVeiculo();
        }

        /// <summary>
        /// Manipula o evento de clique no botão de adição de combustível.
        /// Este método permite ao usuário adicionar uma quantidade específica de combustível ao depósito do carro.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de adicionar combustível.</param>
        /// <param name="e">Argumentos do evento, que contêm informações adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O método executa as seguintes ações:
        /// 1. Tenta converter o texto do campo txtLitrosAdicionar para um valor double.
        /// 2. Se a conversão for bem-sucedida, chama o método AdicionarCombustivel do carro com a quantidade especificada.
        /// 3. Atualiza a interface do usuário chamando AtualizarDadosVeiculo.
        /// 4. Exibe uma mensagem de sucesso no campo txtResultado.
        /// 5. Se a conversão falhar, exibe uma mensagem de erro solicitando um valor válido.
        /// Este método é essencial para simular o reabastecimento do veículo e manter o controle do nível de combustível.
        /// </remarks>
        private void btnAdicionarCombustivel_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLitrosAdicionar.Text, out double litros))
            {
                carro.AdicionarCombustivel(litros);
                AtualizarDadosVeiculo();
                txtResultado.Text = "Combustível adicionado com sucesso!";
            }
            else
            {
                txtResultado.Text = "Insira um valor válido para os litros a adicionar.";
            }
        }

        /// <summary>
        /// Manipula o evento de clique no botão de cálculo de quilômetros possíveis.
        /// Este método calcula e exibe a distância máxima que o carro pode percorrer com o combustível atual.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de calcular quilômetros.</param>
        /// <param name="e">Argumentos do evento, que contêm informações adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O método realiza as seguintes operações:
        /// 1. Chama o método CalcularQuilometrosPossiveis do carro para obter a distância máxima.
        /// 2. Exibe o resultado formatado no campo txtResultado.
        /// 3. Atualiza os dados do veículo na interface, chamando AtualizarDadosVeiculo.
        /// Este cálculo é importante para que o usuário possa estimar a autonomia atual do veículo.
        /// </remarks>
        private void btnCalcularQuilometros_Click(object sender, EventArgs e)
        {
            double quilometrosPossiveis = carro.CalcularQuilometrosPossiveis();
            txtResultado.Text = $"Quilómetros possíveis: {quilometrosPossiveis:F2} km";
            AtualizarDadosVeiculo();
        }

        /// <summary>
        /// Manipula o evento de clique no botão de registro de viagem.
        /// Este método permite ao usuário registrar uma nova viagem, atualizando a quilometragem e o nível de combustível do carro.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de registrar viagem.</param>
        /// <param name="e">Argumentos do evento, que contêm informações adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O método executa as seguintes ações:
        /// 1. Tenta converter o texto do campo txtViagem para um valor double representando a distância da viagem.
        /// 2. Se a conversão for bem-sucedida, chama o método RegistarViagem do carro com a distância especificada.
        /// 3. Atualiza a interface do usuário chamando AtualizarDadosVeiculo e AtualizarInfoDetalhada.
        /// 4. Exibe uma mensagem de sucesso no campo txtResultado.
        /// 5. Verifica se o carro está na reserva de combustível após a viagem e exibe um alerta se necessário.
        /// 6. Se a conversão falhar, exibe uma mensagem de erro solicitando um valor válido.
        /// Este método é crucial para simular o uso do veículo e atualizar seu estado conforme as viagens são realizadas.
        /// </remarks>
        private void btnRegistrarViagem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtViagem.Text, out double quilometros))
            {
                carro.RegistarViagem(quilometros);
                AtualizarDadosVeiculo();
                AtualizarInfoDetalhada();
                txtResultado.Text = "Viagem registrada com sucesso!";
                if (carro.EstaNaReserva())
                {
                    MessageBox.Show("Atenção! O veículo está na reserva de combustível. Abasteça o mais rápido possível.",
                            "Alerta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtResultado.Text = "Insira um valor válido para a viagem.";
            }
        }
        /// <summary>
        /// Manipula o evento de clique no botão de atualização da matrícula.
        /// Este método permite ao usuário atualizar a matrícula do carro e resetar seus dados.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de atualizar matrícula.</param>
        /// <param name="e">Argumentos do evento, que contêm informações adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O método realiza as seguintes operações:
        /// 1. Obtém a nova matrícula do campo txtMatricula.
        /// 2. Verifica se a nova matrícula não é nula ou vazia.
        /// 3. Se válida, chama o método ResetDados do carro com a nova matrícula.
        /// 4. Atualiza a interface do usuário chamando AtualizarDadosVeiculo e AtualizarInfoDetalhada.
        /// 5. Exibe uma mensagem de sucesso no campo txtResultado.
        /// 6. Se a matrícula for inválida, exibe uma mensagem de erro.
        /// Este método é importante para simular a troca de veículo ou a reinicialização dos dados do carro atual.
        /// </remarks>
        private void btnAtualizarMatricula_Click(object sender, EventArgs e)
        {
            string novaMatricula = txtMatricula.Text;
            if (!string.IsNullOrWhiteSpace(novaMatricula))
            {
                carro.ResetDados(novaMatricula);
                AtualizarDadosVeiculo();
                AtualizarInfoDetalhada();
                txtResultado.Text = "Matrícula atualizada e dados resetados com sucesso!";
            }
            else
            {
                txtResultado.Text = "Insira uma matrícula válida.";
            }
        }

        /// <summary>
        /// Atualiza as informações detalhadas do carro exibidas no formulário.
        /// Este método compila e exibe um resumo das informações mais relevantes sobre o estado atual do carro.
        /// </summary>
        /// <remarks>
        /// O método realiza as seguintes ações:
        /// 1. Calcula o custo total do combustível consumido usando o método CalcularCustoTotal do carro.
        /// 2. Calcula a quantidade de litros faltando no depósito.
        /// 3. Compõe uma string formatada com as seguintes informações:
        ///    - Matrícula do carro
        ///    - Número total de viagens realizadas
        ///    - Custo total do combustível consumido
        ///    - Quantidade de litros faltando no depósito
        /// 4. Atualiza o texto do label lblInfoDetalhada com estas informações.
        /// Este método é essencial para fornecer ao usuário uma visão geral rápida e atualizada do estado do carro.
        /// </remarks>
        private void AtualizarInfoDetalhada()
        {
            double custoTotal = carro.CalcularCustoTotal(ObterCustoPorLitro());
            double litrosFaltando = carro.CapacidadeDeposito - carro.LitrosNoDeposito;

            lblInfoDetalhada.Text = $"Matrícula: {carro.Matricula}\n" +
                                    $"Numero de viagens: {carro.ContadorViagens}\n" +
                                    $"Custo total: {custoTotal:F2} €\n" +
                                    $"Litros em falta no depósito: {litrosFaltando:F2} L\n";
        }

        /// <summary>
        /// Obtém o custo por litro de combustível a partir do campo de texto correspondente.
        /// Este método tenta converter o valor inserido pelo usuário em um número válido.
        /// </summary>
        /// <returns>
        /// O custo por litro como um valor double se a conversão for bem-sucedida, ou 0 se falhar.
        /// </returns>
        /// <remarks>
        /// O método realiza as seguintes operações:
        /// 1. Tenta converter o texto do campo txtCustoPorLitro para um valor double.
        /// 2. Se a conversão for bem-sucedida, retorna o valor convertido.
        /// 3. Se a conversão falhar (por exemplo, se o texto não for um número válido), retorna 0.
        /// 
        /// Este método é importante para garantir que um valor numérico válido seja usado nos cálculos
        /// relacionados ao custo do combustível. O retorno de 0 em caso de falha na conversão serve
        /// como um valor padrão seguro, evitando erros de cálculo, mas pode resultar em cálculos
        /// incorretos se não for tratado adequadamente nas funções que o utilizam.
        /// 
        /// É recomendável que as funções que chamam este método verifiquem se o valor retornado
        /// é diferente de zero antes de utilizá-lo em cálculos críticos.
        /// </remarks>
        private double ObterCustoPorLitro()
        {
            if (double.TryParse(txtCustoPorLitro.Text, out double custoPorLitro))
            {
                return custoPorLitro;
            }
            return 0; // Retorna 0 se não conseguir converter
        }
    }
}
