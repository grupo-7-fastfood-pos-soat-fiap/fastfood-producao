namespace FastFoodProducao.Application.ViewModels
{
    public class AndamentoViewModel
    {
        public Guid Id { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime? DataHoraFim { get; set; }
        public Guid FuncionarioId { get; set; }
        public SituacaoPedidoViewModel? Situacao { get; set; }
        public bool Atual { get; set; }

        public AndamentoViewModel() { 
        }

        public AndamentoViewModel(Guid id, DateTime dataHoraInicio, DateTime? dataHoraFim, Guid funcionarioId, SituacaoPedidoViewModel? situacao, bool atual)
        {
            Id = id;
            DataHoraInicio = dataHoraInicio;
            DataHoraFim = dataHoraFim;
            FuncionarioId = funcionarioId;
            Situacao = situacao;
            Atual = atual;
        }

    }
}
