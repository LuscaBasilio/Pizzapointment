using System;
using System.Text;
namespace Senai.Exercicio.Pizzaria.Classes {
    public static class Design {
        /// <summary>
        /// Usado para Mostrar uma mensagem de erro
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida</param>
        public static void MensagemErro (string mensagem) {
            Console.WriteLine ($"{mensagem}");
        }
        /// <summary>
        /// Usado para mostrar uma mensagem de instrução entre 3 traços.  
        /// Exemplo :  
        /// \*-- Texto --*
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida entre os *-- --*</param>
        public static void MensagemInstrucao(string mensagem) {
            Console.WriteLine ($"*-- { mensagem } --*");
        }
        /// <summary>
        /// Usado para mostar uma mensagem de sucesso
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida</param>
        public static void MensagemSucesso(string mensagem) {
            Console.WriteLine ($"{mensagem}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida</param>
        public static void Titulo(string mensagem){
            Console.WriteLine ($"{mensagem}");
        }
        /// <summary>
        /// Pode ser usado sem depender do metodo Database.ListarTodos
        /// Procura um produto/usuario no banco de dados fornecido e mostra o ID e o nome.  
        /// se ele não existir , mostra que não há produto/usuario no ID inserido.
        /// </summary>
        /// <param name="id">Parametro inserido pelo usuario , define qual produto/usuario será procurado</param>
        /// <param name="database">database onde será procurado a produto/usuario</param>
        public static void Listar(int id,Entidade[] database){               
            Console.WriteLine($"--> [{id}] : {database[id-1].Nome}");
        }
    }
}