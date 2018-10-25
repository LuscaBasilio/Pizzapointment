using System;
using System.Text;
using Senai.Exercicio.Pizzaria.Classes.Models;

namespace Senai.Exercicio.Pizzaria.Classes.Utilidades {
    /// <summary>
    /// Classe onde contem todas as estilizações do programa
    /// </summary>
    public static class Design {
        /// <summary>
        /// Usado para Mostrar uma mensagem de erro
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida</param>
        public static void MensagemErro (string mensagem) {
            Console.WriteLine ($"{mensagem}");
        }
        /// <summary>
        /// Usado para mostrar uma mensagem de instrução. 
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida entre os *-- --*</param>
        public static void MensagemInstrucao(string mensagem) {
            Console.WriteLine ($">-- { mensagem } -->");
        }
        /// <summary>
        /// Usado para mostar uma mensagem de sucesso
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida</param>
        public static void MensagemSucesso(string mensagem) {
            Console.WriteLine ($"{mensagem}");
        }
        /// <summary>
        /// Mostra uma mensagem que será exibida entre --- e entre 2 linhas de ---  
        /// Exemplo :
        /// ---------------
        /// ---- Texto ----
        /// ---------------
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida</param>
        public static void Titulo(string mensagem){
            int size = mensagem.Length+10;
            Console.WriteLine ($"{new string('-',size)}\n---- {mensagem} ----\n{new string('-',size)}");
        }
        /// <summary>
        /// Pode ser usado sem depender do metodo Database.ListarTodos
        /// Procura um produto/usuario no banco de dados fornecido e mostra o ID e o nome.  
        /// Caso seja um produto ele mostra sua descrição , caso seja um usuario ,seu email.
        /// </summary>
        /// <param name="id">Parametro inserido pelo usuario , define qual produto/usuario será procurado</param>
        /// <param name="database">database onde será procurado a produto/usuario</param>
        public static void Listar(int id,Entidade[] database){               
            Console.WriteLine($"--> [{id}] : {database[id-1].Nome}");         
        }
    }
}