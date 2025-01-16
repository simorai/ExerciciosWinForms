using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsAppFormulaOne
{
    /// <summary>
    /// Representa um carro com funcionalidades relacionadas ao consumo de combustível e registro de viagens.
    /// Esta classe encapsula informações como matrícula, quilometragem, capacidade do depósito de combustível,
    /// consumo médio e contagem de viagens realizadas.
    /// </summary>
    public class Carro
    {
        #region Atributos

        private string _matricula;
        private double _quilometragemTotal;
        private double _capacidadeDeposito;  // Capacidade total do depósito em litros
        private double _litrosNoDeposito; // Litros atualmente no depósito
        private double _consumoMedio; // Consumo médio em litros por 100 km
        private int _contadorViagens; // Contador de viagens realizadas

        #endregion Atributos
        /// <summary>
        /// Inicializa uma nova instância da classe Carro com os parâmetros especificados.
        /// </summary>
        /// <param name="matricula">A matrícula única do carro, usada para identificação.</param>
        /// <param name="capacidadeDeposito">A capacidade total do depósito de combustível em litros.</param>
        /// <param name="consumoMedio">O consumo médio de combustível do carro em litros por 100 km.</param>
        /// <remarks>
        /// Ao criar uma nova instância, o depósito é inicializado como cheio, a quilometragem total é zero,
        /// e o contador de viagens é iniciado em zero.
        /// </remarks>
        public Carro(string matricula/*, double capacidadeDeposito*/, double consumoMedio)
        {
            _matricula = matricula;
            _capacidadeDeposito = 50; /*capacidadeDeposito;*/
            _litrosNoDeposito = _capacidadeDeposito; // Inicialmente o depósito está cheio
            _consumoMedio = consumoMedio;
            _quilometragemTotal = 0;
            _contadorViagens = 0;
        }

        #region Propriedades

        /// <summary>
        /// Obtém ou define a matrícula do carro.
        /// </summary>
        /// <value>
        /// Uma string representando a matrícula única do carro.
        /// </value>
        /// <remarks>
        /// A matrícula é usada para identificação do veículo e deve ser única.
        /// </remarks>
        public string Matricula
        {
            get
            {
                return _matricula;
            }
            set
            {
                _matricula = value;
            }
        }

        /// <summary>
        /// Obtém ou define a quilometragem total do carro.
        /// </summary>
        /// <value>
        /// Um valor double representando o total de quilômetros percorridos pelo carro.
        /// </value>
        /// <remarks>
        /// Este valor é incrementado automaticamente quando novas viagens são registradas.
        /// </remarks>
        public double QuilometragemTotal
        {
            get
            {
                return _quilometragemTotal;
            }
            set
            {
                _quilometragemTotal = value;
            }
        }

        /// <summary>
        /// Obtém ou define a capacidade total do depósito de combustível em litros.
        /// </summary>
        /// <value>
        /// Um valor double representando a capacidade máxima do depósito em litros.
        /// </value>
        /// <remarks>
        /// Este valor é usado para calcular a autonomia do veículo e controlar o abastecimento.
        /// </remarks>
        public double CapacidadeDeposito
        {
            get
            {
                return _capacidadeDeposito;
            }
        }
        /// <summary>
        /// Obtém ou define a quantidade atual de litros no depósito de combustível.
        /// </summary>
        /// <value>
        /// Um valor double, arredondado para duas casas decimais, representando a quantidade de combustível no depósito.
        /// </value>
        /// <remarks>
        /// O valor é arredondado para duas casas decimais para maior precisão nas operações de cálculo de consumo.
        /// </remarks>
        public double LitrosNoDeposito
        {
            get { return Math.Round(_litrosNoDeposito, 2); }
            set { _litrosNoDeposito = value; }
        }
        /// <summary>
        /// Obtém ou define o consumo médio de combustível do carro.
        /// </summary>
        /// <value>
        /// Um valor double representando o consumo médio em litros por 100 km.
        /// </value>
        /// <remarks>
        /// Este valor é usado para calcular o consumo de combustível durante as viagens e a autonomia do veículo.
        /// </remarks>
        public double ConsumoMedio
        {
            get { return _consumoMedio; }
            set { _consumoMedio = value; }
        }
        /// <summary>
        /// Obtém ou define o número total de viagens realizadas pelo carro.
        /// </summary>
        /// <value>
        /// Um valor inteiro representando o número de viagens registradas.
        /// </value>
        /// <remarks>
        /// Este contador é incrementado automaticamente cada vez que uma nova viagem é registrada com sucesso.
        /// </remarks>
        public int ContadorViagens
        {
            get { return _contadorViagens; }
            set { _contadorViagens = value; }
        }
        #endregion Propriedades


        #region Metodos

        /// <summary>
        /// Calcula a distância máxima que o carro pode percorrer com o combustível atual.
        /// </summary>
        /// <returns>
        /// Um valor double representando o número de quilômetros que podem ser percorridos.
        /// </returns>
        /// <remarks>
        /// Este cálculo é baseado no consumo médio do carro e na quantidade atual de combustível no depósito.
        /// É útil para estimar a autonomia do veículo antes do próximo reabastecimento.
        /// </remarks>
        public double CalcularQuilometrosPossiveis()
        {
            // Consumo médio por quilómetro
            double consumoPorKm = ConsumoMedio / 100;
            return LitrosNoDeposito / consumoPorKm; // Quilómetros possíveis
        }

        /// <summary>
        /// Registra uma nova viagem, atualizando a quilometragem total, o combustível restante e o contador de viagens.
        /// </summary>
        /// <param name="quilometros">A distância percorrida na viagem em quilômetros.</param>
        /// <remarks>
        /// Este método verifica se há combustível suficiente para a viagem. Se houver, atualiza os dados do carro.
        /// Caso contrário, exibe uma mensagem de erro no console.
        /// A viagem só é contabilizada se houver combustível suficiente para completá-la.
        /// </remarks>
        public void RegistarViagem(double quilometros)
        {
            // Verifica se há combustível suficiente para a viagem
            double consumoNecessario = (quilometros * ConsumoMedio) / 100;
            if (consumoNecessario <= LitrosNoDeposito)
            {
                QuilometragemTotal += quilometros; // Atualiza a quilometragem total
                LitrosNoDeposito -= consumoNecessario; // Atualiza a quantidade de combustível
                ContadorViagens++; // Incrementa o contador de viagens
            }
            else
            {
                Console.WriteLine("Combustível insuficiente para a viagem.");
            }
        }

        /// <summary>
        /// Verifica se o carro está na reserva de combustível.
        /// </summary>
        /// <returns>
        /// True se o carro estiver na reserva (10 litros ou menos), false caso contrário.
        /// </returns>
        /// <remarks>
        /// Este método considera que a reserva é atingida quando restam 10 litros ou menos no depósito.
        /// É útil para alertar o usuário sobre a necessidade de reabastecimento.
        /// </remarks>
        public bool EstaNaReserva()
        {
            return LitrosNoDeposito <= 10; // Considera que a reserva é de 10 litros
        }

        /// <summary>
        /// Calcula o custo total do combustível consumido desde o último abastecimento completo.
        /// </summary>
        /// <param name="custoPorLitro">O custo por litro de combustível.</param>
        /// <returns>
        /// Um valor double representando o custo total do combustível consumido.
        /// </returns>
        /// <remarks>
        /// Este cálculo é baseado na diferença entre a capacidade total do depósito e a quantidade atual de combustível,
        /// multiplicada pelo custo por litro fornecido.
        /// </remarks>
        public double CalcularCustoTotal(double custoPorLitro)
        {
            return (CapacidadeDeposito - LitrosNoDeposito) * custoPorLitro; // Custo total
        }

        /// <summary>
        /// Calcula o custo médio por quilômetro percorrido.
        /// </summary>
        /// <param name="custoPorLitro">O custo por litro de combustível.</param>
        /// <returns>
        /// Um valor double representando o custo médio por quilômetro percorrido.
        /// Retorna 0 se nenhum quilômetro foi percorrido para evitar divisão por zero.
        /// </returns>
        /// <remarks>
        /// Este método utiliza o custo total calculado e a quilometragem total para determinar o custo médio por km.
        /// É útil para análises de eficiência e planejamento de custos de viagem.
        /// </remarks>
        public double CalcularCustoMedioPorKm(double custoPorLitro)
        {
            if (QuilometragemTotal == 0)
            {
                return 0; // Evita divisão por zero
            } 
            return CalcularCustoTotal(custoPorLitro) / QuilometragemTotal; // Custo médio por km
        }

        /// <summary>
        /// Adiciona combustível ao depósito do carro.
        /// </summary>
        /// <param name="litros">A quantidade de litros a ser adicionada.</param>
        /// <remarks>
        /// Este método verifica se a quantidade a ser adicionada excede a capacidade disponível no depósito.
        /// Se exceder, o depósito é preenchido até sua capacidade máxima.
        /// Caso contrário, adiciona a quantidade especificada.
        /// </remarks>
        public void AdicionarCombustivel(double litros)
        {
            double litrosPossiveis = CapacidadeDeposito - LitrosNoDeposito; // Litros que cabem no depósito
            if (litros > litrosPossiveis)
            {
                LitrosNoDeposito = CapacidadeDeposito; // Enche o depósito
            }
            else
            {
                LitrosNoDeposito += litros; // Adiciona a quantidade especificada
            }
        }

        /// <summary>
        /// Reseta os dados do carro, mantendo apenas a capacidade do depósito e o consumo médio.
        /// </summary>
        /// <param name="novaMatricula">A nova matrícula a ser atribuída ao carro.</param>
        /// <remarks>
        /// Este método é útil para "reiniciar" o carro, como se fosse um novo veículo.
        /// Ele mantém as características físicas do carro (capacidade do depósito e consumo médio),
        /// mas redefine a matrícula, zera a quilometragem e o contador de viagens, e enche o depósito.
        /// </remarks>
        public void ResetDados(string novaMatricula)
        {
            Matricula = novaMatricula;
            QuilometragemTotal = 0;
            LitrosNoDeposito = _capacidadeDeposito; // Reseta com o depósito cheio
            ContadorViagens = 0;
        }
    }    
    #endregion Metodos
}