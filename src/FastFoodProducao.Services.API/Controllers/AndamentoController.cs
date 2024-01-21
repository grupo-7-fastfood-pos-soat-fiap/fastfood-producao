using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.Interfaces;
using FastFoodProducao.Application.Services;
using FastFoodProducao.Application.ViewModels;
using FastFoodProducao.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace FastFoodProducao.Services.Api.Controllers
{
    [ApiController]
    [Route("api/andamento")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class AndamentoController: ApiController
    {
        private readonly IAndamentoApp _andamentoApp;

        public AndamentoController(IAndamentoApp andamentoApp)
        {            
            _andamentoApp = andamentoApp;
        }

        // [HttpGet]
        // [SwaggerOperation(
        // Summary = "Lista todos os pedidos.",
        // Description = "Lista ordenada pela data de todos os pedidos"
        // )]
        // [SwaggerResponse(200, "Success", typeof(List<PedidoViewModel>))]
        // [SwaggerResponse(204, "No Content")]
        // [SwaggerResponse(400, "Bad Request")]
        // [SwaggerResponse(500, "Unexpected error")]
        // public async Task<ActionResult> GetAll()
        // {
        //     try
        //     {
        //         var lista = await _pedidoApp.GetAll();
        //         return CustomListResponse(lista, lista.Count);
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem("Há um problema com a sua requisição - " + e.Message);
        //     }
            
        // }

        // [HttpGet("ativos")]
        // [SwaggerOperation(
        // Summary = "Lista todos os pedidos ativos.",
        // Description = "Lista agrupada por situação e ordenada pela data e hora de todos os pedidos ativos"
        // )]
        // [SwaggerResponse(200, "Success", typeof(List<PedidoViewModel>))]
        // [SwaggerResponse(204, "No Content")]
        // [SwaggerResponse(400, "Bad Request")]
        // [SwaggerResponse(500, "Unexpected error")]
        // public async Task<ActionResult> GetAllAtivos()
        // {
        //     try
        //     {
        //         var lista = await _pedidoApp.GetAllAtivos();
        //         return CustomListResponse(lista, lista.Count);
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem("Há um problema com a sua requisição - " + e.Message);
        //     }

        // }

        [HttpPost]
        [SwaggerOperation(
        Summary = "Criar um novo andamento para o pedido.",
        Description = "Criar um novo andamento para o pedido."
        )]
        [SwaggerResponse(201, "Success", typeof(List<AndamentoViewModel>))]
        [SwaggerResponse(204, "No Content")]
        [SwaggerResponse(400, "Bad Request")]
        [SwaggerResponse(500, "Unexpected error")]
        public async Task<ActionResult> CriarAndamento([FromBody] AndamentoInputModel andamento)
        {
            try
            {
                if (!ModelState.IsValid)
                    return CustomResponse(ModelState);

                var result = await _andamentoApp.Add(andamento);
                //if (result.Id != null)
                //    return CustomResponse(await _pedidoApp.GetById((Guid)result.Id));
                //else
                    return CustomCreateResponse(result);
            }
            catch (Exception e)
            {
                return Problem("Há um problema com a sua requisição - " + e.Message);
            }
            
        }

        // [HttpGet("situacao/{id}")]
        // [SwaggerOperation(
        // Summary = "Lista todos os pedidos por situacao.",
        // Description = "Lista ordenada pela data de todos os pedidos por situacao"
        // )]
        // [SwaggerResponse(200, "Success", typeof(List<PedidoViewModel>))]
        // [SwaggerResponse(204, "No Content")]
        // [SwaggerResponse(400, "Bad Request")]
        // [SwaggerResponse(500, "Unexpected error")]
        // public async Task<ActionResult> GetAllBySituacao([FromRoute] int id)
        // {
        //     try
        //     {
        //         var lista = await _pedidoApp.GetAllBySituacao(id);
        //         return CustomListResponse(lista, lista.Count);
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem("Há um problema com a sua requisição - " + e.Message);
        //     }
            
        // }
    }
}
