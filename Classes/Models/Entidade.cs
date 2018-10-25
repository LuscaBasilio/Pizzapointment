namespace Senai.Exercicio.Pizzaria.Classes.Models {
    public abstract class Entidade {
        private int id = 0;
        /// <summary>
        /// [Encapsulado]
        /// </summary>
        /// <value>Retorna o ID do objeto somado mais um</value>
        public int ID
        {
            get
            {
                return id + 1;
            }
            set
            {
                id = value;
            }
        }
        public string Nome;
        protected string DataCriacao;
        /// <summary>
        /// Convete o tipo DateTime para string
        /// </summary>
        /// <param name="data">UmDateTimeAe</param>
        public void SetData (System.DateTime data) {
            DataCriacao = data.ToString ();
        }
    }
}