// OcorrenciaController.cs
using Microsoft.AspNetCore.Mvc;
using OnData.Models;
using OnData.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcorrenciaController : ControllerBase
    {
        private readonly OcorrenciaService _ocorrenciaService;

        public OcorrenciaController(OcorrenciaService ocorrenciaService)
        {
            _ocorrenciaService = ocorrenciaService;
        }

        /// <summary>
        /// Obtém a lista de todas as ocorrências.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ocorrencia>>> GetOcorrencias()
        {
            return await _ocorrenciaService.GetOcorrenciasAsync();
        }

        /// <summary>
        /// Obtém uma ocorrência pelo ID.
        /// </summary>
        /// <param name="id">ID da ocorrência.</param>
        [HttpGet("{id}")]
        public async Task<ActionResult<Ocorrencia>> GetOcorrencia(int id)
        {
            var ocorrencia = await _ocorrenciaService.GetOcorrenciaByIdAsync(id);
            if (ocorrencia == null)
            {
                return NotFound();
            }
            return ocorrencia;
        }

        /// <summary>
        /// Cria uma nova ocorrência.
        /// </summary>
        /// <param name="ocorrencia">Dados da ocorrência.</param>
        [HttpPost]
        public async Task<ActionResult<Ocorrencia>> PostOcorrencia(Ocorrencia ocorrencia)
        {
            await _ocorrenciaService.CreateOcorrenciaAsync(ocorrencia);
            return CreatedAtAction(nameof(GetOcorrencia), new { id = ocorrencia.IdOcorrencia }, ocorrencia);
        }

        /// <summary>
        /// Atualiza uma ocorrência existente.
        /// </summary>
        /// <param name="id">ID da ocorrência.</param>
        /// <param name="ocorrencia">Dados atualizados da ocorrência.</param>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOcorrencia(int id, Ocorrencia ocorrencia)
        {
            if (id != ocorrencia.IdOcorrencia)
            {
                return BadRequest();
            }
            await _ocorrenciaService.UpdateOcorrenciaAsync(ocorrencia);
            return NoContent();
        }

        /// <summary>
        /// Exclui uma ocorrência.
        /// </summary>
        /// <param name="id">ID da ocorrência.</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOcorrencia(int id)
        {
            await _ocorrenciaService.DeleteOcorrenciaAsync(id);
            return NoContent();
        }
    }
}