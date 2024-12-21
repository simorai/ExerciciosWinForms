namespace Cronometro
{
    public partial class Form1 : Form
    {
        private readonly CronometroF _cronometro; //atributo privado apenas de leitura que vai ser instanciado na class form

        public Form1()
        {
            InitializeComponent();
            _cronometro = new CronometroF(); // é necessario no construtor instanciar o cronometro para poder comecar a usa-lo
        }

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

        private void UpdateLabel() //metodo que atualiza em tempo real o cronometro
        {
            var tempo = DateTime.Now - _cronometro.StartTime(); //variavel que vai servir para atualizar a label
            LabelContador.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3}", tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds);
        }

        private void TimerRelogio_Tick(object sender, EventArgs e) // metodo que chama o UpdateLabel para resentar em tempo real o cronometro
        {
            UpdateLabel();
        }
    }
}
