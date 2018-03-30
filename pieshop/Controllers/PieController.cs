using Microsoft.AspNetCore.Mvc;
using pieshop.Models;

namespace pieshop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public ViewResult List()
        {
            return View();
        }
    }
}