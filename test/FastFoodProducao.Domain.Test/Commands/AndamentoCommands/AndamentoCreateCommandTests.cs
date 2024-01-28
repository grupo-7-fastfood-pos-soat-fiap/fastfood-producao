

using FastFoodProducao.Domain.Commands.AndamentoCommands;

namespace FastFoodProducao.Domain.Test.Commands.AndamentoCommands
{
    public class AndamentoCreateCommandTests
    {
        [Fact]
        public void Constructor_ValidParameters_ShouldCreateInstance()
        {
            // Arrange
            Guid expectedPedidoId = Guid.NewGuid();
            Guid expectedFuncionarioId = Guid.NewGuid();
            int expectedSituacaoId = 1;
            DateTime? expectedDataHoraFim = null; 
            bool expectedAtual = true;

            // Act
            AndamentoCreateCommand command = new AndamentoCreateCommand(expectedPedidoId,expectedFuncionarioId, expectedSituacaoId);

            // Assert
            Assert.NotNull(command);
            Assert.Equal(expectedPedidoId, command.PedidoId);
            Assert.Equal(expectedFuncionarioId, command.FuncionarioId);
            Assert.Equal(expectedSituacaoId, command.SituacaoId);
            Assert.Equal(expectedDataHoraFim, command.DataHoraFim);
            Assert.Equal(expectedAtual, command.Atual);
        }                
    }
}
