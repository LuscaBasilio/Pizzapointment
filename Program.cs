using System;
using Senai.Exercicio.Pizzaria.Classes;

namespace Senai.Exercicio.Pizzaria
{
    class Program
    {
        static void Main(string[] args){           
            Console.WriteLine("PIZZAPOINTMENT");
            Console.WriteLine("");
            sbyte escolha = 0 ;
            do{
                Console.WriteLine("O que deseja fazer?\n[1] Cadastrar usuario\n[2] Efetuar login\n[3] Listar Usuarios\n[9] Sair");              
                sbyte.TryParse(Console.ReadLine(),out escolha);

                switch(escolha){
                    case 1:
                        Cadastro();
                        break;
                    case 2:
                        Database.EfetuaLogin();
                    break;

                    case 3:
                        ListarUsuarios();
                        break;

                    case 9:
                        Design.Instrucao("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        continue;

                    default:
                    break;
                }
            }while(escolha !=9);
            
            
        }
        /// <summary>
        /// Tela de cadastro de usuario
        /// </summary>
        static void Cadastro(){
            int tamanho = Database.usuarios.Length-1;
            Database.CadastrarUsuario(tamanho);
            Array.Resize(ref Database.usuarios,tamanho+1);
        }
        /// <summary>
        /// Lista todos os usuarios existentes no banco de dados
        /// </summary>
        static void ListarUsuarios(){

        }
    }
}
