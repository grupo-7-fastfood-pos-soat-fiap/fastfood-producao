using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.ViewModels;
using FluentValidation.Results;

namespace FastFoodProducao.Application.Interfaces
{
    public interface ISituacaoPedidoApp : IDisposable
    {
        Task<List<SituacaoPedidoViewModel>> GetAll();
    }
}