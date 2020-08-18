using JMRLeague.Shared;
using JMRLeagueWASM.Server.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JMRLeagueWASM.Server.Controllers
{
    [ApiController]
    public class MarbleEventController : ControllerBase
    {
        private readonly MarbleTeamsDBContext db;

        public MarbleEventController(MarbleTeamsDBContext db) => this.db = db;

        [HttpGet("marbleevents")]
        public IQueryable<MarbleEvent> GetMarbleEvents() => null;

        [HttpPost("marbleevents")]
        public IActionResult AddMarbleEvent([FromBody] MarbleEvent marbleEvent)
        {
            //Customer customer = basket.Customer;
            //var order = new Order()
            //{
            //    PizzaOrders = new List<PizzaOrder>()
            //};
            //customer.Order = order;
            //foreach (int pizzaId in basket.Orders)
            //{
            //    Pizza pizza = this.db.Pizzas.Single(p => p.Id == pizzaId);
            //    order.PizzaOrders.Add(new PizzaOrder { Pizza = pizza, Order = order });
            //}
            //order.TotalPrice = order.PizzaOrders.Sum(po => po.Pizza.Price);
            //this.db.Customers.Add(customer);
            //this.db.SaveChanges();
            return Ok();
        }

    }
}
