using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WATERLINE.Portal.Models;
using WATERLINE.Portal.ViewModels.User;
using WATERLINE.Services.DTOs.Users;
using WATERLINE.Services.Repositories.Interfaces;

namespace WATERLINE.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsersRepository _users;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, IUsersRepository users, IMapper mapper)
        {
            _logger = logger;
            _users = users;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Test()
        {
            throw new Exception();
            //var user = new UserViewModel
            //{
            //    Firstname = "Mohammed",
            //    Middlename = "Khalil",
            //    Lastname = "Ayasrah",
            //    Email = "test@demo.com",
            //    Password = "123456",
            //    Phonenumber = "+962798997867",
            //    RoleId = 3,
            //    Username = "KhalilAyasrah"
            //};

            //await _users.Insert("System", _mapper.Map<UserDto>(user));

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error() => View();


    }
}
