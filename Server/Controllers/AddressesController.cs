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
    public class AddressesController : ControllerBase
    {
        private readonly SVSignalRContext _context;

        public AddressesController(SVSignalRContext context)
        {
            _context = context;
        }

        // GET: api/Address
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressModel>>> GetAddresses()
        {
            return await _context.Addresses.ToListAsync();
        }

        // GET: api/Address/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddressModel>> GetAddressModel(int id)
        {
            var addressModel = await _context.Addresses.FindAsync(id);

            if (addressModel == null)
            {
                return NotFound();
            }

            return addressModel;
        }

        [HttpGet("provinceIds")]
        public async Task<ActionResult<IEnumerable<string>>> GetProvinces()
        {
            var provinceIds = _context.Addresses.Select(s => s.ProvinceId).Distinct().ToListAsync();
            if (provinceIds == null || provinceIds.Result.Count()==0)
            {
                return NotFound();
            }
            return await provinceIds;
        }

        [HttpGet("addresses/{provinceId}")]
        public async Task<ActionResult<IEnumerable<AddressModel>>> GetProvinces(string provinceId)
        {
            var addresses = _context.Addresses.Where(w => w.ProvinceId == provinceId).ToListAsync();
            if (addresses == null || addresses.Result.Count() == 0)
            {
                return NotFound();
            }
            return await addresses;
        }

        [HttpGet("addresses/{provinceId}/{districtId}")]
        public async Task<ActionResult<IEnumerable<AddressModel>>> GetProvinces(string provinceId, string districtId)
        {
            var addresses = _context.Addresses.Where(w => w.ProvinceId == provinceId && w.DistrictId == districtId).ToListAsync();
            if (addresses == null || addresses.Result.Count() == 0)
            {
                return NotFound();
            }
            return await addresses;
        }

        // PUT: api/Address/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAddressModel(int id, AddressModel addressModel)
        //{
        //    if (id != addressModel.AddressId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(addressModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AddressModelExists(id))
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

        //// POST: api/Address
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<AddressModel>> PostAddressModel(AddressModel addressModel)
        //{
        //    _context.Addresses.Add(addressModel);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAddressModel", new { id = addressModel.AddressId }, addressModel);
        //}

        //// DELETE: api/Address/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAddressModel(int id)
        //{
        //    var addressModel = await _context.Addresses.FindAsync(id);
        //    if (addressModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Addresses.Remove(addressModel);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AddressModelExists(int id)
        //{
        //    return _context.Addresses.Any(e => e.AddressId == id);
        //}
    }
}
