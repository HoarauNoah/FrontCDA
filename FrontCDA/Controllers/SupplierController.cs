using FrontCDA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FrontCDA.Controllers
{
    public class SupplierController : Controller
    {
        private readonly HttpClient _client = new HttpClient();
        
        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync("https://localhost:44370/api/Suppliers");
            var content = await response.Content.ReadAsStringAsync();
            List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);
            return View(suppliers);
        }

        public async Task<IActionResult> Details(string id)
        {
            var response = await _client.GetAsync("https://localhost:44370/api/Suppliers/" + id);
            var content = await response.Content.ReadAsStringAsync();
            Supplier supplier = JsonConvert.DeserializeObject<Supplier>(content);
            return View(supplier);
        }
    }
}
