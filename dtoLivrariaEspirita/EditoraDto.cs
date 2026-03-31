namespace dtoLivrariaEspirita
{
    /// <summary>
    /// Representa os dados básicos de uma editora utilizados para transferência 
    /// entre camadas da aplicação.
    /// </summary>
    public class EditoraDto
    {
        /// <summary>
        /// I.D. da Editora.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome da Editora.
        /// </summary>
        public string Nome { get; set; }
    }
}