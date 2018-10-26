using System;
using Senai.Exercicio.Pizzaria.Classes.Repositorio;
using Senai.Exercicio.Pizzaria.Classes.Models;

namespace Senai.Exercicio.Pizzaria
{
    class Program
    {
        static void Main(string[] args){ 
            
            Database.usuarios = Database.CarregarUsuarios();
            Database.produto = Database.CarregarProdutos();

            bool sair = false;
            
            do{                  
                if(Database.usuarioLogado == null){  
                    sair = Menu.Deslogado();  
                }else{
                    Menu.Logado();
                }

            }while(sair == false);

           Database.RegistrarUsuarios();
           Database.RegistrarProdutos();
                      
        }

    }
}
