﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core2.Models;
using Core2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Core2.Controllers
{
    public class HomeController:Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Pie Shop",
                Pies = pies.ToList()
            };
            return View(homeViewModel);
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}