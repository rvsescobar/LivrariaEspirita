using Microsoft.Data.Sqlite;

namespace dalLivrariaEspirita
{
    /// <summary>
    /// Classe de inicialização do banco.
    /// </summary>
    public static class DatabaseInitializer
    {

        /// <summary>
        /// String de conexão com o banco SQLite.
        /// O readonly significa que esse valor não pode ser alterado depois de inicializado.
        /// </summary>
        private static readonly string _connectionString = "Data Source=DbLivraria.db";
        /// <summary>
        /// Método privado e estático para criação e conexão com o banco e dados.
        /// </summary>
        private static void CreateDb()
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
        }
        /// <summary>
        /// Método genérico para criação de tabela.
        /// </summary>
        /// <param name="sqlCreateTable">SQL específico da criação da tabela.</param>
        private static void CreateTable(string sqlCreateTable)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = sqlCreateTable;
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Método para criação da tabela Editoras.
        /// </summary>
        private static void CreateTableEditoras()
        {
            CreateTable(@"CREATE TABLE IF NOT EXISTS Editoras (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome TEXT NOT NULL);");
        }
        /// <summary>
        /// Método público e estático que inicializa o banco.
        /// Ele será chamado uma vez, geralmente no início da aplicação.
        /// Responsável por garantir que o banco de dados e as tabelas existam.
        /// </summary>
        public static void Initialize()
        {
            CreateDb();
            CreateTableEditoras();
        }
    }
}