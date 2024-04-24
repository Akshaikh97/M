using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvcapp.Repo;

namespace Mvcapp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository _ProductRepository)
        {
            productRepository = _ProductRepository;
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}