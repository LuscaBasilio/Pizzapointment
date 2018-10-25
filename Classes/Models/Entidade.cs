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
        public string DataCriacao;
    }
}