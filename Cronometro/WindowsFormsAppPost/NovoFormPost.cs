using System;
using System.Windows.Forms;

namespace WindowsFormsAppPost
{
    public partial class NovoFormPost : Form
    {

        public NovoFormPost()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Representa o post atual sendo manipulado pela aplicação.
        /// </summary>
        /// <remarks>
        /// Este campo é inicializado com uma nova instância da classe Post.
        /// É utilizado para armazenar e gerenciar os dados do post atual,
        /// incluindo título, descrição, data, gostos e não gostos.
        /// </remarks>
        private Post post = new Post();

        /// <summary>
        /// Atualiza a interface do utilizador com as informações atuais do post.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Atualiza o título exibido com o título atual do post.</item>
        /// <item>Atualiza a descrição exibida com a descrição atual do post.</item>
        /// <item>Atualiza a data exibida com a data de criação do post.</item>
        /// <item>Atualiza o número de gostos exibido com o valor atual.</item>
        /// <item>Atualiza o número de não gostos exibido com o valor atual.</item>
        /// </list>
        /// Este método deve ser chamado sempre que houver uma mudança nos dados do post
        /// para garantir que a interface do utilizador reflita o estado atual do post.
        /// </remarks>
        private void AtualizarExibicao()
        {
            lblTitulo.Text = post.GetTitulo();
            lblDescricao.Text = post.GetDescricao();
            lblData.Text = $"Data: {post.GetData()}";
            lblGostos.Text = $"Gostos: {post.GetGostos()}";
            lblNaoGostos.Text = $"Não Gostos: {post.GetNaoGostos()}";
        }

        /// <summary>
        /// Manipula o evento de clique do botão "Gostar".
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Incrementa o contador de "gostos" do post atual.</item>
        /// <item>Atualiza a exibição na interface do utilizador para refletir o novo número de gostos.</item>
        /// </list>
        /// </remarks>
        /// <param name="sender">O objeto que desencadeou o evento, tipicamente o botão "Gostar".</param>
        /// <param name="e">Os argumentos do evento. Neste caso, não são utilizados.</param>
        private void btnGostar_Click_2(object sender, EventArgs e)
        {
            post.Gostar();
            AtualizarExibicao();
        }

        /// <summary>
        /// Manipula o evento de clique do botão "Não Gostar".
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Incrementa o contador de "não gostos" do post atual.</item>
        /// <item>Atualiza a exibição na interface do utilizador para refletir o novo número de não gostos.</item>
        /// </list>
        /// </remarks>
        /// <param name="sender">O objeto que desencadeou o evento, tipicamente o botão "Não Gostar".</param>
        /// <param name="e">Os argumentos do evento. Neste caso, não são utilizados.</param>
        private void btnNaoGostar_Click(object sender, EventArgs e)
        {
            post.NaoGostar();
            AtualizarExibicao();
        }

        /// <summary>
        /// Manipula o evento de clique do botão "Submeter".
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Cria um novo post usando os dados inseridos pelo utilizador.</item>
        /// <item>Atualiza a exibição na interface do utilizador com os detalhes do novo post.</item>
        /// <item>Limpa os campos de entrada após a submissão bem-sucedida.</item>
        /// <item>Exibe uma mensagem de confirmação ao utilizador.</item>
        /// <item>Habilita os botões de interação (Gostar e Não Gostar).</item>
        /// </list>
        /// Se ocorrer um erro durante a criação do post, uma mensagem de erro é exibida ao utilizador.
        /// </remarks>
        /// <param name="sender">O objeto que desencadeou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        /// <exception cref="ArgumentException">
        /// Lançada quando o título ou a descrição do post são inválidos (vazios ou nulos).
        /// Esta exceção é capturada e apresentada ao utilizador como uma mensagem de erro.
        /// </exception>
        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            try
            {
                // Envia os dados para criar o post
                post.CriarPost(txtTitulo.Text, txtDescricao.Text);

                // Atualiza os labels com os dados do post
                AtualizarExibicao();

                // Limpa os campos de entrada
                txtTitulo.Text = "";
                txtDescricao.Text = "";

                // Mensagem de confirmação
                MessageBox.Show("Post submetido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Habilita os botões de interação
                btnGostar.Enabled = true;
                btnNaoGostar.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                // Mostra uma mensagem de erro se os dados forem inválidos
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo que encerra o programa
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Post Version 1.0");
        }
    }
}
