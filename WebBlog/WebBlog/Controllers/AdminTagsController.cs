using Microsoft.AspNetCore.Mvc;
using WebBlog.Data;
using WebBlog.Models.Domain;
using WebBlog.Models.ViewModels;

namespace WebBlog.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly WebBlogDbContext webBlogDbContext;

        public AdminTagsController(WebBlogDbContext webBlogDbContext)
        {
            this.webBlogDbContext = webBlogDbContext;
        }



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        //[ActionName("Add")]
        //public IActionResult SubmitTag()
        public IActionResult Add(AddTagReq addTagReq)
        {
            //var name = Request.Form["name"]; /////we won't use that bcz of it's a request by form approach to get and fetch the data from the server
            //var displayName = Request.Form["displayName"];//it's a old approach

            //var name = addTagReq.Name;
            //var displayName = addTagReq.DisplayName;//it's just for view




            //mapping addtagrequest to tag domain model 
            var tag = new Tag
            {
                Name = addTagReq.Name,
                DisplayNamae = addTagReq.DisplayName
            };

            webBlogDbContext.Tags.Add(tag);
            webBlogDbContext.SaveChanges();

            return View("Add");
        }
    }
}
