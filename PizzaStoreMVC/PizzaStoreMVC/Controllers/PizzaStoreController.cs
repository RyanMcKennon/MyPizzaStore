using Newtonsoft.Json;
using PizzaStoreMVC.Models;
using PizzaStoreMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Controllers
{
    public class PizzaStoreController : Controller
    {
        PizzaStoreModel data = new PizzaStoreModel();
        string url = "http://localhost/pizzaStoreAPI/API/";
        HttpClient client;

        public ActionResult Landing()
        {
            return View();
        }
        // GET: PizzaStore
        public ActionResult Index()
        {
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(PizzaStoreModel m)
        {
            //data.PizzaOrder = new PizzaOrderDAO();
            data.PizzaOrder.Customer = m.Customer;
            TempData["temp"] = data;
            return RedirectToAction("Ordering");
        }

        public ActionResult Ordering()
        {
            data = TempData["temp"] as PizzaStoreModel;
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            data.ListOfTopping = getToppings().Result;
            data.ListOfCheeses = getCheeses().Result;
            data.ListOfSizes = getSizes().Result;
            data.ListOfSauces = getSauces().Result;
            data.ListOfCrusts = getCrusts().Result;
            TempData["temp"] = data;
            return View(data);
        }

        [HttpPost]
        public ActionResult Ordering(PizzaStoreModel m)
        {
            data = TempData["temp"] as PizzaStoreModel;
            //data.PizzaOrder.Order = new OrderDAO();
            //data.PizzaOrder.Order.Pizzas = new List<PizzaDAO>();
            PizzaDAO pizza = new PizzaDAO();
            pizza.Toppings = new List<ToppingDAO>();
            pizza.Cheeses = new List<CheeseDAO>();
            pizza.Crust = new CrustDAO();
            pizza.Sauce = new SauceDAO();
            pizza.Size = new SizeDAO();

            for (int i = 0; i < m.ListOfTopping.Count; i++)
            {
                m.ListOfTopping[i].ID = data.ListOfTopping[i].ID;
                m.ListOfTopping[i].Name = data.ListOfTopping[i].Name;
            }
            for (int i = 0; i < m.ListOfCheeses.Count; i++)
            {
                m.ListOfCheeses[i].ID = data.ListOfCheeses[i].ID;
                m.ListOfCheeses[i].Name = data.ListOfCheeses[i].Name;
            }
            for (int i = 0; i < m.ListOfSizes.Count; i++)
            {
                m.ListOfSizes[i].ID = data.ListOfSizes[i].ID;
                m.ListOfSizes[i].Name = data.ListOfSizes[i].Name;
            }
            for (int i = 0; i < m.ListOfCrusts.Count; i++)
            {
                m.ListOfCrusts[i].ID = data.ListOfCrusts[i].ID;
                m.ListOfCrusts[i].Name = data.ListOfCrusts[i].Name;
            }

            for (int i = 0; i < m.ListOfSauces.Count; i++)
            {
                m.ListOfSauces[i].ID = data.ListOfSauces[i].ID;
                m.ListOfSauces[i].name = data.ListOfSauces[i].name;
            }

            foreach (var item in m.ListOfTopping)
            {
                if(item.picked == true)
                {
                    pizza.Toppings.Add(item);
                }
            }
            foreach (var item in m.ListOfCheeses)
            {
                if(item.picked == true)
                {
                    pizza.Cheeses.Add(item);
                }
            }
            foreach (var item in m.ListOfCrusts)
            {
                if (item.picked == true)
                {
                    pizza.Crust.ID = item.ID;
                    pizza.Crust.Name = item.Name;
                }
            }
            foreach (var item in m.ListOfSauces)
            {
                if (item.picked == true)
                {
                    pizza.Sauce.ID = item.ID;
                    pizza.Sauce.name = item.name;
                }
            }
            foreach (var item in m.ListOfSizes)
            {
                if (item.picked == true)
                {
                    pizza.Size.ID = item.ID;
                    pizza.Size.Name = item.Name;
                }
            }
            data.PizzaOrder.Order.Pizzas.Add(pizza);
            TempData["temp"] = data;
            return View(data);
        }

        public ActionResult Review()
        {
            data = TempData["temp"] as PizzaStoreModel;
            TempData["final"] = data;
            return View(data);
        }

        public ActionResult CustomerInfo()
        {
            return View(data);
        }

        [HttpPost]
        public ActionResult CustomerInfo(PizzaStoreModel m)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            data.History = getHistory(int.Parse(m.Customer.ID.ToString())).Result;
            return View(data);
        }
        public async Task<List<PizzaOrderDAO>> getHistory(int id)
        {
            List<PizzaOrderDAO> history = new List<PizzaOrderDAO>();
            HttpResponseMessage response = client.GetAsync("Customer" + "/" + id.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                var stuff = await response.Content.ReadAsStringAsync();
                var morestuff = JsonConvert.DeserializeObject<List<PizzaOrderDAO>>(stuff);
                history = morestuff;
            }
            return history;
        }

        [HttpPost]
        public ActionResult Review(PizzaStoreModel m)
        {
            m = TempData["final"] as PizzaStoreModel;
            var x = InsertPizzaOrder(m.PizzaOrder);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<List<CheeseDAO>> InsertPizzaOrder(PizzaOrderDAO order)
        {
            List<CheeseDAO> cheeses = new List<CheeseDAO>() ;
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync(@"http://localhost/PizzaStoreAPI/API/PizzaOrder", order);
            return cheeses;
        }

        public async Task<List<CrustDAO>> getCrusts()
        {
            List<CrustDAO> crusts = new List<CrustDAO>();
            HttpResponseMessage response = client.GetAsync("Crust").Result;
            if (response.IsSuccessStatusCode)
            {
                var stuff = await response.Content.ReadAsStringAsync();
                var morestuff = JsonConvert.DeserializeObject<List<CrustDAO>>(stuff);
                crusts = morestuff;
            }
            return crusts;
        }
        public async Task<List<SauceDAO>> getSauces()
        {
            List<SauceDAO> sauces = new List<SauceDAO>();
            HttpResponseMessage response = client.GetAsync("Sauce").Result;
            if (response.IsSuccessStatusCode)
            {
                var stuff = await response.Content.ReadAsStringAsync();
                var morestuff = JsonConvert.DeserializeObject<List<SauceDAO>>(stuff);
                sauces = morestuff;
            }
            return sauces;
        }
        public async Task<List<SizeDAO>> getSizes()
        {
            List<SizeDAO> sizes = new List<SizeDAO>();
            HttpResponseMessage response = client.GetAsync("Size").Result;
            if (response.IsSuccessStatusCode)
            {
                var stuff = await response.Content.ReadAsStringAsync();
                var morestuff = JsonConvert.DeserializeObject<List<SizeDAO>>(stuff);
                sizes = morestuff;
            }
            return sizes;
        }
        public async Task<List<CheeseDAO>> getCheeses()
        {
            List<CheeseDAO> cheeses = new List<CheeseDAO>();
            HttpResponseMessage response = client.GetAsync("Cheese").Result;
            if(response.IsSuccessStatusCode)
            {
                var stuff = await response.Content.ReadAsStringAsync();
                var morestuff = JsonConvert.DeserializeObject<List<CheeseDAO>>(stuff);
                cheeses = morestuff;
            }
            return cheeses;
        }

        public async Task<List<ToppingDAO>> getToppings()
        {
            List<ToppingDAO> toppings = new List<ToppingDAO>();
            HttpResponseMessage response = client.GetAsync("Topping").Result;
            if (response.IsSuccessStatusCode)
            {
                var stuff = await response.Content.ReadAsStringAsync();
                var morestuff = JsonConvert.DeserializeObject<List<ToppingDAO>>(stuff);
                toppings = morestuff;
            }
            return toppings;
        }

        // GET: PizzaStore/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaStore/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaStore/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaStore/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaStore/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaStore/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaStore/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
