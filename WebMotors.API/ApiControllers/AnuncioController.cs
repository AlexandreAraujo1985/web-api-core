using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebMotors.API.Model;
using WebMotors.Data.Entity;
using WebMotors.Data.Repository.Interfaces;

namespace WebMotors.API.ApiControllers
{
    [Route("anuncio")]
    public class AnuncioController : Controller
    {
        private IAnuncioRepository _anuncioRepository;
        private IMapper _mapper;
        public AnuncioController(IAnuncioRepository anuncioRepository, IMapper mapper)
        {
            _anuncioRepository = anuncioRepository;
            _mapper = mapper;
        }

        
        [HttpGet, Route("{idAnuncio}")]
        public async Task<IActionResult> ObterAnuncio(int idAnuncio)
        {
            var anuncio = await _anuncioRepository.ObterAnuncio(idAnuncio);
            return Ok(anuncio);
        }

        [HttpPost]
        public async Task<IActionResult> IncluirAnuncio([FromBody] Anuncio anuncio)
        {
            var anucioToAdd = _mapper.Map<AnuncioEntity>(anuncio);
            await _anuncioRepository.IncluirAnuncio(anucioToAdd);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarAnuncio(int idAnuncio, [FromBody] Anuncio anuncio)
        {
            var anucioToUpSert = _mapper.Map<AnuncioEntity>(anuncio);
            await _anuncioRepository.IncluirAnuncio(anucioToUpSert);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarAnuncio(int idAnuncio)
        {
            await _anuncioRepository.DeletarAnuncio(idAnuncio);
            return NoContent();
        }
    }
}
