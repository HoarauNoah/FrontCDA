using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FrontCDA.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FrontCDA.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync("https://localhost:44370/api/Products");
            var content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(content);

            return View(products);
        }
        public async Task<IActionResult> Details(string id)
        {
            var response = await _client.GetAsync("https://localhost:44370/api/Products/"+id);
            var content = await response.Content.ReadAsStringAsync();
            Product product = JsonConvert.DeserializeObject<Product>(content);
            response = await _client.GetAsync("https://localhost:44370/api/Suppliers/" + product.SupplierId);
            content = await response.Content.ReadAsStringAsync();
            product.Supplier = JsonConvert.DeserializeObject<Supplier>(content);
            return View(product);
        }

       
    }
}
