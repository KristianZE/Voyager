using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagerAPI.Controllers
{
    [Route("api/posts")]
    public class PostsController : Controller
    {
        [HttpGet()]
        public IActionResult GetPosts()
        {
            return Ok(PostsDataStore.Current.Posts);
        }

        [HttpGet("{id}")]
        public IActionResult GetPosts(int id)
        {
            var post = PostsDataStore.Current.Posts.FirstOrDefault(c => c.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }
    }
}
