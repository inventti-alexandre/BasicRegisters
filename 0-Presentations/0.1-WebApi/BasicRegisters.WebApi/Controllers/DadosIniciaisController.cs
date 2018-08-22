using AutoMapper;
using BasicRegisters.Application.Services.GerarDadosIniciais;
using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using BasicRegisters.WebApi.ViewModels.DadosIniciais;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicRegisters.WebApi.Controllers
{
    [Route("api/dados-iniciais")]
    public class DadosIniciaisController : Controller
    {
        // POST api/values
        [HttpPost]
        [AllowAnonymous]
        public object Post(
            [FromBody]DadosIniciaisViewModel dadosIniciaisViewModel,
            [FromServices]DadosIniciaisServices _dadosIniciaisServices,
            [FromServices]IMapper _mapper)
        {
            var gerarDadosIniciaisDto = _dadosIniciaisServices.GerarDadosIniciais(_mapper.Map<DadosIniciaisViewModel, DadosIniciaisDto>(dadosIniciaisViewModel));

            return new { gerarDadosIniciaisDto.Errors, gerarDadosIniciaisDto.IsValid };

        }
    }
}