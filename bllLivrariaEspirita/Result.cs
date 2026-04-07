namespace bllLivrariaEspirita
{
    /// <summary>
    /// Representa o resultado de uma operação, permitindo retornar:
    /// - Sucesso ou falha
    /// - Lista de erros (quando houver)
    /// - Dados resultantes da operação (quando aplicável)
    /// </summary>
    /// <typeparam name="T">
    /// Tipo do dado retornado em caso de sucesso.
    /// Pode ser qualquer tipo, incluindo classes, structs ou tipos primitivos.
    /// </typeparam>
    public class Result<T>
    {
        /// <summary>
        /// Indica se a operação foi concluída com sucesso.
        /// True = operação bem-sucedida.
        /// False = operação falhou.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// Lista de mensagens de erro associadas à operação.
        /// Sempre inicializada, mesmo quando vazia.
        /// </summary>
        public List<string> Errors { get; private set; } = new();

        /// <summary>
        /// Dados retornados pela operação em caso de sucesso.
        /// Será nulo quando a operação falhar.
        /// </summary>
        public T? Data { get; private set; }

        /// <summary>
        /// Construtor privado para garantir que a criação de instâncias
        /// seja feita exclusivamente pelos métodos estáticos Ok e Fail.
        /// </summary>
        private Result() { }

        /// <summary>
        /// Cria um resultado de sucesso contendo os dados fornecidos.
        /// </summary>
        /// <param name="data">Objeto do tipo T retornado pela operação.</param>
        /// <returns>Instância de Result&lt;T&gt; representando sucesso.</returns>
        public static Result<T> Ok(T data)
            => new Result<T> { Success = true, Data = data };

        /// <summary>
        /// Cria um resultado de falha contendo a lista de erros informada.
        /// </summary>
        /// <param name="errors">Lista de mensagens de erro da operação.</param>
        /// <returns>Instância de Result&lt;T&gt; representando falha.</returns>
        public static Result<T> Fail(List<string> errors)
            => new Result<T> { Success = false, Errors = errors };
    }
}