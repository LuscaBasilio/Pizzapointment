using System;
using Senai.Exercicio.Pizzaria.Classes;
using Senai.Exercicio.Pizzaria.Classes.Repositorio;
using Senai.Exercicio.Pizzaria.Classes.Utilidades;

namespace Senai.Exercicio.Pizzaria.Classes.Utilidades
{
    /// <summary>
    /// Classe onde tem toda interface do programa
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Menu que será mostrado caso o usuario não esteja logado.  
        /// Contem as opções :   
        /// [1] Cadastrar Usuario   -> Database.CadastrarUsuario  
        /// [2] Efetuar Login       -> Database.EfetuarLogin  
        /// [3] Listar Usuario      -> Database.ListarTodos   
        /// [9] Sair  
        /// Qualquer outro é invalido
        /// </summary>
        /// <returns>Retrna true se o usuario selecionar a opção 9 (Sair)</returns>
        public static bool Deslogado(){
            Design.Titulo("PIZZAPOINTMENT");
            Console.WriteLine("");

            sbyte escolha = 0 ;
            bool sair = false;
            // se o usuario não estiver logado 
            do{              
                Design.MensagemInstrucao("O que deseja fazer?");
                Console.WriteLine("[1] Cadastrar usuario\n[2] Efetuar login\n[3] Listar Usuarios\n[9] Sair\n");        
                sbyte.TryParse(Console.ReadLine(),out escolha);
                switch(escolha){
                    case 1://   Cadastrar Usuario   //
                        int tamanho = Database.usuarios.Length-1;
                        System.Console.WriteLine("1");
                        Database.CadastrarUsuario(tamanho);
                        Array.Resize(ref Database.usuarios,tamanho+1);
                        break;
                    case 2://   Efetuar Login   //
                        Database.EfetuarLogin();
                        sair = false;
                    break;
                    case 3://   Listar usuario  //
                        Database.ListarTodos(Database.usuarios,"usuario");                           
                        break;
                    case 9://   Fechar      //
                        Design.MensagemInstrucao("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        sair = true;
                        continue;
                    default://  Exceção     //
                        Design.MensagemErro("Por favor insira um dos 4 valores");
                        break;
                        
                }
            }while(escolha != 9 && Database.usuarioLogado == null) ;
            return sair;
        }
        /// <summary>
        /// Menu para usuario logado.  
        /// Contem as opções:  
        /// [1] Cadastrar produto       ->  Database.CadastrarProduto  
        /// [2] Listar Produto(s)       ->  Menu.ListarProduto  
        /// [3] Exibir Total de custos  ->  Database.ExibirTotal  
        /// [4] Ver Maior Preço         ->  Database.MaiorPreco  
        /// [4] Ver Menor Preço         ->  Database.MenorPreco  
        /// [5] Alterar Preço           ->  Database.AlterarPreco  
        /// [9] Fazer Logoff            ->  Database.Logoff  
        /// Qualquer outro é invalido
        /// </summary>
        public static void Logado(){
            sbyte escolha;
            sbyte.TryParse(Console.ReadLine(),out escolha);
            Console.WriteLine("O que deseja fazer agora?");   
            Console.WriteLine("[1] Cadastrar produto\n[2] Listar produto\n[3] Exibir total\n[4] Maior preço\n[5] Menor preço\n[6] Alterar preço\n[9] Fazer Logoff");
            switch(escolha){
                case 1://   Cadastrar Produto//
                    // cria uma variavel com o tamanho do database dos produtos menos 1.
                    int tamanhoProduto = Database.produto.Length-1;
                    // chama um metodo (cadastrar produto)
                    Database.CadastrarProduto(tamanhoProduto);
                    // aumenta a array usando a variavel de tamanho mais um
                    Array.Resize(ref Database.produto,tamanhoProduto+1);
                    break;
                case 2://   Listar Produto(s)//
                    ListarProdutos();    
                    break;
                case 3://   Exibir Total    //
                    Database.ExibirTotal();
                    break;
                case 4://   Maior Preço     //
                    Database.MaiorPreco();
                    break;
                case 5://   Menor Preço     //
                    Database.MenorPreco();
                    break;
                case 6://   Alterar Preço   //
                    int id;
                    Design.MensagemInstrucao("Insira o ID do produto que você deseja alterar o valor");
                    int.TryParse(Console.ReadLine(),out id);
                    Database.AlterarPreco(id);
                    break;
                case 9://   Logoff          //
                    Database.Logoff();
                    escolha = 0 ;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// [Redirecionado e usado apenas pelo metodo Menu.Logado]
        /// Menu de listar produto onde o usuario poderá :  
        /// [1] Ver informações de todos os produtos    ->  Database.ListarTodos  
        /// [2] Ver informações um produto especifico   ->  Database.Listar    
        /// [3] Sair  
        /// Qualquer outro é invalido
        /// </summary>
        private static void ListarProdutos(){
            sbyte esx = 0;
            do{//escolher opções
                Design.MensagemInstrucao("O que você deseja fazer agora?");
                Console.WriteLine("[1] Listar todos os produtos\n[2] Listar um produto especifico\n[3] Sair");
                sbyte.TryParse(Console.ReadLine(),out esx);
                switch (esx){
                    case 1://   Todos os produtos       //                                        
                        Database.ListarTodos(Database.produto,"produto");
                        break;
                    case 2://   Um produto especifico   //
                        ListarProduto();
                        break;
                    case 3://           Sair            //
                        continue;
                    default:
                        Design.MensagemErro("Por favor insira um dos 3 valores");
                        break;
                    }
                }while(esx!=3);
        }
        /// <summary>
        /// [Redirecionado e usado apenas pelo metodo Menu.ListarProdutos]  
        /// Menu com 2 opções :   
        /// [0] Sair  
        /// [Qualquer outro valor maior que 0] Mostra informações sobre o produto(Design.Listar)
        /// </summary>
        private static void ListarProduto(){
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
        } 

    }
}