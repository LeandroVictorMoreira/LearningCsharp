using MySql.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SistemaBiblioteca {
    internal class ConexaoDb {

        private const string StringConection = "server=localhost;user=root;password=0909;database=biblioteca_system";

        public static MySqlConnection ConectarBanco() {
            var conexao = new MySqlConnection(StringConection);
            conexao.Open();
            Console.WriteLine("Conectado!");
            return conexao;

        }
        public void AdicionarLivroDb(string nome_livro,string nome_autor,int numero_paginas) {

            using MySqlConnection StringConection = ConexaoDb.ConectarBanco();
            {
                string sql = "INSERT INTO livros(nome_livro , nome_autor , numero_paginas) VALUES (@nome_livro , @nome_autor , @numero_paginas)";
                MySqlCommand cmd = new MySqlCommand(sql,StringConection);

                cmd.Parameters.AddWithValue("@nome_livro",nome_livro);
                cmd.Parameters.AddWithValue("@nome_autor",nome_autor);
                cmd.Parameters.AddWithValue("@numero_paginas",numero_paginas);

                cmd.ExecuteNonQuery();

            }
        }
    }
}
