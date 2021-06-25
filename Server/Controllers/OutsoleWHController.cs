using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SVSignalR.Server.Data;
using SVSignalR.Shared.Models.MasterSchedule;

namespace SVSignalR.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutsoleWHController : ControllerBase
    {
        private readonly SVSignalRContext _context;

        public OutsoleWHController(SVSignalRContext context)
        {
            _context = context;
        }

        // GET: api/OutsoleWH
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OutsoleWHCheckModel>>> GetOutsoleMaterialCheckingList()
        {
            return await _context.OutsoleMaterialCheckingList
                                    .Include(od => od.Order)
                                    .ToListAsync();
        }

        // GET: api/OutsoleWH/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OutsoleWHCheckModel>> GetOutsoleWHCheckModel(int id)
        {
            var outsoleWHCheckModel = await _context.OutsoleMaterialCheckingList
                                                        .Include(od => od.Order)
                                                        .Include(supp => supp.Supplier)
                                                        .SingleOrDefaultAsync(s => s.OSCheckingID == id);

            if (outsoleWHCheckModel == null)
            {
                return NotFound();
            }

            return outsoleWHCheckModel;
        }


        [HttpGet("cart/{indexNo}")]
        public async Task<ActionResult<IEnumerable<OutsoleWHCheckModel>>> GetOutsoleWHCheckListByIndexNo(string indexNo)
        {
            int indexSearch = 0;
            Int32.TryParse(indexNo, out indexSearch);
            var results = await _context.OutsoleMaterialCheckingList
                                                        .Include(od => od.Order)
                                                        .Include(supp => supp.Supplier)
                                                        .Where(w => w.WorkingCard == indexSearch)
                                                        .ToListAsync();

            if (results == null || results.Count() == 0)
            {
                return NotFound();
            }

            return results;
        }

        [HttpGet("po/{productNo}")]
        public async Task<ActionResult<IEnumerable<OutsoleWHCheckModel>>> GetOutsoleWHCheckListByProductNo(string productNo)
        {
            var results = await _context.OutsoleMaterialCheckingList
                                                        .Include(od => od.Order)
                                                        .Include(supp => supp.Supplier)
                                                        .Where(w => w.ProductNo == productNo)
                                                        .ToListAsync();

            if (results == null || results.Count() == 0)
            {
                return NotFound();
            }

            return results;
        }


        // PUT: api/OutsoleWH/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutsoleWHCheckModel(int id, OutsoleWHCheckModel outsoleWHCheckModel)
        {
            if (id != outsoleWHCheckModel.OSCheckingID)
            {
                return BadRequest();
            }

            _context.Entry(outsoleWHCheckModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OutsoleWHCheckModelExists(id))
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

        // POST: api/OutsoleWH
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OutsoleWHCheckModel>> PostOutsoleWHCheckModel(OutsoleWHCheckModel outsoleWHCheckModel)
        {
            _context.OutsoleMaterialCheckingList.Add(outsoleWHCheckModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOutsoleWHCheckModel", new { id = outsoleWHCheckModel.OSCheckingID }, outsoleWHCheckModel);
        }

        // DELETE: api/OutsoleWH/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOutsoleWHCheckModel(int id)
        {
            var outsoleWHCheckModel = await _context.OutsoleMaterialCheckingList.FindAsync(id);
            if (outsoleWHCheckModel == null)
            {
                return NotFound();
            }

            _context.OutsoleMaterialCheckingList.Remove(outsoleWHCheckModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OutsoleWHCheckModelExists(int id)
        {
            return _context.OutsoleMaterialCheckingList.Any(e => e.OSCheckingID == id);
        }
    }
}
