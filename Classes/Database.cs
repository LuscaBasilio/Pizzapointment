using System;
using System.Text;
using System.IO;
namespace Senai.Exercicio.Pizzaria.Classes
{
    public static class Database
    {
        public static Usuario[] usuarios = new Usuario[1];
        public static Produto[] produto = new Produto[1];

        public static Usuario usuarioLogado = null;

        /// <summary>
        /// Insere um usuario no ultimo index do vetor
        /// </summary>
        /// <param name="id">Posição do usuario no vetor</param>
        public static void CadastrarUsuario(int id){
            usuarios[id].ID = id;

            Design.Instrucao("Insira o seu nome");
            usuarios[id].Nome = Console.ReadLine();
            //  EMAIL
            Design.Instrucao("Insira um email (Ex: email@provedor.com)");
            do{
                usuarios[id].Email = Console.ReadLine();
            } while(usuarios[id].Email != null);
            //  SENHA
            Design.Instrucao("Insira uma email");
            do{
                usuarios[id].Senha = Console.ReadLine();
            } while(usuarios[id].Senha != null);
            //  Data de criação
            usuarios[id].SetData(DateTime.Now);

            Design.MensagemSucesso($"Usuario {usuarios[id].Nome} cadastrado com sucesso no id {id}");
        }
        /// <summary>
        /// 
        /// </summary>
        public static void EfetuaLogin(){
            Design.Instrucao("Insira o seu email");
            string email = Console.ReadLine();

            foreach (Usuario item in usuarios)
            {
                if(item.Email == email){
                    Design.Instrucao("Insira a senha");
                    string senha = Console.ReadLine();

                    sbyte tentativas = 0;
                    do{
                        Design.MensagemErro("Senha invalida . Insira novamente");
                        senha = Console.ReadLine();
                        if(senha!=item.Senha)tentativas++;
                    }while(senha!=item.Senha || tentativas > 3);

                    // verificação de seguranço
                    if(tentativas > 3){
                        Design.MensagemErro("Maximo de tentativas atingido.");
                        break;
                    }else{
                        if(usuarioLogado!= null){

                        }else{
                            Design.MensagemErro("Você ja está logado.");
                            Logoff();
                        }
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Desloga o usuario
        /// </summary>
        public static void Logoff(){
            Design.Instrucao("Deseja deslogar?");
                            Console.WriteLine("[1] SIM\n[2] NÃO");

                            sbyte escolha ;
                            sbyte.TryParse(Console.ReadLine(),out escolha);

                            switch(escolha){
                                case 1:
                                    Design.MensagemSucesso("Você deslogou com sucesso");
                                    usuarioLogado = null;
                                    break;
                                case 2:
                                    //Merda nenhuma acontece
                                    break;
                                default:
                                    break;
                            }
        }
    }
}