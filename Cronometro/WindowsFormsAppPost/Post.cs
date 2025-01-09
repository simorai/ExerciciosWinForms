using System;


namespace WindowsFormsAppPost
{
    public class Post
    {
        #region Atributes

        /// <summary>
        /// O título do post.
        /// </summary>
        private string _titulo;
        /// <summary>
        /// A descrição detalhada do post.
        /// </summary>
        private string _descricao;
        /// <summary>
        /// A data e hora de criação do post.
        /// </summary>
        private DateTime _data;
        /// <summary>
        /// O número de "gostos" que o post recebeu.
        /// </summary>
        private int _gostos;
        /// <summary>
        /// O número de "não gostos" que o post recebeu.
        /// </summary>
        private int _naoGostos;

        #endregion

        #region Properties

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

            _titulo = titulo;
            _descricao = descricao;
            _data = DateTime.Now;
            _gostos = 0;
            _naoGostos = 0;
        }

        /// <summary>
        /// Incrementa o contador de gostos do post.
        /// </summary>
        public void Gostar()
        {
            _gostos++;
        }
        /// <summary>
        /// Incrementa o contador de não gostos do post.
        /// </summary>
        public void NaoGostar()
        {
            _naoGostos++;
        }
        /// <summary>
        /// Obtém o título do post.
        /// </summary>
        /// <returns>O título do post.</returns>
        public string GetTitulo()
        {
            return _titulo;
        }
        /// <summary>
        /// Obtém a descrição do post.
        /// </summary>
        /// <returns>A descrição do post.</returns>
        public string GetDescricao()
        {
            return _descricao;
        }
        /// <summary>
        /// Obtém a data de criação do post.
        /// </summary>
        /// <returns>A data de criação do post.</returns>
        public DateTime GetData()
        {
            return _data;
        }
        /// <summary>
        /// Obtém o número de gostos do post.
        /// </summary>
        /// <returns>O número de gostos.</returns>
        public int GetGostos()
        {
            return _gostos;
        }
        /// <summary>
        /// Obtém o número de não gostos do post.
        /// </summary>
        /// <returns>O número de não gostos.</returns>
        public int GetNaoGostos()
        {
            return _naoGostos;
        }
        #endregion
    }
}
