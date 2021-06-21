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
    public class WorkersController : ControllerBase
    {
        private readonly SVSignalRContext _context;

        public WorkersController(SVSignalRContext context)
        {
            _context = context;
        }

        // GET: api/Workers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkerModel>>> GetWorkers()
        {
            return await _context.Workers.ToListAsync();
        }

        // GET: api/Workers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkerModel>> GetWorkerModel(string id)
        {
            var workerModel = await _context.Workers.FindAsync(id);

            if (workerModel == null)
            {
                return NotFound();
            }

            return workerModel;
        }

        //// PUT: api/Workers/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutWorkerModel(string id, WorkerModel workerModel)
        //{
        //    if (id != workerModel.WorkerId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(workerModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!WorkerModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Workers
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<WorkerModel>> PostWorkerModel(WorkerModel workerModel)
        //{
        //    _context.Workers.Add(workerModel);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (WorkerModelExists(workerModel.WorkerId))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetWorkerModel", new { id = workerModel.WorkerId }, workerModel);
        //}

        //// DELETE: api/Workers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteWorkerModel(string id)
        //{
        //    var workerModel = await _context.Workers.FindAsync(id);
        //    if (workerModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Workers.Remove(workerModel);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool WorkerModelExists(string id)
        //{
        //    return _context.Workers.Any(e => e.WorkerId == id);
        //}
    }
}
