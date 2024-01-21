
using FastFoodProducao.Domain.Models;
using GenericPack.Data;

namespace FastFoodProducao.Domain.Interfaces
{
    public interface ISituacaoPedidoRepository : IRepository<SituacaoPedido>
    {
        Task<IEnumerable<SituacaoPedido>> GetAll();
    }
}