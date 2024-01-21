using System.Data;
using AutoMapper;
using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.ViewModels;
using FastFoodProducao.Domain.Models;

namespace FastFoodProducao.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            AllowNullCollections = true;            

            CreateMap<SituacaoPedido, SituacaoPedidoViewModel>();

            CreateMap<Andamento, AndamentoViewModel>()
               .ForMember(c => c.Situacao,
                   map => map.MapFrom(m => m.SituacaoPedidoNavegation));


        }
    }
}
