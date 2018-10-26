using System;
using System.Text;
using Senai.Exercicio.Pizzaria.Classes.Models;
using Senai.Exercicio.Pizzaria.Classes.Repositorio;

namespace Senai.Exercicio.Pizzaria.Classes.Utilidades {
    /// <summary>
    /// Classe onde contem todas as estilizações do programa
    /// </summary>
    public static class Design {
        
        /// <summary>
        /// Usado para Mostrar uma mensagem de erro
        /// Pula uma linha e mostra a mensagem
        /// </summary>
        /// <param name="mensagem">Mensagem que será exibida</param>
        public static void MensagemErro (string mensagem) {
            Console.WriteLine ($"\n{mensagem}");
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
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine ($" {new string('_',mensagem.Length)} \n({mensagem})\n {new string('‾',mensagem.Length)} ");
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
        /// Procura um usuario no banco de dados e mostra o ID , nome , email e data de criação.  
        /// </summary>
        /// <param name="id">Parametro inserido pelo usuario , define qual usuario será procurado</param>
        public static void ListarUsuario(int id){               
            Console.WriteLine($"\n[{id}] \t\t--> {Database.usuarios[id-1].Nome}\nEmail \t\t--> {Database.usuarios[id-1].Email}\nData De Criação \t--> {Database.usuarios[id-1].DataCriacao}");         
        }

        /// <summary>
        /// Pode ser usado sem depender do metodo Database.ListarTodos
        /// Procura um produto no banco de dados e mostra o ID e o nome.  
        /// </summary>
        /// <param name="id">Parametro inserido pelo usuario , define qual usuario será procurado</param>
        public static void ListarProduto(int id){               
            Console.WriteLine($"\n[{id}] \t\t--> {Database.produto[id-1].Nome}\nTipo \t\t--> {Database.produto[id-1].Categoria}\nData de criação \t--> {Database.produto[id-1].DataCriacao}\nPreço \t\t --> R{Database.produto[id-1].Preco.ToString("C2")}\nDescrição :\n{Database.produto[id-1].Descricao}\n");         
        }
    }
}