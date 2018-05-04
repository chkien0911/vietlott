
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vietlott.Api.DataAccess.Context;
using Vietlott.Api.DataAccess.Entities;

namespace Vietlott.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/DrawResults")]
    public class DrawResultsController : Controller
    {
        private readonly AppDbContext _context;

        public DrawResultsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DrawResults
        [HttpGet]
        public IEnumerable<DrawResult> GetDrawResults()
        {
            return _context.DrawResults;
        }

        // GET: api/DrawResults/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDrawResult([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drawResult = await _context.DrawResults.SingleOrDefaultAsync(m => m.Id == id);

            if (drawResult == null)
            {
                return NotFound();
            }

            return Ok(drawResult);
        }

        // PUT: api/DrawResults/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrawResult([FromRoute] string id, [FromBody] DrawResult drawResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != drawResult.Id)
            {
                return BadRequest();
            }

            _context.Entry(drawResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrawResultExists(id))
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

        // POST: api/DrawResults
        [HttpPost]
        public async Task<IActionResult> PostDrawResult([FromBody] DrawResult drawResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.DrawResults.Add(drawResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDrawResult", new { id = drawResult.Id }, drawResult);
        }

        // DELETE: api/DrawResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrawResult([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drawResult = await _context.DrawResults.SingleOrDefaultAsync(m => m.Id == id);
            if (drawResult == null)
            {
                return NotFound();
            }

            _context.DrawResults.Remove(drawResult);
            await _context.SaveChangesAsync();

            return Ok(drawResult);
        }

        private bool DrawResultExists(string id)
        {
            return _context.DrawResults.Any(e => e.Id == id);
        }
    }
}