using System;
using System.Text;
using System.IO;
namespace Senai.Exercicio.Pizzaria.Classes
{
    public static class Database
    {
        #region Produto
            #region Variaveis
            /// <summary>
            /// Array onde contem todos os produtos
            /// </summary>
            public static Produto[] produto = new Produto[1];
            #endregion 
            #region Metodos
                /// <summary>
                /// Cadastra produto com os seguintes atributos :  
                /// ID : é definido pela posição no vetor + 1 (não mudar o id dado nos paramentros)
                /// Nome : usuario insere
                /// Preço : usuario insere (não pode ser negativo)
                /// Descrição : usuario insere
                /// Categoria : definido Pelo SetCategoria
                /// </summary>
                ///<param name="id">Posição do usuario no vetor</param>
                public static void CadastrarProduto(int id){

                }
                /// <summary>
                /// Pede dados ao usuario e só sai do loop caso ele insira um valor correto (numero inteiro)
                /// </summary>
                /// <returns>Retorna "Pizza" ou "Bebida"</returns>
                public static string SetCategoria(){
                    string retorno = null;
                    do{
                        sbyte tipo ;
                        Design.MensagemInstrucao("Insira um dos valores a seguir");
                        Console.WriteLine("[1] Pizza\n[2] Bebida");
                        sbyte.TryParse(Console.ReadLine(),out tipo); 
                        switch (tipo)
                        {
                            case 1:
                                retorno = "Pizza";
                                break;
                            case 2:
                                retorno =  "Bebida";
                                break;
                            default:
                                Design.MensagemErro("Valor invalido!");
                                break;
                        }
                    }while(retorno == null);

                    return retorno;
                }
                /// <summary>
                /// Define o total do custo de todos os produtos no banco de dados
                /// </summary>
                public static void ExibirTotal(){

                }
                /// <summary>
                /// Procura o maior valor e armazena o seu id em uma variavel temporaria na qual será o retorno desse metodo.
                /// </summary>
                /// <returns>Retorna o ID do produto com o maior preço</returns>
                public static int MaiorPreco(){
                    return 0;
                }
                /// <summary>
                /// Procura o menor valor e armazena o seu id em uma variavel temporaria na qual será o retorno desse metodo.  
                /// Esse metodo usa o Maior preço como base.
                /// </summary>
                /// <returns>Retorna o ID do produto com o menor preço</returns>
                public static int MenorPreco(){
                    return 0;
                }
                /// <summary>
                /// Altera o preço do produto no id dado como parametro
                /// </summary>
                /// <param name="id">Parametro inserido pelo usuario , define qual produto tera o valor alterado</param>
                public static void AlterarPreco(int id){

                }
                #endregion Metodos
        #endregion Produto

        #region Usuario
            #region Variaveis
            /// <summary>
            /// Array que contem todos os usuarios cadastrados
            /// </summary>
            public static Usuario[] usuarios = new Usuario[1];
            /// <summary>
            /// Usuario logado atualmente
            /// </summary>
            public static Usuario usuarioLogado = null;
            #endregion Variaveis

            #region Metodos
            /// <summary>
            /// Insere um usuario no ultimo index do vetor.  
            /// Condições :  
            /// O Usuario deve conter um email com @ e .  
            /// A senha do usuario deve conter mais do que 6 caracteres
            /// </summary>
            /// <param name="id">Posição do usuario no vetor somada mas 1</param>
            public static void CadastrarUsuario(int id){
                usuarios[id].ID = id;//seta o id do cadastro igual ao inserido pelo usuario

                Design.MensagemInstrucao("Insira o seu nome");
                usuarios[id].Nome = Console.ReadLine();
                //  LOOP EMAIL
                Design.MensagemInstrucao("Insira um email (Ex: email@provedor.com)");
                do{
                    usuarios[id].Email = Console.ReadLine();
                } while(usuarios[id].Email != null);
                //  LOOP SENHA
                Design.MensagemInstrucao("Insira uma email");
                do{
                    usuarios[id].Senha = Console.ReadLine();
                } while(usuarios[id].Senha != null);
                //  Data de criação
                usuarios[id].SetData(DateTime.Now);

                Design.MensagemSucesso($"Usuario {usuarios[id].Nome} cadastrado com sucesso no id {id}");
            }
            /// <summary>
            /// Metodo no qual pede os dados e verifica se o mesmo está cadastrado no banco de dados.
            /// </summary>
            public static void EfetuarLogin(){
                Design.MensagemInstrucao("Insira o seu email");
                string email = Console.ReadLine();

                foreach (Usuario item in usuarios)
                {
                    if(item.Email == email){
                        Design.MensagemInstrucao("Insira a senha");
                        string senha = Console.ReadLine();

                        sbyte tentativas = 0;
                        // loop de tentativas
                        do{
                            Design.MensagemErro("Senha invalida . Insira novamente");
                            senha = Console.ReadLine();
                            if(senha!=item.Senha)tentativas++;
                        }while(senha!=item.Senha || tentativas >= 3);

                        // verificação de segurança , caso os erros ultrapassem o 3
                        if(tentativas > 3){
                            Design.MensagemErro("Maximo de tentativas atingido.");
                            break;
                        }else{
                            if(usuarioLogado!= null){
                                usuarioLogado = item;
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
            /// Desloga o usuario caso o mesmo esteja logado
            /// </summary>
            public static void Logoff(){
                Design.MensagemInstrucao("Deseja deslogar?");
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
            #endregion Metodos
        #endregion Usuario

        #region Ambos

            /// <summary>
            /// Percorre toda a array inseria pelo usuario e usa o metodo Design.Listar para mostrar resultados
            /// </summary>
            /// <param name="database"></param>
            /// <param name="valor">tipo do produto/usuario a ser mostrada</param>
            public static void ListarTodos(Entidade[] database,string valor = "entidade"){
                foreach (Entidade item in database)
                {
                    if(item != null){
                        Design.Listar(item.ID,database);
                    }
                    else{
                        Design.MensagemErro($"Não existe {valor} nesse ID");
                    }
                }                
            }
        #endregion

        #region Stream
        

        #endregion Stream
    }
}