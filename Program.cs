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
                        case 1:
                            int tamanho = Database.usuarios.Length-1;
                            Database.CadastrarUsuario(tamanho);
                            Array.Resize(ref Database.usuarios,tamanho+1);
                            break;
                        case 2:
                            Database.EfetuarLogin();
                        break;
                        case 3:
                            /* 
                            Um loop (foreach provavelmente)
                            onde provavelmente pega todos os usuarios e mostra o seu id e nome 
                            Caso o objeto (usuario) seja nulo , ele não faz nada mas continua o loop até o final 
                            */
                            break;
                        case 9:
                            Design.MensagemInstrucao("Aperte qualquer tecla para sair");
                            Console.ReadKey();
                            continue;
                        default:
                            Design.MensagemErro("Por favor insira um dos 4 valores");
                            break;
                    }
                }else{
                    Console.WriteLine("O que deseja fazer agora?");   
                    Console.WriteLine("[1] Cadastrar produto\n[2] Listar produto\n[3] Exibir total\n[4] Maior preço\n[5] Menor preço\n[6] Alterar preço\n[9] Fazer Logoff");
                    switch(escolha){
                        case 1:
                            // cria uma variavel com o tamanho do database dos produtos menos 1.
                            int tamanhoProduto = Database.produto.Length-1;
                            // chama um metodo (cadastrar produto)
                            Database.CadastrarProduto(tamanhoProduto);
                            // aumenta a array usando a variavel de tamanho mais um
                            Array.Resize(ref Database.produto,tamanhoProduto+1); 
                            break;
                        case 2://   Listar Produto(s)//
                            /*
                            ---Ele poderar escolher entre as seguintes opções---
                            1 - Todos
                            2 - Um unico produto (depois será pedido a ID (usando o getID) do mesmo) <- ficará no loop até inserir o valor 0
                            3 - Sair

                            ---Exceções---
                                - Inserir um valor menor do que 0 ou maior que 3
                             */
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
                            break;
                    }
                }

            }while(escolha !=9 && Database.usuarioLogado == null);
            
            
        }

    }
}
