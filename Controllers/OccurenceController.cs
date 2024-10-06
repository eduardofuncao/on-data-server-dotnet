using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using on_data_server_dotnet.Data;
using on_data_server_dotnet.Models;

namespace on_data_server_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccurrenceController : ControllerBase
    {
        private readonly OccurrenceDbContext _context;

        public OccurrenceController(OccurrenceDbContext context)
        {
            _context = context;
        }

        // GET: api/Occurrences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Occurrence>>> GetOccurrences()
        {
            return await _context.Occurrences.ToListAsync();
        }

        // GET: api/Occurrences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Occurrence>> GetOccurrence(int id)
        {
            var occurrence = await _context.Occurrences.FindAsync(id);

            if (occurrence == null)
            {
                return NotFound();
            }

            return occurrence;
        }

        // PUT: api/Occurrences/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOccurrence(int id, Occurrence occurrence)
        {
            if (id != occurrence.IdOcorrencia)
            {
                return BadRequest();
            }

            _context.Entry(occurrence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OccurrenceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Occurrences
        [HttpPost]
        public async Task<ActionResult<Occurrence>> PostOccurrence(Occurrence occurrence)
        {
            _context.Occurrences.Add(occurrence);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOccurrence), new { id = occurrence.IdOcorrencia }, occurrence);
        }

        // DELETE: api/Occurrences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOccurrence(int id)
        {
            var occurrence = await _context.Occurrences.FindAsync(id);
            if (occurrence == null)
            {
                return NotFound();
            }

            _context.Occurrences.Remove(occurrence);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OccurrenceExists(int id)
        {
            return _context.Occurrences.Any(e => e.IdOcorrencia == id);
        }
    }
}
