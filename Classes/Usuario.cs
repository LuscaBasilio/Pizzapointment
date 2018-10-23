namespace Senai.Exercicio.Pizzaria.Classes {
    public class Usuario : Entidade {
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
                    Email = value;
                } else {
                    Design.MensagemErro ("Email invalido"); //ARRUMA SABOSTA
                    Email = null;
                }
            }
        }
        /// <summary>
        /// [Encapsulado]
        /// </summary>
        /// <value>O Valor apenas é aceito quando contem mais de 6 caracteres</value>
        public string Senha {
            get {
                return Senha;
            }
            set {
                if (value.Length > 6) {
                    Senha = value;
                } else {
                    Design.MensagemErro ("Senha invalida (contém menos de 6 caracteres)");
                    Senha = null;
                }
            }
        }

    }
}