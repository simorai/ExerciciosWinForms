using System;
using System.Windows.Forms;


namespace WindowsFormsAppPost
{
    /// <summary>
    /// Representa o formulário principal da aplicação de gestão de posts.
    /// </summary>
    /// <remarks>
    /// Esta classe herda de Form e é responsável por:
    /// <list type="bullet">
    /// <item>Exibir a interface do utilizador para criar e interagir com posts.</item>
    /// <item>Gerir a lógica de interação entre o utilizador e os objetos Post.</item>
    /// <item>Atualizar a exibição dos detalhes do post na interface.</item>
    /// </list>
    /// A classe é declarada como partial, o que permite que parte da sua implementação
    /// seja gerada automaticamente pelo designer do Windows Forms.
    /// </remarks>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inicializa uma nova instância da classe Form1.
        /// </summary>
        /// <remarks>
        /// Este construtor realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Inicializa os componentes do formulário chamando InitializeComponent().</item>
        /// <item>Cria uma nova instância da classe Post e atribui ao campo 'post'.</item>
        /// </list>
        /// A inicialização do objeto Post aqui garante que um post vazio esteja 
        /// disponível assim que o formulário for criado.
        /// </remarks>
        public Form1()
        {
            InitializeComponent();
            post = new Post(); // Instancia a classe Post
        }

        //----------------
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
        /// Metodo que encerra o programa
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metodo que Mostra a versao do programa.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Post Version 1.0");
        }

        private void btnCriarPost_Click(object sender, EventArgs e)
        {
            NovoFormPost novoFormPost = new NovoFormPost();
            novoFormPost.Show();
        }
    }
}
