using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppBalao
{
    /// <summary>
    /// Representa o formulário principal da aplicação do balão.
    /// </summary>
    public partial class Form1 : Form
    {
        private Balao meuBalao;

        /// <summary>
        /// Inicializa uma nova instância do formulário principal da aplicação.
        /// </summary>
        /// <remarks>
        /// Este construtor realiza as seguintes ações:
        /// <list type="bullet">
        ///     <item>Inicializa os componentes do formulário.</item>
        ///     <item>Cria uma nova instância de Balao com cor vermelha, direção "No Chão" e altura 0.</item>
        ///     <item>Configura o formulário para capturar eventos de teclado antes dos controles.</item>
        ///     <item>Associa o método Form1_KeyDown ao evento KeyDown do formulário.</item>
        /// </list>
        /// </remarks>
        public Form1()
        {
            InitializeComponent();
            meuBalao = new Balao("Vermelho", "No Chão", 0);
            // Permite que o formulário capture eventos de tecla antes dos controles
            KeyPreview = true;
            // Adiciona o manipulador para o evento KeyDown
            KeyDown += Form1_KeyDown;
        }

        /// <summary>
        /// Atualiza o estado do balão no formulário.
        /// </summary>
        private void AtualizarEstadoBalao()
        {
            // Atualiza o estado do balão com os atributos atualizados
            lblEstado.Text = meuBalao.GetEstado();
        }

        /// <summary>
        /// Manipula o evento de clique no botão "Subir", fazendo o balão subir na interface gráfica e atualizando seu estado interno.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão "Subir".</param>
        /// <param name="e">Os argumentos do evento, que não são utilizados neste método.</param>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Aumenta a altura visual do balão na interface gráfica em 10 unidades.</item>
        /// <item>Garante que o balão não ultrapasse o topo da tela.</item>
        /// <item>Atualiza a posição do balão na PictureBox.</item>
        /// <item>Atualiza o estado interno do objeto balão, aumentando sua altura.</item>
        /// <item>Atualiza a exibição do estado do balão no formulário.</item>
        /// </list>
        /// </remarks>
        private void btnSubir_Click(object sender, EventArgs e)
        {
            // Valor fixo para subir
            int valorSubir = 10;

            // Calcula a nova posição Y (vertical) do balão.
            // picBalao.Location.Y para obter a posição Y atual do balão.
            // Subtrai valorSubir da posição Y atual para determinar a nova posição.
            // Math.Max(0, novaPosicaoY) para garantir que a nova posição Y não seja menor que 0, impedindo que o balão saia da tela para cima.
            int novaPosicaoY = Math.Max(0, picBalao.Location.Y - valorSubir);

            // Mantém a posição X (horizontal) inalterada (picBalao.Location.X)
            // Usa a nova posição Y calculada (novaPosicaoY)
            picBalao.Location = new Point(picBalao.Location.X, novaPosicaoY);

            // Chama o método Subir do objeto meuBalao para atualizar sua altura interna
            meuBalao.Subir(valorSubir);
            
            AtualizarEstadoBalao();            
        }

        /// <summary>
        /// Manipula o evento de clique no botão "Descer", fazendo o balão descer na interface gráfica e atualizando seu estado interno.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão "Descer".</param>
        /// <param name="e">Os argumentos do evento, que não são utilizados neste método.</param>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Diminui a altura visual do balão na interface gráfica em 10 unidades.</item>
        /// <item>Garante que o balão não ultrapasse o chão (representado por picChao).</item>
        /// <item>Atualiza a posição do balão na PictureBox, considerando a altura do balão para um posicionamento preciso.</item>
        /// <item>Atualiza o estado interno do objeto balão, diminuindo sua altura.</item>
        /// <item>Atualiza a exibição do estado do balão no formulário.</item>
        /// </list>
        /// </remarks>
        /// <note>
        /// A direção do balão é automaticamente atualizada para "Sul" pelo método Descer da classe Balao.
        /// A linha comentada que define a direção como "Sul" é redundante e pode ser removida.
        /// </note>
        private void btnDescer_Click(object sender, EventArgs e)
        {
            // Define um valor constante de 10 unidades para descer o balão
            int valorDescer = 10;
            // Calcula a nova posição Y (vertical) do balão.
            // Usa picBalao.Location.Y para obter a posição Y atual do balão.
            // Usa Math.Min para garantir que o balão não ultrapasse o chão (picChao.Top), subtraindo a altura do balão (picBalao.Height) para que ele pare no topo do chão.
            int novaPosicaoY = Math.Min(picChao.Top - picBalao.Height, picBalao.Location.Y + valorDescer);

            // Atualiza a posição visual do balão no formulário
            // Mantém a posição X (horizontal) inalterada (picBalao.Location.X).
            // Usa a nova posição Y calculada(novaPosicaoY).
            picBalao.Location = new Point(picBalao.Location.X, novaPosicaoY);

            // Chama o método Descer do objeto meuBalao para atualizar sua altura interna
            meuBalao.Descer(valorDescer);
            
            // Atualiza a exibição do estado do balão no formulário
            AtualizarEstadoBalao();
        }

        /// <summary>
        /// Manipula o evento de clique no botão "Esquerda", movendo o balão para a esquerda na interface gráfica e atualizando seu estado interno.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão "Esquerda".</param>
        /// <param name="e">Os argumentos do evento, que não são utilizados neste método.</param>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Move o balão 10 unidades para a esquerda na interface gráfica.</item>
        /// <item>Garante que o balão não ultrapasse o limite esquerdo da tela (coordenada X = 0).</item>
        /// <item>Atualiza a posição horizontal do balão na PictureBox, mantendo a posição vertical inalterada.</item>
        /// <item>Atualiza a direção interna do balão para "Oeste".</item>
        /// <item>Atualiza a exibição do estado do balão no formulário.</item>
        /// </list>
        /// </remarks>
        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            // Define um valor constante para mover o balão para a esquerda
            int valorEsquerda = 10;
            // Calcula a nova posição X do balão
            int novaPosicaoX = Math.Max(0, picBalao.Location.X - valorEsquerda); // Garante que não saia da tela
            // Atualiza a posição visual do balão no formulário            
            picBalao.Location = new Point(novaPosicaoX, picBalao.Location.Y);
            // Atualiza a direção do balão
            meuBalao.SetDirecao("Oeste");
            AtualizarEstadoBalao(); // Atualiza o estado exibido            
        }

        /// <summary>
        /// Manipula o evento de clique no botão "Direita", movendo o balão para a direita na interface gráfica e atualizando seu estado interno.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão "Direita".</param>
        /// <param name="e">Os argumentos do evento, que não são utilizados neste método.</param>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Move o balão 10 unidades para a direita na interface gráfica.</item>
        /// <item>Garante que o balão não ultrapasse o limite direito da tela, considerando a largura do formulário e do balão.</item>
        /// <item>Atualiza a posição horizontal do balão na PictureBox, mantendo a posição vertical inalterada.</item>
        /// <item>Atualiza a direção interna do balão para "Este".</item>
        /// <item>Atualiza a exibição do estado do balão no formulário.</item>
        /// </list>
        /// </remarks>
        private void btnDireita_Click(object sender, EventArgs e)
        {
            // Define um valor constante para mover o balão para a direita
            int valorDireita = 10;
            // Calcula a nova posição X do balão
            int novaPosicaoX = Math.Min(this.ClientSize.Width - picBalao.Width, picBalao.Location.X + valorDireita);// Garante que não saia da tela
            // Atualiza a posição visual do balão no formulário
            picBalao.Location = new Point(novaPosicaoX, picBalao.Location.Y);
            // Atualiza a direção do balão
            meuBalao.SetDirecao("Este"); // Atualiza a direção do balão
            AtualizarEstadoBalao(); // Atualiza o estado exibido            
        }

        /// <summary>
        /// Manipula o evento de carregamento do formulário, inicializando a posição do balão e atualizando seu estado na interface.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o próprio formulário.</param>
        /// <param name="e">Os argumentos do evento, que não são utilizados neste método.</param>
        /// <remarks>
        /// Este método realiza as seguintes ações durante o carregamento do formulário:
        /// <list type="bullet">
        /// <item>Posiciona o balão (representado por picBalao) de modo que sua base fique exatamente no topo do chão (representado por picChao).</item>
        /// <item>Mantém a posição horizontal (X) atual do balão.</item>
        /// <item>Calcula a posição vertical (Y) do balão subtraindo a altura do balão da posição do topo do chão.</item>
        /// <item>Atualiza a exibição do estado inicial do balão na interface do usuário.</item>
        /// </list>
        /// </remarks>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Posiciona o balão encostado no chão
            picBalao.Location = new Point(
            picBalao.Location.X, // Mantém a posição X atual do balão
            picChao.Top - picBalao.Height // Calcula a posição Y para que o balão fique no topo do chão
            );
            // Este cálculo coloca a base do balão exatamente no topo do chão:
            // picChao.Top é a coordenada Y do topo do chão
            // picBalao.Height é a altura da imagem do balão
            // Subtraindo a altura do balão da posição do chão, obtemos a posição Y correta

            // Atualiza o estado inicial do balão na interface do usuário
            AtualizarEstadoBalao();
        }

        /// <summary>
        /// Manipula o evento de clique na label de estado, atualizando seu texto com as informações do balão.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente a label de estado.</param>
        /// <param name="e">Os argumentos do evento, que não são utilizados neste método.</param>
        /// <remarks>
        /// Este método é chamado quando o usuário clica na label que exibe o estado do balão.
        /// Ele atualiza o texto da label com a representação atual do estado do balão,
        /// incluindo informações sobre a cor, direção e altura.
        /// </remarks>
        private void lblEstado_Click(object sender, EventArgs e)
        {
            lblEstado.Text = meuBalao.GetEstado();
        }

        /// <summary>
        /// Manipula o evento de clique no botão "Mudar Cor", alterando a cor do balão conforme a entrada do usuário.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão "Mudar Cor".</param>
        /// <param name="e">Os argumentos do evento, que não são utilizados neste método.</param>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Obtém a nova cor a partir do campo de texto (txtCor).</item>
        /// <item>Tenta definir a nova cor no objeto balão (meuBalao).</item>
        /// <item>Se a cor for válida, atualiza a imagem do balão com o recurso correspondente.</item>
        /// <item>Se a cor não for válida, exibe uma mensagem de erro informando as cores disponíveis.</item>
        /// <item>Atualiza a exibição do estado do balão na interface do usuário.</item>
        /// </list>
        /// </remarks>
        private void btnMudarCor_Click_1(object sender, EventArgs e)
        {
            string novaCor = txtCor.Text;
            if (meuBalao.SetCor(novaCor))
            {
                string recursoImagem = meuBalao.GetImagemRecurso();
                if (recursoImagem != null)
                {
                    picBalao.Image = (Image)Properties.Resources.ResourceManager.GetObject(recursoImagem);
                }
            }
            else
            {
                MessageBox.Show("Não me apeteceu pintar mais balões! Tens vermelho, azul ou verde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AtualizarEstadoBalao();
        }

        /// <summary>
        /// Manipula o evento de pressionamento de tecla no formulário, permitindo que o usuário controle o balão usando as setas do teclado.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o próprio formulário.</param>
        /// <param name="e">Os argumentos do evento, que contêm informações sobre a tecla pressionada.</param>
        /// <remarks>
        /// Este método verifica qual tecla foi pressionada e executa a ação correspondente:
        /// <list type="bullet">
        /// <item>Se a tecla pressionada for a seta para cima, simula um clique no botão "Subir".</item>
        /// <item>Se a tecla pressionada for a seta para baixo, simula um clique no botão "Descer".</item>
        /// <item>Se a tecla pressionada for a seta para a direita, simula um clique no botão "Direita".</item>
        /// <item>Se a tecla pressionada for a seta para a esquerda, simula um clique no botão "Esquerda".</item>
        /// </list>
        /// </remarks>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é a seta para cima
            if (e.KeyCode == Keys.Up) // Verifica se a tecla pressionada é a seta para cima
            {
                // Simula um clique no botão "Subir", acionando a lógica de subida do balão
                btnSubir.PerformClick();
            }
            // Verifica se a tecla pressionada é a seta para baixo
            if (e.KeyCode == Keys.Down)
            {
                // Simula um clique no botão "Descer", acionando a lógica de descida do balão
                btnDescer.PerformClick();
            }
            // Verifica se a tecla pressionada é a seta para a direita
            if (e.KeyCode == Keys.Right)
            {
                // Simula um clique no botão "btnDireita", acionando a lógica de ir para a direita do balão
                btnDireita.PerformClick();
            }
            // Verifica se a tecla pressionada é a seta para a esquerda
            if (e.KeyCode == Keys.Left)
            {
                // Simula um clique no botão "btnEsquerda", acionando a lógica de ir para a esquerda do balão
                btnEsquerda.PerformClick();
            }
        }
    }
}
