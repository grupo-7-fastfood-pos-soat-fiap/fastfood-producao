using FastFoodProducao.Domain.Commands.AndamentoCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodProducao.Domain.Test.Commands.AndamentoCommands
{
    public class AndamentoUpdateCommandTests
    {
        [Fact]
        public void Constructor_ValidParameters_ShouldCreateInstance()
        {
            // Arrange
            Guid expectedPedidoId = Guid.NewGuid();
            Guid expectedFuncionarioId = Guid.NewGuid();
            int expectedSituacaoId = 1;
            DateTime expectedDataHoraInicio = DateTime.Now;
            DateTime? expectedDataHoraFim = null;
            bool expectedAtual = true;

            // Act
            AndamentoUpdateCommand command = new AndamentoUpdateCommand(expectedPedidoId, expectedFuncionarioId, expectedSituacaoId, expectedDataHoraInicio, expectedDataHoraFim,expectedAtual);

            // Assert
            Assert.NotNull(command);
            Assert.Equal(expectedPedidoId, command.PedidoId);
            Assert.Equal(expectedFuncionarioId, command.FuncionarioId);
            Assert.Equal(expectedSituacaoId, command.SituacaoId);
            Assert.Equal(expectedDataHoraInicio, command.DataHoraInicio);
            Assert.Equal(expectedDataHoraFim, command.DataHoraFim);
            Assert.Equal(expectedAtual, command.Atual);
        }
    }
}
