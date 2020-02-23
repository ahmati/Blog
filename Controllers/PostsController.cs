using blog.Data;
using blog.Models;
using blog.Services;
using blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace blog.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICategoryService _categoryService;
        private readonly IKeyValueService _keyValueService;

        public PostsController(ApplicationDbContext context, ICategoryService categoryService, IKeyValueService keyValueService)
        {
            _context = context;
            _categoryService = categoryService;
            _keyValueService = keyValueService;

        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
          
           var model = await _context.Posts.ToListAsync();

            return View(model);
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = new PostCommentViewmModel();
            var comment= _context.Comments
                .Where(m => m.PostId == id).ToList();
            var post = await _context.Posts
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post != null)
            {
                model.Comment = comment;
                model.Post = post;
              
            }

            return View(model);
        }

        // GET: Posts/Create
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categoriesId = _categoryService.GetCategoryIdsByPostId(id);
            var postViewModel = new PostViewModel();
            if (id != 0)
            {
                var post = _context.Posts.Find(id);
                postViewModel.PostId = post.PostId;
                postViewModel.Title = post.Title;
                postViewModel.Categories = categoriesId;
                postViewModel.CreatedOn = post.CreatedOn;
                postViewModel.CreatedBy = post.CreatedBy;
                postViewModel.Short_description = post.Short_description;
                postViewModel.Long_description = post.Long_description;
            }
            SelectLists(postViewModel);

            return View(postViewModel);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var categoriesId = _categoryService.GetCategoryIdsByPostId(id);
            var postViewModel = new PostViewModel();
            if (id != 0)
            {
                var post = _context.Posts.Find(id);
                postViewModel.PostId = post.PostId;
                postViewModel.Title = post.Title;
                postViewModel.Categories = categoriesId;
                postViewModel.CreatedOn = post.CreatedOn;
                postViewModel.CreatedBy = post.CreatedBy;
                postViewModel.Short_description = post.Short_description;
                postViewModel.Long_description = post.Long_description;
            }
            SelectLists(postViewModel);

            return View(postViewModel);
        }

        // POST: Posts/Create
        [HttpPost]
        
        [Authorize]
        public  IActionResult Create(PostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                var post = new Post();
                if (model.PostId == 0)
                {
                    post = new Post
                    {
                        PostId = model.PostId,
                        Title = model.Title,
                        Short_description = model.Short_description,
                        Long_description = model.Long_description,
                        CreatedBy = model.CreatedBy,
                        CreatedOn = DateTime.UtcNow
                    };
                    _context.Add(post);
                    _context.SaveChanges();
                    for (int i = 0; i < model.Categories.Count; i++)
                    {
                        int item = model.Categories[i];
                        var post_Category = new Post_Category
                        {
                            PostId = post.PostId,
                            Category_Id = item
                        };
                        _context.Add(post_Category);
                        _context.SaveChanges();
                    }
                }
                else
                {
                    var id = model.PostId;
                    post = _context.Posts.Where(x => x.PostId == id).Include(x => x.Post_Categories).FirstOrDefault();
                    post.Title = model.Title;
                    post.Short_description = model.Short_description;
                    post.Long_description = model.Long_description;
                    post.CreatedOn = model.CreatedOn;
                    post.CreatedBy = model.CreatedBy;

                    var newPost = new List<Post_Category>();

                    for (int i = 0; i < model.Categories.Count; i++)
                    {
                        newPost.Add(new Post_Category
                        {
                            PostId = post.PostId,
                            Category_Id = model.Categories[i]
                        });

                    }

                    post.Post_Categories = newPost;
                    _context.Update(post);
                    _context.SaveChanges();


                }
               RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw ;
            }

            return Redirect(Url.Action("Create", "Posts"));

        }




        private PostViewModel SelectLists(PostViewModel model)
        {
            model.Categories_Name = new MultiSelectList(_keyValueService.GetCategoriesKeyValue(), "Key", "Value");

            return model;
        }

        
        public IActionResult AddComments(string content,string username,string email,int postId)
        {

            if (ModelState.IsValid)
            { 
                var comment = new Comment
                {
                    Content=content,
                    UserName=username,
                    Email=email,
                    PostId=postId
                };
                _context.Add(comment);
                _context.SaveChanges();
                
              }

            return RedirectToAction(nameof(Details), new { id = postId });

        }
        

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }
    }
}
