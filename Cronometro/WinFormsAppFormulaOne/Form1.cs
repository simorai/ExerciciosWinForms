namespace WinFormsAppFormulaOne
{
    /// <summary>
    /// Representa o formul�rio principal da aplica��o WinFormsAppFormulaOne.
    /// Esta classe gerencia a interface do usu�rio e interage com a classe Carro,
    /// permitindo o controle e monitoramento de um ve�culo virtual.
    /// </summary>
    /// <remarks>
    /// A classe Form1 encapsula toda a l�gica de intera��o com o usu�rio,
    /// incluindo a atualiza��o da interface gr�fica, o processamento de entradas
    /// do usu�rio e a comunica��o com a inst�ncia da classe Carro.
    /// </remarks>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inst�ncia da classe Carro que representa o ve�culo sendo gerenciado.
        /// Esta inst�ncia mant�m o estado atual do carro, incluindo sua matr�cula,
        /// quilometragem, n�vel de combust�vel e outras propriedades relevantes.
        /// </summary>
        private Carro carro;

        /// <summary>
        /// Inicializa uma nova inst�ncia do formul�rio Form1.
        /// Este construtor configura o formul�rio, cria uma inst�ncia de Carro com valores iniciais
        /// e atualiza a interface do usu�rio para refletir o estado inicial do carro.
        /// </summary>
        /// <remarks>
        /// Durante a inicializa��o, um novo carro � criado com uma matr�cula padr�o "49-81-PC",
        /// capacidade de dep�sito de 50 litros e consumo m�dio de 6 litros por 100 km.
        /// Ap�s a cria��o do carro, os m�todos AtualizarDadosVeiculo e AtualizarInfoDetalhada
        /// s�o chamados para sincronizar a interface do usu�rio com o estado inicial do carro.
        /// </remarks>
        public Form1()
        {
            InitializeComponent();            
            carro = new Carro("49-81-PC", 6);            
            AtualizarDadosVeiculo();
            AtualizarInfoDetalhada();
        }

        /// <summary>
        /// Atualiza os campos de texto do formul�rio com os dados atuais do carro.
        /// Este m�todo � respons�vel por sincronizar a interface do usu�rio com o estado atual do objeto carro.
        /// </summary>
        /// <remarks>
        /// Os seguintes campos s�o atualizados:
        /// - txtQuilometragem: Exibe a quilometragem total do carro.
        /// - txtCapacidade: Mostra a capacidade total do dep�sito de combust�vel.
        /// - txtLitros: Indica a quantidade atual de combust�vel no dep�sito.
        /// - txtConsumo: Apresenta o consumo m�dio do carro.
        /// - txtMatricula: Exibe a matr�cula atual do carro.
        /// Este m�todo deve ser chamado sempre que houver uma mudan�a no estado do carro
        /// que precise ser refletida na interface do usu�rio.
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
        /// Manipula o evento de clique no bot�o de c�lculo do custo m�dio por quil�metro.
        /// Este m�todo calcula e exibe o custo m�dio por quil�metro com base no custo por litro fornecido pelo usu�rio.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de c�lculo do custo m�dio.</param>
        /// <param name="e">Argumentos do evento, que cont�m informa��es adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O m�todo realiza as seguintes opera��es:
        /// 1. Tenta converter o texto do campo txtCustoPorLitro para um valor double.
        /// 2. Se a convers�o for bem-sucedida, calcula o custo m�dio por quil�metro usando o m�todo CalcularCustoMedioPorKm do carro.
        /// 3. Exibe o resultado formatado no campo txtResultado.
        /// 4. Se a convers�o falhar, exibe uma mensagem de erro solicitando um valor v�lido.
        /// 5. Atualiza os dados do ve�culo na interface, chamando AtualizarDadosVeiculo.
        /// Este m�todo � crucial para fornecer ao usu�rio informa��es sobre a efici�ncia econ�mica do ve�culo.
        /// </remarks>
        private void btnCustoMedio_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCustoPorLitro.Text, out double custoPorLitro))
            {
                double custoMedio = carro.CalcularCustoMedioPorKm(custoPorLitro);
                txtResultado.Text = $"Custo m�dio por quil�metro: {custoMedio:F2} �";
            }
            else
            {
                txtResultado.Text = "Insira um valor v�lido para o custo por litro.";
            }
            AtualizarDadosVeiculo();
        }

        /// <summary>
        /// Manipula o evento de clique no bot�o de adi��o de combust�vel.
        /// Este m�todo permite ao usu�rio adicionar uma quantidade espec�fica de combust�vel ao dep�sito do carro.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de adicionar combust�vel.</param>
        /// <param name="e">Argumentos do evento, que cont�m informa��es adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O m�todo executa as seguintes a��es:
        /// 1. Tenta converter o texto do campo txtLitrosAdicionar para um valor double.
        /// 2. Se a convers�o for bem-sucedida, chama o m�todo AdicionarCombustivel do carro com a quantidade especificada.
        /// 3. Atualiza a interface do usu�rio chamando AtualizarDadosVeiculo.
        /// 4. Exibe uma mensagem de sucesso no campo txtResultado.
        /// 5. Se a convers�o falhar, exibe uma mensagem de erro solicitando um valor v�lido.
        /// Este m�todo � essencial para simular o reabastecimento do ve�culo e manter o controle do n�vel de combust�vel.
        /// </remarks>
        private void btnAdicionarCombustivel_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLitrosAdicionar.Text, out double litros))
            {
                carro.AdicionarCombustivel(litros);
                AtualizarDadosVeiculo();
                txtResultado.Text = "Combust�vel adicionado com sucesso!";
            }
            else
            {
                txtResultado.Text = "Insira um valor v�lido para os litros a adicionar.";
            }
        }

        /// <summary>
        /// Manipula o evento de clique no bot�o de c�lculo de quil�metros poss�veis.
        /// Este m�todo calcula e exibe a dist�ncia m�xima que o carro pode percorrer com o combust�vel atual.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de calcular quil�metros.</param>
        /// <param name="e">Argumentos do evento, que cont�m informa��es adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O m�todo realiza as seguintes opera��es:
        /// 1. Chama o m�todo CalcularQuilometrosPossiveis do carro para obter a dist�ncia m�xima.
        /// 2. Exibe o resultado formatado no campo txtResultado.
        /// 3. Atualiza os dados do ve�culo na interface, chamando AtualizarDadosVeiculo.
        /// Este c�lculo � importante para que o usu�rio possa estimar a autonomia atual do ve�culo.
        /// </remarks>
        private void btnCalcularQuilometros_Click(object sender, EventArgs e)
        {
            double quilometrosPossiveis = carro.CalcularQuilometrosPossiveis();
            txtResultado.Text = $"Quil�metros poss�veis: {quilometrosPossiveis:F2} km";
            AtualizarDadosVeiculo();
        }

        /// <summary>
        /// Manipula o evento de clique no bot�o de registro de viagem.
        /// Este m�todo permite ao usu�rio registrar uma nova viagem, atualizando a quilometragem e o n�vel de combust�vel do carro.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de registrar viagem.</param>
        /// <param name="e">Argumentos do evento, que cont�m informa��es adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O m�todo executa as seguintes a��es:
        /// 1. Tenta converter o texto do campo txtViagem para um valor double representando a dist�ncia da viagem.
        /// 2. Se a convers�o for bem-sucedida, chama o m�todo RegistarViagem do carro com a dist�ncia especificada.
        /// 3. Atualiza a interface do usu�rio chamando AtualizarDadosVeiculo e AtualizarInfoDetalhada.
        /// 4. Exibe uma mensagem de sucesso no campo txtResultado.
        /// 5. Verifica se o carro est� na reserva de combust�vel ap�s a viagem e exibe um alerta se necess�rio.
        /// 6. Se a convers�o falhar, exibe uma mensagem de erro solicitando um valor v�lido.
        /// Este m�todo � crucial para simular o uso do ve�culo e atualizar seu estado conforme as viagens s�o realizadas.
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
                    MessageBox.Show("Aten��o! O ve�culo est� na reserva de combust�vel. Abaste�a o mais r�pido poss�vel.",
                            "Alerta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtResultado.Text = "Insira um valor v�lido para a viagem.";
            }
        }
        /// <summary>
        /// Manipula o evento de clique no bot�o de atualiza��o da matr�cula.
        /// Este m�todo permite ao usu�rio atualizar a matr�cula do carro e resetar seus dados.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de atualizar matr�cula.</param>
        /// <param name="e">Argumentos do evento, que cont�m informa��es adicionais sobre o evento de clique.</param>
        /// <remarks>
        /// O m�todo realiza as seguintes opera��es:
        /// 1. Obt�m a nova matr�cula do campo txtMatricula.
        /// 2. Verifica se a nova matr�cula n�o � nula ou vazia.
        /// 3. Se v�lida, chama o m�todo ResetDados do carro com a nova matr�cula.
        /// 4. Atualiza a interface do usu�rio chamando AtualizarDadosVeiculo e AtualizarInfoDetalhada.
        /// 5. Exibe uma mensagem de sucesso no campo txtResultado.
        /// 6. Se a matr�cula for inv�lida, exibe uma mensagem de erro.
        /// Este m�todo � importante para simular a troca de ve�culo ou a reinicializa��o dos dados do carro atual.
        /// </remarks>
        private void btnAtualizarMatricula_Click(object sender, EventArgs e)
        {
            string novaMatricula = txtMatricula.Text;
            if (!string.IsNullOrWhiteSpace(novaMatricula))
            {
                carro.ResetDados(novaMatricula);
                AtualizarDadosVeiculo();
                AtualizarInfoDetalhada();
                txtResultado.Text = "Matr�cula atualizada e dados resetados com sucesso!";
            }
            else
            {
                txtResultado.Text = "Insira uma matr�cula v�lida.";
            }
        }

        /// <summary>
        /// Atualiza as informa��es detalhadas do carro exibidas no formul�rio.
        /// Este m�todo compila e exibe um resumo das informa��es mais relevantes sobre o estado atual do carro.
        /// </summary>
        /// <remarks>
        /// O m�todo realiza as seguintes a��es:
        /// 1. Calcula o custo total do combust�vel consumido usando o m�todo CalcularCustoTotal do carro.
        /// 2. Calcula a quantidade de litros faltando no dep�sito.
        /// 3. Comp�e uma string formatada com as seguintes informa��es:
        ///    - Matr�cula do carro
        ///    - N�mero total de viagens realizadas
        ///    - Custo total do combust�vel consumido
        ///    - Quantidade de litros faltando no dep�sito
        /// 4. Atualiza o texto do label lblInfoDetalhada com estas informa��es.
        /// Este m�todo � essencial para fornecer ao usu�rio uma vis�o geral r�pida e atualizada do estado do carro.
        /// </remarks>
        private void AtualizarInfoDetalhada()
        {
            double custoTotal = carro.CalcularCustoTotal(ObterCustoPorLitro());
            double litrosFaltando = carro.CapacidadeDeposito - carro.LitrosNoDeposito;

            lblInfoDetalhada.Text = $"Matr�cula: {carro.Matricula}\n" +
                                    $"Numero de viagens: {carro.ContadorViagens}\n" +
                                    $"Custo total: {custoTotal:F2} �\n" +
                                    $"Litros em falta no dep�sito: {litrosFaltando:F2} L\n";
        }

        /// <summary>
        /// Obt�m o custo por litro de combust�vel a partir do campo de texto correspondente.
        /// Este m�todo tenta converter o valor inserido pelo usu�rio em um n�mero v�lido.
        /// </summary>
        /// <returns>
        /// O custo por litro como um valor double se a convers�o for bem-sucedida, ou 0 se falhar.
        /// </returns>
        /// <remarks>
        /// O m�todo realiza as seguintes opera��es:
        /// 1. Tenta converter o texto do campo txtCustoPorLitro para um valor double.
        /// 2. Se a convers�o for bem-sucedida, retorna o valor convertido.
        /// 3. Se a convers�o falhar (por exemplo, se o texto n�o for um n�mero v�lido), retorna 0.
        /// 
        /// Este m�todo � importante para garantir que um valor num�rico v�lido seja usado nos c�lculos
        /// relacionados ao custo do combust�vel. O retorno de 0 em caso de falha na convers�o serve
        /// como um valor padr�o seguro, evitando erros de c�lculo, mas pode resultar em c�lculos
        /// incorretos se n�o for tratado adequadamente nas fun��es que o utilizam.
        /// 
        /// � recomend�vel que as fun��es que chamam este m�todo verifiquem se o valor retornado
        /// � diferente de zero antes de utiliz�-lo em c�lculos cr�ticos.
        /// </remarks>
        private double ObterCustoPorLitro()
        {
            if (double.TryParse(txtCustoPorLitro.Text, out double custoPorLitro))
            {
                return custoPorLitro;
            }
            return 0; // Retorna 0 se n�o conseguir converter
        }
    }
}
