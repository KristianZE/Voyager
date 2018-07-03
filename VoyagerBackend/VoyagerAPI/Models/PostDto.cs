using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagerAPI.Models
{
    public class PostDto
    {
        public int PostId { get; set; }
        public DateTime TimeCreated { get; set; }
        public string Name { get; set; }
        public string SolutionName { get; set; }
        public string SolutionDescription { get; set; }
        public bool IsAnonym { get; set; }
        public int Votes { get; set; }
        public string descriptionOfNeed { get; set; }
        public string DescriptionValue { get; set; }
        public string MarketNeed { get; set; }
        public string ServiceDepartment { get; set; } 
        public string Competition { get; set; }
        public int UserId { get; set; }
    }
}
