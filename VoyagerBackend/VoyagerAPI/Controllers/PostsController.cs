using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace VoyagerAPI.Controllers
{
    [Route("api/posts")]
    [Authorize]
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
            var post = PostsDataStore.Current.Posts.FirstOrDefault(c => c.PostId == id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpGet("SortByVotes")]
        public IActionResult GetPostedByVotes()
        {
            var posts = PostsDataStore.Current.Posts;
            posts = posts.OrderByDescending(q => q.TimeCreated).ThenByDescending(q => q.Votes).ToList();
            return Ok(posts);
        }

    }
}
