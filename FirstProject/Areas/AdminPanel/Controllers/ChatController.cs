﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstContext1.Areas.AdminPanel.Controllers
{
    [Authorize]
    [Area("AdminPanel")]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();


        }




    }
}
