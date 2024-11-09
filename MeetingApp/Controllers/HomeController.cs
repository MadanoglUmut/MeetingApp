using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //ViewData["KullaniciAdi"] = "Umut";
            if(saat > 12){
                ViewBag.Selamlama = "Iyi Gunler";
            }else{
                ViewBag.Selamlama = "Gunaydin";
            }

            var katilimciSayisi = Repository.UserList.Where(info=>info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul Turkan Saylan Kongre Merkezi",
                Date= new DateTime(2024,11,03,20,0,0),
                NumberOfPeople = katilimciSayisi
            };
           
            return View(meetingInfo);
        }

    }
}