namespace Senai.Exercicio.Pizzaria.Classes {
    public abstract class Entidade {
        public int ID;
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