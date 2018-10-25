namespace Senai.Exercicio.Pizzaria.Classes.Models
{
    /// <summary>
    /// Classe que representa o objeto produto
    /// </summary>
    public class Produto : Entidade
    {
        private double preco = 0.0;
        public string Descricao;
        /// <summary>
        /// [Encapsulado]
        /// </summary>
        /// <value>Deve ser setado um valor maior do que 0</value>
        public double Preco{
            get{
                return preco;
            }
            set{
                if(value>0){
                    Senai.Exercicio.Pizzaria.Classes.Utilidades.Design.MensagemErro("O Preoço do produto não pode ser igual ou menor do que 0");
                }else{
                    preco = value;
                }
            }
        }
        public string Categoria;   
    }
}