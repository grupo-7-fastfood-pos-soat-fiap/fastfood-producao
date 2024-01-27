﻿using GenericPack.Domain;

namespace FastFoodProducao.Domain.Models
{
    public class Andamento : Entity
    {
        public Guid PedidoId { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime? DataHoraFim { get; private set; }
        public Guid? FuncionarioId { get; private set; }
        public int SituacaoId { get; private set; }
        public bool Atual { get; set; }

        private Andamento()
        {

        }

        public Andamento(Guid id, Guid pedidoId, Guid? funcionarioId, int situacaoId, DateTime dataHoraInicio, DateTime? dataHoraFim = null, bool atual = false)
        {
            Id = id;
            PedidoId = pedidoId;
            DataHoraInicio = dataHoraInicio;
            DataHoraFim = dataHoraFim;
            FuncionarioId = funcionarioId;
            SituacaoId = situacaoId;
            Atual = atual;
        }
    }
}
