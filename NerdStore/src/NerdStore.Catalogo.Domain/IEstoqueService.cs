using System;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public interface IEstoqueService
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);

        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
    }
}
