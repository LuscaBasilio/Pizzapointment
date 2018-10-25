using Senai.Exercicio.Pizzaria.Classes.Utilidades;

namespace Senai.Exercicio.Pizzaria.Classes.Models {
    public class Usuario : Entidade {
        private string email;
        /// <summary>
        /// [Encapsulado]
        /// </summary>
        /// <value>O Valor apenas é aceito quando contem os caracteres '@' e '.'</value>
        public string Email {
            get {
                return email;
            }

            set {
                if (value.Contains ('@') && value.Contains ('.')) {
                    email = value.ToLower();
                } else {
                    Design.MensagemErro ("Email invalido , insira-o corretamente por favor"); //ARRUMA SABOSTA
                }
            }
        }
        private string senha ;
        /// <summary>
        /// [Encapsulado]
        /// </summary>
        /// <value>O Valor apenas é aceito quando contem mais de 6 caracteres</value>
        public string Senha {
            get {
                return senha;
            }
            set {
                if (value.Length > 6) {
                    senha = value;
                } else {
                    Design.MensagemErro ("Senha invalida as senhas devem contém mais de 6 caracteres");
                }
            }
        }

    }
}