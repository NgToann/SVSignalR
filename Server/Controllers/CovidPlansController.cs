using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SVSignalR.Server.Data;
using SVSignalR.Shared.Models;

namespace SVSignalR.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidPlansController : ControllerBase
    {
        private readonly SVSignalRContext _context;

        public CovidPlansController(SVSignalRContext context)
        {
            _context = context;
        }

        // GET: api/CovidPlans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CovidPlanModel>>> GetCovidPlanList()
        {
            return await _context.CovidPlanList                                    
                                    .Include(add => add.AddressInfo)
                                    .OrderByDescending(o => o.CreatedTime)
                                    .ToListAsync();
        }

        // GET: api/CovidPlans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CovidPlanModel>> GetCovidPlanModel(string id)
        {
            var covidPlanModel = await _context.CovidPlanList
                                                .Include(add => add.AddressInfo)
                                                .SingleOrDefaultAsync(s => s.WorkerId == id);

            if (covidPlanModel == null)
            {
                return NotFound();
            }

            return covidPlanModel;
        }

        // PUT: api/CovidPlans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCovidPlanModel(string id, CovidPlanModel covidPlanModel)
        {
            if (id != covidPlanModel.WorkerId)
            {
                return BadRequest();
            }

            _context.Entry(covidPlanModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CovidPlanModelExists(id))
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

        // POST: api/CovidPlans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CovidPlanModel>> PostCovidPlanModel(CovidPlanModel covidPlanModel)
        {
            var address = covidPlanModel.AddressInfo;
            _context.Entry(address).State = EntityState.Unchanged;
            
            _context.CovidPlanList.Add(covidPlanModel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (CovidPlanModelExists(covidPlanModel.WorkerId))
                {
                    return Conflict();
                }
                else
                {
                    var x = ex.Message.ToString();
                    throw;
                }
            }
            return CreatedAtAction("GetCovidPlanModel", new { id = covidPlanModel.WorkerId }, covidPlanModel);
        }

        // DELETE: api/CovidPlans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCovidPlanModel(string id)
        {
            var covidPlanModel = await _context.CovidPlanList.FindAsync(id);
            if (covidPlanModel == null)
            {
                return NotFound();
            }

            _context.CovidPlanList.Remove(covidPlanModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CovidPlanModelExists(string id)
        {
            return _context.CovidPlanList.Any(e => e.WorkerId == id);
        }
    }
}
