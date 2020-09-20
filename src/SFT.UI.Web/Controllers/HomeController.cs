using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SFT.ApplicationCore.Entity;
using SFT.ApplicationCore.Interfaces.Repository;
using SFT.ApplicationCore.Interfaces.Services;
using SFT.ApplicationCore.Services;
using SFT.Infrasctructure.Data;
using SFT.Infrasctructure.Repository;
using SFT.UI.Web.Models;

namespace SFT.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FinanceiroContext _contextCliente;

        public HomeController(ILogger<HomeController> logger, FinanceiroContext contextCliente)
        {
            _logger = logger;
            _contextCliente = contextCliente;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Clientes(int Id)
        {
            ClienteRepository clienteRepository = new ClienteRepository(_contextCliente);
            ClienteService clienteService = new ClienteService(clienteRepository);
            return View(clienteService.ObterPorId(Id));
        }

        public IActionResult ClienteAdd()
        {
            ClienteRepository clienteRepository = new ClienteRepository(_contextCliente);
            ClienteService clienteService = new ClienteService(clienteRepository);
            return View();
        }

        public IActionResult ClienteEdit(int Id)
        {
            ClienteRepository clienteRepository = new ClienteRepository(_contextCliente);
            ClienteService clienteService = new ClienteService(clienteRepository);
            return View(clienteService.ObterPorId(Id));
        }

        public IActionResult ClienteListView()
        {
            ClienteRepository clienteRepository = new ClienteRepository(_contextCliente);
            ClienteService clienteService = new ClienteService(clienteRepository);
            return View(clienteService.ObterTodos());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
