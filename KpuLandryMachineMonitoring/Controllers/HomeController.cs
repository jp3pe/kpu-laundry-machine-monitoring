﻿using KpuLandryMachineMonitoring.Models;
using Microsoft.AspNetCore.Mvc;

namespace KpuLandryMachineMonitoring.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(MariaDBService)) as MariaDBService;
            var useStateDataList = context.GetUseStateData();

            return View(useStateDataList);
        }
    }
}