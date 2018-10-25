using System;
using Senai.Exercicio.Pizzaria.Classes.Repositorio;
using Senai.Exercicio.Pizzaria.Classes.Utilidades;

namespace Senai.Exercicio.Pizzaria
{
    class Program
    {
        static void Main(string[] args){ 
            
            Database.usuarios = Database.CarregarUsuarios();

            bool sair = false;
            
            do{                  
                if(Database.usuarioLogado == null){  
                    sair = Menu.Deslogado();  
                }else{
                    Menu.Logado();
                }

            }while(sair == false);

            Database.usuarioDB.Close();           
        }

    }
}
