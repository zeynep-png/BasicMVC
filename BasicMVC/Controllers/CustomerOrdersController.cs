using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {

            var customer = new Customer
            {
                Id = 61,
                FirstName = "Zeynep",
                LastName = "Çakır",
                Email = "zeynep.cakir@gmail.com"
            };

            var orders = new List<Order>
           {
               new Order {Id= 1, ProductName = "Laptop", Price = 1500.00m, Quantity = 1},
               new Order {Id= 2, ProductName = "Keyboard", Price = 50.00m, Quantity = 4},
               new Order {Id= 3, ProductName = "Mouse", Price = 150.00m, Quantity = 3}
            };

            var customerOrderViewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(customerOrderViewModel);
        }
    }
}
