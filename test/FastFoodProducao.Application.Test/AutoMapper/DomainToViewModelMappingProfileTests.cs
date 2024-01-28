using AutoMapper;
using FastFoodProducao.Application.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodProducao.Application.Test.AutoMapper
{
    public class DomainToViewModelMappingProfileTests
    {
        [Fact]
        public void AndamentoMapping_IsValid()
        {
            // Arrange
            var profile = new DomainToViewModelMappingProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));

            // Act & Assert
            configuration.AssertConfigurationIsValid();
        }        
    }
}
