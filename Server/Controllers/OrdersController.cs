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
    public class OrdersController : ControllerBase
    {
        private readonly SVSignalRContext _context;

        public OrdersController(SVSignalRContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetOrders()
        {
            return await _context.Orders
                                .Include(size => size.SizeRuns)
                                .AsNoTracking()
                                .ToListAsync();

            //return await _context.Orders.Where(w => w.IsEnable).ToListAsync();
        }

        // GET: api/Orders/108-7582/3.5
        [HttpGet("{productNo}/{sizeNo}")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetOrdersByPOBySize(string productNo, string sizeNo)
        {
            return await _context.Orders
                                .Include(size => size.SizeRuns.Where(sz => sz.SizeNo == sizeNo))
                                .Where(od => od.ProductNo == productNo)
                                .AsNoTracking()
                                .ToListAsync();
        }

        // GET: api/Orders/192168-01
        [HttpGet("style/{articleNo}")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetOrdersByArticle(string articleNo)
        {
            return await _context.Orders.Where(w => w.ArticleNo.ToUpper() == articleNo.ToUpper()).ToListAsync();
        }


        // GET: api/Orders/etd/from/to
        [HttpGet("etd/{from}/{to}")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetOrderByETD(DateTime from, DateTime to)
        {
            return await _context.Orders.Where(w => w.ETD >= from && w.ETD <= to).ToListAsync();
        }

        // GET: api/orders/

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderModel>> GetOrderModel(string id)
        {
            var orderModel = await _context.Orders
                                    .Include(sz => sz.SizeRuns)
                                    .AsNoTracking()
                                    .SingleOrDefaultAsync(s => s.ProductNo == id);

            if (orderModel == null)
            {
                return NotFound();
            }

            return orderModel;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderModel(string id, OrderModel orderModel)
        {
            if (id != orderModel.ProductNo)
            {
                return BadRequest();
            }

            _context.Entry(orderModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderModelExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderModel>> PostOrderModel(OrderModel orderModel)
        {
            _context.Orders.Add(orderModel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrderModelExists(orderModel.ProductNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrderModel", new { id = orderModel.ProductNo }, orderModel);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderModel(string id)
        {
            var orderModel = await _context.Orders.FindAsync(id);
            if (orderModel == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(orderModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderModelExists(string id)
        {
            return _context.Orders.Any(e => e.ProductNo == id);
        }
    }
}
