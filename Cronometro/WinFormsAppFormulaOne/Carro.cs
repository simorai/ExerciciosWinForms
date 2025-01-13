using System.Security.Cryptography;

namespace WinFormsAppFormulaOne
{
    internal class Carro
    {
        #region Atributos

        private string _matricula;
        private int _kilometragem = 0;
        private int _TotalDeposito = 100;
        private int _reservaDeposito = 10;
        private int _consumoAosCem = 5;
        private int _nrViagens = 0;

        #endregion Atributos

        #region Propriedades

        public string Matricula
        {
            get
            {
                return _matricula;
            }
        }

        public int Kilometragem
        {
            get
            {
                return _kilometragem;
            }
            set
            {
                _kilometragem = value;
            }
        }

        public int TotalDeposito
        {
            get
            {
                return _TotalDeposito;
            }
            set { _TotalDeposito = value; }
        }

        public int ReservaDeposito
        {
            get
            {
                return _reservaDeposito;
            }
            set
            {
                _reservaDeposito = value;
            }
        }

        public int ConsumoAosCem
        {
            get
            {
                return _consumoAosCem;
            }
        }

        public int NrViagens
        {
            get { return _nrViagens; }
            set { _nrViagens = value; }
        }
        #endregion Propriedades

        #region Construtores
        
        public Carro()
        {    
        }
        

        

        #endregion Construtores

        #region Metodos
        #endregion Metodos
    }

}
