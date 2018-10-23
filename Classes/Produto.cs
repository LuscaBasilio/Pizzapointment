namespace Senai.Exercicio.Pizzaria.Classes
{
    public class Produto : Entidade
    {
        public string Descricao;
        public double Preco;
        private string Categoria;
        /// <summary>
        /// Seta a variavel privada Categoria para um dos 2 valores a seguir.  
        /// 1 - Pizza  
        /// 2 - Bebida
        /// </summary>
        /// <param name="tipo">index da categoria do produto</param>
        public void SetCategoria(sbyte tipo){
            switch (tipo)
            {
                case 1:
                    Categoria = "Pizza";
                    break;

                case 2:
                    Categoria =  "Bebida";
                    break;

                default:
                    Design.MensagemErro("Valor invalido!");
                    break;
            }
        }
    }
}