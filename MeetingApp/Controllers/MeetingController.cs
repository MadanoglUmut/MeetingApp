using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model){
            if(ModelState.IsValid){
            Repository.userListAdd(model);
            ViewBag.UserCount = Repository.UserList.Where(info => info.WillAttend == true).Count();    
            return View("Thanks",model);   
            }else{
                return View(model);
            }            
        }

        [HttpGet]
        public IActionResult List(){
            return View(Repository.UserList);
        }
        
        [HttpGet]
        public IActionResult Details(int id){
            return View(Repository.GetById(id));
        }
    }
}