using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICatogeryRepository _catogeryRepository;

        public PieController(IPieRepository pieRepository, ICatogeryRepository catogeryRepository)
        {
            _pieRepository = pieRepository;
            _catogeryRepository = catogeryRepository;
        }

        public ViewResult List()
        {
            return View(_pieRepository.AllPies);
        }
    }
}
