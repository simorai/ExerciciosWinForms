namespace Cronometro
{
    public class Cronometro
    {
        #region Atributos

        private DateTime _start; //inicio do cronometro
        private DateTime _stop; //fim do cronometro
        private bool _isrunning; //indica se esta ligado ou desligado

        #endregion

        public void StartClock() //metodo que liga o cronometro
        {
            if (_isrunning) // se já não estiver ligado...
                throw new InvalidOperationException("O cronometro já esta ligado");

            _start = DateTime.Now; // vai buscar a data do sistema na altura
            _isrunning = true; // cronometro ligado
        }

        public void StopClock() //metodo que desliga o cronometro
        {
            if (!_isrunning) // senao estiver desligado...
                throw new InvalidOperationException("O cronometro já esta desligado");

            _stop = DateTime.Now; // vai buscar a data do sistema e guarda no _stop
            _isrunning = false; //desliga o cronometro
        }

        public TimeSpan GetTimeSpan() // TimeSpan representa um intervalo de tempo ou duração
        {
            return _stop - _start; // obtem o valor entre o começo e o fim do relogio
        }

        public bool ClockState() //metodo que retorna o estado do cronometro, ligado/desligado
        {
            return _isrunning;
        }

        public DateTime StarTime() // retorna o valor de inicio
        {
            return _start;
        }


    }
}
