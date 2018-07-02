using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoyagerAPI.Models;

namespace VoyagerAPI
{
    public class PostsDataStore
    {
        public static PostsDataStore Current { get; } = new PostsDataStore();
        public List<PostDto> Posts { get; set; }

        public PostsDataStore()
        {
            Posts = new List<PostDto>()
            {
                    new PostDto()
                {
                    Id = 1,
                    Name = "Kristian",
                    Description = "This is a post test",
                    IsAnonym = true
                },
                    new PostDto()
                {
                    Id = 2,
                    Name = "Carl",
                    Description = "We should implement cathedrals",
                    IsAnonym = false
                },
                    new PostDto()
                {
                    Id = 3,
                    Name = "Niklas",
                    Description = "Cheaper food please!",
                    IsAnonym = true
                }
            };
        }
    }
}
