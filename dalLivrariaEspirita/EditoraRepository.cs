using dtoLivrariaEspirita;

namespace dalLivrariaEspirita
{
    /// <summary>
    /// Repositório responsável por realizar operações de acesso a dados
    /// relacionadas à entidade Editora.
    /// Implementa operações básicas de CRUD utilizando conexão direta ao banco.
    /// </summary>
    public class EditoraRepository : IRepository<EditoraDto>
    {
        /// <summary>
        /// Busca uma editora pelo seu identificador.
        /// </summary>
        /// <param name="id">Identificador único da editora.</param>
        /// <returns>
        /// Um objeto EditoraDto caso o registro seja encontrado;
        /// caso contrário, retorna null.
        /// </returns>
        public EditoraDto GetById(int id)
        {
            using var conn = DatabaseConnection.Instance.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Editoras WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new EditoraDto
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1)
                };
            }
            return null;
        }
        /// <summary>
        /// Retorna a lista completa de editoras cadastradas.
        /// </summary>
        /// <returns>
        /// Uma lista contendo todos os registros da tabela Editoras.
        /// </returns>
        public List<EditoraDto> ListAll()
        {
            var list = new List<EditoraDto>();
            using var conn = DatabaseConnection.Instance.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Editoras";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EditoraDto
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1)
                });
            }
            return list;
        }
        /// <summary>
        /// Busca editoras cujo nome contenha o texto informado.
        /// </summary>
        /// <param name="nomeEditora">Parte ou nome completo da editora a ser pesquisada.</param>
        /// <param name="nomeParcial">Define o tipo da busca: parcial ou exata.</param>
        /// <returns>
        /// Uma lista de editoras cujo nome contenha o texto informado.
        /// Retorna uma lista vazia caso nenhuma correspondência seja encontrada.
        /// </returns>
        public List<EditoraDto> SearchByName(string nomeEditora, bool nomeParcial = true)
        {
            var list = new List<EditoraDto>();
            using var conn = DatabaseConnection.Instance.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            if (nomeParcial)
            {
                cmd.CommandText = "SELECT * FROM Editoras WHERE Nome LIKE @Nome";
                cmd.Parameters.AddWithValue("@Nome", "%" + nomeEditora + "%");
            }
            else
            {
                cmd.CommandText = "SELECT * FROM Editoras WHERE Nome = @Nome";
                cmd.Parameters.AddWithValue("@Nome", nomeEditora);
            }

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EditoraDto
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1)
                });
            }

            return list;
        }
        /// <summary>
        /// Insere uma nova editora no banco de dados.
        /// </summary>
        /// <param name="editoraDto">Objeto contendo os dados da editora a ser inserida.</param>
        public void Insert(EditoraDto editoraDto)
        {
            using var conn = DatabaseConnection.Instance.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Editoras (Nome) VALUES (@Nome)";
            cmd.Parameters.AddWithValue("@Nome", editoraDto.Nome);
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Atualiza os dados de uma editora existente.
        /// </summary>
        /// <param name="editoraDto">Objeto contendo oI.D.da editora e os novos dados.</param>
        public void Update(EditoraDto editoraDto)
        {
            using var conn = DatabaseConnection.Instance.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Editoras SET Nome=@Nome WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Nome", editoraDto.Nome);
            cmd.Parameters.AddWithValue("@Id", editoraDto.Id);
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Remove uma editora do banco de dados com base no seu identificador.
        /// </summary>
        /// <param name="id">Identificador da editora a ser excluída.</param>
        public void Delete(int id)
        {
            using var conn = DatabaseConnection.Instance.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Editoras WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }

}