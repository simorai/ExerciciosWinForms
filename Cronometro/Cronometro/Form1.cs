namespace Cronometro
{
    /// <summary>
    /// Representa o formulário principal da aplicação.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// O cronômetro utilizado neste formulário.
        /// </summary>
        /// <remarks>
        /// Este campo é somente leitura e é inicializado no construtor do formulário.
        /// </remarks>
        private readonly CronometroF _cronometro; //atributo privado apenas de leitura que vai ser instanciado na class form

        /// <summary>
        /// Inicializa uma nova instância da classe Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _cronometro = new CronometroF(); // é necessario no construtor instanciar o cronometro para poder comecar a usa-lo
        }
        /// <summary>
        /// Manipula o evento de clique do botão para ligar/desligar o cronômetro.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        /// <remarks>
        /// Este método alterna o estado do cronômetro entre ligado e desligado.
        /// Quando o cronômetro é desligado:
        /// <list type="bullet">
        /// <item>Para o cronômetro</item>
        /// <item>Muda o texto do botão para "liga"</item>
        /// <item>Desativa o TimerRelogio</item>
        /// </list>
        /// Quando o cronômetro é ligado:
        /// <list type="bullet">
        /// <item>Inicia o cronômetro</item>
        /// <item>Muda o texto do botão para "Desliga"</item>
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
        /// Atualiza o rótulo do cronômetro em tempo real.
        /// </summary>
        /// <remarks>
        /// Este método calcula a diferença de tempo entre o momento atual e o momento em que o cronômetro foi iniciado,
        /// e atualiza o texto do rótulo com a duração formatada.
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
        /// Este método é chamado em intervalos regulares pelo TimerRelogio.
        /// Ele invoca o método <see cref="UpdateLabel"/> para atualizar o rótulo do cronômetro
        /// em tempo real, refletindo a duração decorrido desde que o cronômetro foi iniciado.
        /// </remarks>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o Timer.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void TimerRelogio_Tick(object sender, EventArgs e) // metodo que chama o UpdateLabel para resentar em tempo real o cronometro
        {
            UpdateLabel();
        }
    }
}
