using System;
using Senai.Exercicio.Pizzaria.Classes;

namespace Senai.Exercicio.Pizzaria
{
    class Program
    {
        static void Main(string[] args){           
            Design.Titulo("PIZZAPOINTMENT");
            Console.WriteLine("");
            sbyte escolha = 0 ;
            do{                  
                // se o usuario não estiver logado
                if(Database.usuarioLogado == null){
                    
                    Design.MensagemInstrucao("O que deseja fazer?");
                    Console.WriteLine("[1] Cadastrar usuario\n[2] Efetuar login\n[3] Listar Usuarios\n[9] Sair\n");        
                    sbyte.TryParse(Console.ReadLine(),out escolha);
                    switch(escolha){
                        case 1://   Cadastrar Usuario   //
                            int tamanho = Database.usuarios.Length-1;
                            Database.CadastrarUsuario(tamanho);
                            Array.Resize(ref Database.usuarios,tamanho+1);
                            break;
                        case 2://   Efetuar Login   //
                            Database.EfetuarLogin();
                        break;
                        case 3://   Listar usuario  //
                            Database.ListarTodos(Database.usuarios,"usuario");                           
                            break;
                        case 9://   Fechar      //
                            Design.MensagemInstrucao("Aperte qualquer tecla para sair");
                            Console.ReadKey();
                            continue;
                        default://  Exceção     //
                            Design.MensagemErro("Por favor insira um dos 4 valores");
                            break;
                            
                    }
                }else{
                    Console.WriteLine("O que deseja fazer agora?");   
                    Console.WriteLine("[1] Cadastrar produto\n[2] Listar produto\n[3] Exibir total\n[4] Maior preço\n[5] Menor preço\n[6] Alterar preço\n[9] Fazer Logoff");
                    switch(escolha){
                        case 1://   Cadastrar Produto//
                            // cria uma variavel com o tamanho do database dos produtos menos 1.
                            // chama um metodo (cadastrar produto)
                            // aumenta a array usando a variavel de tamanho mais um 
                            break;
                        case 2://   Listar Produto(s)//
                            sbyte esx;
                            do{//escolher opções
                                Design.MensagemInstrucao("O que você deseja fazer agora?");
                                Console.WriteLine("[1] Listar todos os produtos\n[2] Listar um produto especifico\n[3] Sair");
                                sbyte.TryParse(Console.ReadLine(),out esx);

                                switch (esx)
                                {
                                    case 1://   Todos os produtos       //                                        
                                        Database.ListarTodos(Database.produto,"produto");
                                        break;
                                    case 2://   Um produto especifico   //
                                        int esc;
                                        do{
                                            Design.MensagemInstrucao("Digite o ID do produto , Ou digite 0 para sair");
                                            int.TryParse(Console.ReadLine(),out esc);
                                            
                                            switch (esc){
                                                case 0:
                                                    //nada
                                                    continue;                                               
                                                default:
                                                    if(esc>0){
                                                        if(esc>=Database.produto.Length){
                                                            Design.Listar(esc,Database.produto);
                                                        }else{
                                                            Design.MensagemErro("Não insira valores fora do banco de dados");
                                                        }
                                                    }else{
                                                        Design.MensagemErro("Não insira valores negativos");
                                                    }
                                                    break;
                                            }
                                        }while(esc!=0);
                                        break;
                                    case 3://           Sair            //
                                        //nada
                                        continue;
                                    default:
                                        Design.MensagemErro("Por favor insira um dos 3 valores");
                                        break;
                                }

                            }while(esx!=3);
                            break;
                        case 3://   Exibir Total    //
                            //chama um metodo (ExibirTotal)
                            break;
                        case 4://   Maior Preço     //
                            // chama um metodo (MaiorPeco)
                            break;
                        case 5://   Menor Preço     //
                            // chama um metodo (MenorPeco)
                            break;
                        case 6://   Alterar Preço   //
                            //recebe um id do usuario
                            //verifica se ele existe
                            // se o id existir chama um metodo (AlterarMetodo) usando o id
                            // se o id não existir pede para que o usuario crie o produto (metodo CadastrarProduto)
                            break;
                        case 9://   Logoff          //
                            Database.Logoff();
                            escolha = 0 ;
                            continue;
                        default:
                            break;
                    }
                }

            }while(escolha !=9 && Database.usuarioLogado == null);
            
            
        }

    }
}
