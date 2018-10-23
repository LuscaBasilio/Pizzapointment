namespace Senai.Exercicio.Pizzaria.Classes {
    public abstract class Entidade {
        /// <summary>
        /// [Encapsulado]
        /// </summary>
        /// <value>Retorna o ID do objeto somado mais um</value>
        public int ID {
            get {
                return ID +1;
            }
            set{
                ID = value;
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