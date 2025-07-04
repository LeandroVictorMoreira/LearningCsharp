﻿using MySql.Data.MySqlClient;
using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace SistemaBiblioteca
{
    internal class Livros
    {

        public string Nome { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public static int TotalLivros { get; private set; } = 0;
        public static int Livros_Emprestados { get; private set; } = 0;

        public void adicionar_livros(string nome_livro, string nome_autor , int numero_paginas,ConexaoDb conexaoDb)
        {
            conexaoDb.AdicionarLivroDb(nome_livro,nome_autor,numero_paginas);

            TotalLivros++; 
            Console.WriteLine($"O livro {nome_livro} do autor {nome_autor} contendo {numero_paginas} páginas foi adicinado com sucesso!");
            Console.WriteLine($"Agora temos em nossa biblioteca {TotalLivros} livro(s)!");
        }
        public void remover_livros(string nome_livro) {
            TotalLivros--;
            Console.WriteLine($"O Livro {nome_livro} foi removido com sucesso!");
        }
        public void emprestimo() {
            Livros_Emprestados ++;

        }

    }
}
