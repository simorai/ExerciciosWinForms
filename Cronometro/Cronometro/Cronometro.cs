namespace Cronometro
{
    public class CronometroF
    {
        #region Atributos

        private DateTime _start; //inicio do cronometro
        private DateTime _stop; //fim do cronometro
        private bool _isrunning; //indica se esta ligado ou desligado

        #endregion

        #region Metodos
        /// <summary>
        /// Inicia o cronômetro.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Verifica se o cronômetro já está em execução.</item>
        /// <item>Registra o tempo de início.</item>
        /// <item>Marca o cronômetro como em execução.</item>
        /// </list>
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Lançada quando se tenta iniciar um cronômetro que já está em execução.
        /// </exception>
        public void StartClock()
        {
            if (_isrunning) // se já não estiver ligado...
                throw new InvalidOperationException("O cronometro já esta ligado");

            _start = DateTime.Now; // vai buscar a data do sistema na altura
            _isrunning = true; // cronometro ligado
        }

        /// <summary>
        /// Para o cronômetro em execução.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Verifica se o cronômetro está em execução.</item>
        /// <item>Registra o tempo de parada.</item>
        /// <item>Marca o cronômetro como não em execução.</item>
        /// </list>
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Lançada quando se tenta parar um cronômetro que já está parado.
        /// </exception>
        public void StopClock() //metodo que desliga o cronometro
        {
            if (!_isrunning) // senao estiver desligado...
                throw new InvalidOperationException("O cronometro já esta desligado");

            _stop = DateTime.Now; // vai buscar a data do sistema e guarda no _stop
            _isrunning = false; //desliga o cronometro
        }
        /// <summary>
        /// Calcula a duração do tempo decorrido entre o início e o fim do cronômetro.
        /// </summary>
        /// <returns>
        /// Um objeto TimeSpan representando a duração do tempo medido.
        /// </returns>
        /// <remarks>
        /// Este método:
        /// <list type="bullet">
        /// <item>Calcula a diferença entre o tempo de parada (_stop) e o tempo de início (_start).</item>
        /// <item>Retorna um TimeSpan que representa essa diferença.</item>
        /// </list>
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Pode ser lançada se o cronômetro não foi parado antes de chamar este método.
        /// </exception>
        public TimeSpan GetTimeSpan() // TimeSpan representa um intervalo de tempo ou duração
        {
            return _stop - _start; // obtem o valor entre o começo e o fim do relogio
        }

        /// <summary>
        /// Obtém o estado atual do cronômetro.
        /// </summary>
        /// <returns>
        /// Um valor booleano indicando se o cronômetro está em execução.
        /// <list type="bullet">
        /// <item><c>true</c> se o cronômetro estiver em execução.</item>
        /// <item><c>false</c> se o cronômetro estiver parado.</item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// Este método fornece uma maneira de verificar se o cronômetro está atualmente em execução ou parado.
        /// </remarks>
        public bool ClockState() //metodo que retorna o estado do cronometro, ligado/desligado
        {
            return _isrunning;
        }

        /// <summary>
        /// Obtém o momento de início do cronômetro.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Lançada se o cronômetro ainda não foi iniciado.
        /// </exception>
        public DateTime StartTime() // retorna o valor de inicio
        {
            return _start;
        }

        #endregion Metodos
    }
}
