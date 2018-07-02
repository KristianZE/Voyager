using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagerAPI.Models
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAnonym { get; set; }
        public int Votes { get; set; }
    }
}
