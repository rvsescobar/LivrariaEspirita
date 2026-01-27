using Microsoft.Data.Sqlite;

namespace dalLivrariaEspirita
{
    /// <summary>
    /// Classe de inicialização do banco.
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// Método privado e estático para criação e conexão com o banco e dados.
        /// </summary>
        private static void CreateDb()
        {
            using var conn = new SqliteConnection("Data Source=DbLivraria.db");
            conn.Open();
        }
        /// <summary>
        /// Método público e estático que inicializa o banco.
        /// Ele será chamado uma vez, geralmente no início da aplicação.
        /// Responsável por garantir que o banco de dados e as tabelas existam.
        /// </summary>
        public static void Initialize()
        {
            CreateDb();
        }
    }
}