using System;

namespace WindowsFormsAppPost
{
    public class Post
    {
        #region Atributes

        /// <summary>
        /// Armazena o título do post.
        /// </summary>
        /// <remarks>
        /// Este campo é privado para manter o encapsulamento.
        /// O acesso e a modificação deste campo devem ser feitos através da propriedade pública 'Titulo'.
        /// O título não deve ser nulo ou consistir apenas de espaços em branco.
        /// </remarks>
        private string _titulo;
        /// <summary>
        /// Armazena a descrição detalhada do post.
        /// </summary>
        /// <remarks>
        /// Este campo é privado para manter o encapsulamento.
        /// O acesso e a modificação deste campo devem ser feitos através da propriedade pública 'Descricao'.
        /// A descrição não deve ser nula ou consistir apenas de espaços em branco.
        /// </remarks>
        private string _descricao;
        /// <summary>
        /// Armazena a data e hora de criação do post.
        /// </summary>
        /// <remarks>
        /// Este campo é privado para manter o encapsulamento.
        /// O acesso a este campo deve ser feito através da propriedade pública 'Data'.
        /// Normalmente, este valor é definido no momento da criação do post e não deve ser alterado posteriormente.
        /// </remarks>
        private DateTime _data;
        /// <summary>
        /// Armazena o número de "gostos" que o post recebeu.
        /// </summary>
        /// <remarks>
        /// Este campo é privado para manter o encapsulamento.
        /// O acesso e a modificação deste campo devem ser feitos através da propriedade pública 'Gostos'
        /// ou do método 'Gostar()'.
        /// Este valor deve sempre ser não-negativo.
        /// </remarks>
        private int _gostos;
        /// <summary>
        /// Armazena o número de "não gostos" que o post recebeu.
        /// </summary>
        /// <remarks>
        /// Este campo é privado para manter o encapsulamento.
        /// O acesso e a modificação deste campo devem ser feitos através da propriedade pública 'NaoGostos'
        /// ou do método 'NaoGostar()'.
        /// Este valor deve sempre ser não-negativo.
        /// </remarks>
        private int _naoGostos;

        #endregion Atributes

        /// <summary>
        /// Cria um novo post com o título e descrição fornecidos.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes ações:
        /// <list type="bullet">
        /// <item>Valida se o título e a descrição não estão vazios ou consistem apenas de espaços em branco.</item>
        /// <item>Inicializa os campos do post com os valores fornecidos.</item>
        /// <item>Define a data de criação como a data e hora atuais.</item>
        /// <item>Inicializa os contadores de gostos e não gostos com zero.</item>
        /// </list>
        /// </remarks>
        /// <param name="titulo">O título do post. Não pode ser nulo ou consistir apenas de espaços em branco.</param>
        /// <param name="descricao">A descrição do post. Não pode ser nula ou consistir apenas de espaços em branco.</param>
        /// <exception cref="ArgumentException">
        /// Lançada quando o título ou a descrição são nulos, vazios ou consistem apenas de espaços em branco.
        /// </exception>
        public void CriarPost(string titulo, string descricao)
        {
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException("Título e descrição não podem ser vazios.");
            }

            Titulo = titulo;
            Descricao = descricao;
            _data = DateTime.Now;
            Gostos = 0;
            NaoGostos = 0;
        }

        #region Properties
        /// <summary>
        /// Obtém ou define o título do post.
        /// </summary>
        /// <value>
        /// O título do post. Não pode ser nulo ou consistir apenas de espaços em branco.
        /// </value>
        /// <remarks>
        /// O setter é privado para garantir que o título só possa ser modificado internamente pela classe.
        /// </remarks>
        public string Titulo
        {
            get { return _titulo; }
            private set { _titulo = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição detalhada do post.
        /// </summary>
        /// <value>
        /// A descrição do post. Não pode ser nula ou consistir apenas de espaços em branco.
        /// </value>
        /// <remarks>
        /// O setter é privado para garantir que a descrição só possa ser modificada internamente pela classe.
        /// </remarks>
        public string Descricao
        {
            get { return _descricao; }
            private set { _descricao = value; }
        }

        /// <summary>
        /// Obtém a data e hora de criação do post.
        /// </summary>
        /// <value>
        /// Um objeto <see cref="DateTime"/> representando o momento exato em que o post foi criado.
        /// </value>
        /// <remarks>
        /// Esta propriedade é somente leitura para garantir a integridade da data de criação do post.
        /// O valor é definido internamente no momento da criação do post e não pode ser alterado posteriormente.
        /// </remarks>
        /// <example>
        /// Exemplo de uso:
        /// <code>
        /// Post meuPost = new Post();
        /// Console.WriteLine($"O post foi criado em: {meuPost.Data}");
        /// </code>
        /// </example>
        /// <seealso cref="DateTime"/>
        public DateTime Data
        {
            get { return _data; }            
        }

        /// <summary>
        /// Obtém ou define o número de "gostos" que o post recebeu.
        /// </summary>
        /// <value>
        /// Um inteiro não negativo representando o número de gostos.
        /// </value>
        /// <remarks>
        /// O setter é privado para garantir que o número de gostos só possa ser modificado internamente pela classe,
        /// tipicamente através de métodos específicos como 'Gostar()'.
        /// </remarks>
        public int Gostos
        {
            get { return _gostos; }
            private set { _gostos = value; }
        }

        /// <summary>
        /// Obtém ou define o número de "não gostos" que o post recebeu.
        /// </summary>
        /// <value>
        /// Um inteiro não negativo representando o número de não gostos.
        /// </value>
        /// <remarks>
        /// O setter é privado para garantir que o número de não gostos só possa ser modificado internamente pela classe,
        /// tipicamente através de métodos específicos como 'NaoGostar()'.
        /// </remarks>
        public int NaoGostos
        {
            get { return _naoGostos; }
            private set { _naoGostos = value; }
        }

        #endregion Properties

        /// <summary>
        /// Incrementa o contador de "gostos" do post.
        /// </summary>
        /// <remarks>
        /// Este método aumenta em 1 o número de "gostos" do post cada vez que é chamado.
        /// É a forma recomendada de registrar um novo "gosto" para o post, mantendo
        /// o encapsulamento e a integridade dos dados.
        /// </remarks>
        public void Gostar()
        {
            Gostos++;
        }

        /// <summary>
        /// Incrementa o contador de "não gostos" do post.
        /// </summary>
        /// <remarks>
        /// Este método aumenta em 1 o número de "não gostos" do post cada vez que é chamado.
        /// É a forma recomendada de registrar um novo "não gosto" para o post, mantendo
        /// o encapsulamento e a integridade dos dados.
        /// </remarks>
        public void NaoGostar()
        {
            NaoGostos++;
        }
    }
}
