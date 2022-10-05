
using Aspi.Net_EntityFramework.Data;
using Aspi.Net_EntityFramework.Models;
using Aspi.Net_EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aspi.Net_EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<SliderDetail> sliderDetails = _context.SliderDetails.ToList();
            List<Work> works = _context.Works.ToList();
            //SliderDetail sliderDetail = _context.SliderDetails.FirstOrDefault();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderDetails = sliderDetails,
                Works = works
            };
            return View(model);
        }      
    }
}
