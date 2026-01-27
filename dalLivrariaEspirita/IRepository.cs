namespace dalLivrariaEspirita
{
    /// <summary>
    /// Interface genérica.
    /// </summary>
    /// <typeparam name="T">Objeto genérico: será usado para os objetos DTO (Exemplo: Editoras, Livros, Clientes e Vendas).</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Método para buscar um único objeto do banco pelo seu id.
        /// </summary>
        /// <param name="id">Id do objeto.</param>
        /// <returns>Retorna um objeto do tipo T (Exemplo: Editoras, Livros, Clientes e Vendas).</returns>
        T GetById(int id);
        /// <summary>
        /// Método para listar todos os registros do banco.
        /// </summary>
        /// <returns>Retorna uma lista (List<T>) de objetos do tipo T (Exemplo: Editoras, Livros, Clientes e Vendas).</returns>
        List<T> ListAll();
        /// <summary>
        /// Método para inserir um objeto do tipo T no banco.
        /// </summary>
        /// <param name="entity">Objeto DTO (Exemplo: Editoras, Livros, Clientes e Vendas).</param>
        void Insert(T entity);
        /// <summary>
        /// Método para atualizar um objeto do tipo T no banco.
        /// </summary>
        /// <param name="entity">Objeto DTO (Exemplo: Editoras, Livros, Clientes e Vendas).</param>
        void Update(T entity);
        /// <summary>
        /// Método para excluir um registro do banco, identificado pelo seu id.
        /// </summary>
        /// <param name="id">Id do objeto.</param>
        void Delete(int id);
    }
}