using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WATERLINE.Settings;

namespace WATERLINE.Portal.Controllers
{
    public class AuthController : Controller
    {
        private readonly IMemoryCache _cache;
        public AuthController(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            var name = _cache.Get("Application Name");
            return View();
        }
    }
}
