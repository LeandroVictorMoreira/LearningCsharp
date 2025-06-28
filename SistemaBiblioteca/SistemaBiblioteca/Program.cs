using MySql.Data.MySqlClient;
using SistemaBiblioteca;


var conexaoDB = new ConexaoDb();
using(MySqlConnection conexao = ConexaoDb.ConectarBanco()) {

    string sql = "SELECT * FROM livros";
}

Console.Write("Digite o nome do livro: ");
string nome = Console.ReadLine();
Console.Write("Digite o autor do livro: ");
string autor = Console.ReadLine();
Console.Write("Digite o número de paginas: ");
int numeropaginas = int.Parse(Console.ReadLine());

Livros livro = new Livros();
    livro.adicionar_livros(nome,autor,numeropaginas,conexaoDB);