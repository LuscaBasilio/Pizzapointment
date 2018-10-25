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
                return Email;
            }

            set {
                if (value.Contains ('@') && value.Contains ('.')) {
                    email = value;
                } else {
                    Design.MensagemErro ("Email invalido"); //ARRUMA SABOSTA
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
                    Design.MensagemErro ("Senha invalida (contém menos de 6 caracteres)");
                }
            }
        }

    }
}