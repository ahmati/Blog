using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using blog.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using blog.ViewModels;
using System.Collections.Generic;
using blog.Services;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICategoryService _service;

        public HomeController(ApplicationDbContext context,ICategoryService service)
        {
            this._context = context;
            _service = service;
        }


        public IActionResult Index()
        {
            var viewModel = new HomeViewModel();
            var posts =  _context.Posts.ToList();
            List<string> categories = new List<string>();

            var postModel = new List<PostCategoryViewModel>();
            for (int i = 0; i < posts.Count; i++)
            {
               
                categories = _service.GetCategoryNameByPostId(posts[i].PostId);
                postModel.Add(new PostCategoryViewModel
                {
                    PostId=posts[i].PostId,
                    Title=posts[i].Title,
                    Categories=categories,
                    Short_description=posts[i].Short_description
                });
            
            }
            viewModel.Post = postModel;
                                                   
            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
    }
}
