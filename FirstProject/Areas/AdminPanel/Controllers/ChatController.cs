﻿using Microsoft.AspNetCore.Mvc;

namespace FirstContext1.Areas.AdminPanel.Controllers
{
    [Area("Chat")]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
