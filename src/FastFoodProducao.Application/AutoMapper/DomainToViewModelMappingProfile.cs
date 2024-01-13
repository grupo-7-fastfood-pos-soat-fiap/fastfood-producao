using System.Data;
using AutoMapper;
//using FastFoodProducao.Application.InputModels;
//using FastFoodProducao.Application.ViewModels;
//using FastFoodProducao.Domain.Models;
//using FastFoodProducao.Domain.Models.PedidoAggregate;
//using FastFoodProducao.Domain.Models.ProdutoAggregate;

namespace FastFoodProducao.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            AllowNullCollections = true;            

            //CreateMap<CategoriaProduto, CategoriaProdutoViewModel>();

            //CreateMap<Cliente, ClienteViewModel>();

            //CreateMap<Imagem, ImagemViewModel>();

            //CreateMap<Produto, ProdutoViewModel>()
            //    .ForMember(c => c.Categoria,
            //        map => map.MapFrom(m => m.CategoriaNavegation));

            //CreateMap<Pagamento, PagamentoViewModel>()
            //    .ForMember(c => c.Situacao,
            //        map => map.MapFrom(m => m.SituacaoPagamentoNavegation));

            //CreateMap<Pedido, PedidoViewModel>()
            //    .ForMember(c => c.Cliente,
            //        map => map.MapFrom(m => m.ClienteNavegation))
            //    .ForMember(c => c.Pagamento,
            //        map => map.MapFrom(m => m.PagamentoNavegation));

            //CreateMap<PedidoCombo, PedidoComboViewModel>();
            
            //CreateMap<PedidoComboProduto, PedidoComboProdutoViewModel>()
            //    .ForMember( c => c.Produto,
            //        map => map.MapFrom(m => m.ProdutoNavigation));
            
            //CreateMap<Funcionario, FuncionarioViewModel>()
            //    .ForMember( c => c.Ocupacao,
            //        map => map.MapFrom(m => m.OcupacaoNavegation));
            
            //CreateMap<Ocupacao, OcupacaoViewModel>();            

            //CreateMap<SituacaoPedido, SituacaoPedidoViewModel>();

            //CreateMap<SituacaoPagamento, SituacaoPagamentoViewModel>();

            //CreateMap<Andamento, AndamentoViewModel>()
            //    .ForMember( c => c.Funcionario,
            //        map => map.MapFrom(m => m.FuncionarioNavegation))
            //    .ForMember(c => c.Situacao,
            //        map => map.MapFrom(m => m.SituacaoPedidoNavegation));


        }
    }
}
