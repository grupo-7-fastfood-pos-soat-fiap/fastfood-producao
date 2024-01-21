using AutoMapper;
using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.Interfaces;
using FastFoodProducao.Application.ViewModels;
using FastFoodProducao.Domain.Interfaces;
using FluentValidation.Results;
using GenericPack.Mediator;

namespace FastFoodProducao.Application.Services
{
    public class SituacaoPedidoApp : ISituacaoPedidoApp
    {
        private readonly ISituacaoPedidoRepository _situacaoRepository;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;

        public SituacaoPedidoApp(ISituacaoPedidoRepository situacaoRepository, IMediatorHandler mediator, IMapper mapper)
        {
            _situacaoRepository = situacaoRepository;
            _mediator = mediator;
            _mapper = mapper;
        }        

        public async Task<List<SituacaoPedidoViewModel>> GetAll()
        {
            return _mapper.Map<List<SituacaoPedidoViewModel>>(await _situacaoRepository.GetAll());
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}