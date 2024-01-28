using FastFoodProducao.Application.InputModels;
using System.ComponentModel.DataAnnotations;

namespace FastFoodProducao.Application.Test.InputModels
{
    public class AndamentoInputModelTests
    {
        [Fact]
        public void Andamendo_RequiredAttribute_IsValid()
        {
            // Arrange
            var model = new AndamentoInputModel();

            // Act
            var validationResult = ValidateModel(model);

            // Assert
            Assert.Empty(validationResult);

        }

        private static List<ValidationResult> ValidateModel(object model)
        {
            var validationContext = new ValidationContext(model);
            var validationResult = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResult, true);
            return validationResult;
        }
    }
}
