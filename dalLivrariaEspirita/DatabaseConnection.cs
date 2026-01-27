using Microsoft.Data.Sqlite;

namespace dalLivrariaEspirita
{
    /// <summary>
    /// Classe selada de conexão com o banco de dados.
    /// O modificador sealed significa que ninguém pode herdar dessa classe.
    /// Isso é comum em Singletons, para evitar que alguém crie subclasses e quebre o padrão.
    /// </summary>
    public sealed class DatabaseConnection
    {
        /// <summary>
        /// Objeto estático que vai guardar a única instância da classe.
        /// </summary>
        private static DatabaseConnection? _instance = null;
        /// <summary>
        /// Objeto usado para lock (travamento de thread).
        /// Isso garante que, se várias threads tentarem acessar ao mesmo tempo, apenas uma cria a instância.
        /// Evita problemas de concorrência.
        /// </summary>
        private static readonly object _lock = new();
        /// <summary>
        /// String de conexão com o banco SQLite.
        /// O readonly significa que esse valor não pode ser alterado depois de inicializado.
        /// </summary>
        private readonly string _connectionString = "Data Source=DbLivraria.db";
        /// <summary>
        /// Construtor privado.
        /// Isso impede que alguém faça new DatabaseConnection() fora da classe.
        /// Somente o próprio Singleton pode criar a instância.
        /// </summary>
        private DatabaseConnection() { }
        /// <summary>
        /// Propriedade pública que expõe a instância única da classe.
        /// É por aqui que o resto do sistema acessa o Singleton.
        /// </summary>
        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new DatabaseConnection();
                    return _instance;
                }
            }
        }
        /// <summary>
        /// Método público que devolve uma nova conexão SQLite usando a string definida.
        /// </summary>
        /// <returns>Retorna uma conexão do SQLite.</returns>
        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }
    }
}