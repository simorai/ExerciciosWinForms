namespace Cronometro
{
    /// <summary>
    /// Representa o formul�rio principal da aplica��o.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// O cron�metro utilizado neste formul�rio.
        /// </summary>
        /// <remarks>
        /// Este campo � somente leitura e � inicializado no construtor do formul�rio.
        /// </remarks>
        private readonly CronometroF _cronometro; //atributo privado apenas de leitura que vai ser instanciado na class form

        /// <summary>
        /// Inicializa uma nova inst�ncia da classe Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _cronometro = new CronometroF(); // � necessario no construtor instanciar o cronometro para poder comecar a usa-lo
        }
        /// <summary>
        /// Manipula o evento de clique do bot�o para ligar/desligar o cron�metro.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        /// <remarks>
        /// Este m�todo alterna o estado do cron�metro entre ligado e desligado.
        /// Quando o cron�metro � desligado:
        /// <list type="bullet">
        /// <item>Para o cron�metro</item>
        /// <item>Muda o texto do bot�o para "liga"</item>
        /// <item>Desativa o TimerRelogio</item>
        /// </list>
        /// Quando o cron�metro � ligado:
        /// <list type="bullet">
        /// <item>Inicia o cron�metro</item>
        /// <item>Muda o texto do bot�o para "Desliga"</item>
        /// <item>Ativa o TimerRelogio</item>
        /// </list>
        /// </remarks>
        private void ButtonOnOff_Click(object sender, EventArgs e) //metodo para ligar e desligar o butao do cronometro
        {
            if (_cronometro.ClockState())
            {
                _cronometro.StopClock();
                ButtonOnOff.Text = "liga";
                TimerRelogio.Enabled = false;                
            }
            else
            {
                _cronometro.StartClock();
                ButtonOnOff.Text = "Desliga";
                TimerRelogio.Enabled = true;
            }
        }

        /// <summary>
        /// Atualiza o r�tulo do cron�metro em tempo real.
        /// </summary>
        /// <remarks>
        /// Este m�todo calcula a diferen�a de tempo entre o momento atual e o momento em que o cron�metro foi iniciado,
        /// e atualiza o texto do r�tulo com a dura��o formatada.
        /// </remarks>
        private void UpdateLabel()
        {
            var tempo = DateTime.Now - _cronometro.StartTime(); //variavel que vai servir para atualizar a label
            LabelContador.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3}", 
                tempo.Hours, 
                tempo.Minutes, 
                tempo.Seconds, 
                tempo.Milliseconds);
        }

        /// <summary>
        /// Manipula o evento Tick do TimerRelogio.
        /// </summary>
        /// <remarks>
        /// Este m�todo � chamado em intervalos regulares pelo TimerRelogio.
        /// Ele invoca o m�todo <see cref="UpdateLabel"/> para atualizar o r�tulo do cron�metro
        /// em tempo real, refletindo a dura��o decorrido desde que o cron�metro foi iniciado.
        /// </remarks>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o Timer.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void TimerRelogio_Tick(object sender, EventArgs e) // metodo que chama o UpdateLabel para resentar em tempo real o cronometro
        {
            UpdateLabel();
        }
    }
}
