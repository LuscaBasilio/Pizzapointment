namespace Senai.Exercicio.Pizzaria.Classes {
    public class Usuario : Entidade {

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