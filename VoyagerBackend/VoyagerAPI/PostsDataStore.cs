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
                    PostId = 1,
                  
                    Name = "Kristian",
                    SolutionName = "Ny ADK analyse",
                    SolutionDescription = "Effektivisere ADK-revisjon",
                    IsAnonym = true,
                    UserId = 33,
                    descriptionOfNeed = "Ønsker mer effektiv revisjon",
                    DescriptionValue = "Mer effektiv revisjon, morsomere å revidere",
                    MarketNeed = "Hardere konkurranse på pris",
                    ServiceDepartment = "Revisjonsgruppe 1 Vika",
                    Competition = "RSM gjør det samme",
                    Votes = 10,

                },

                    new PostDto()
                    {
                    PostId = 2,
                    Name = "Shahab",
                    SolutionName = "Feedback",
                    SolutionDescription = "eksempeltekst",
                    IsAnonym = true,
                    UserId = 44,
                    descriptionOfNeed = "Ønsker mer effektiv revisjon",
                    DescriptionValue = "Mer effektiv revisjon, morsomere å revidere",
                    MarketNeed = "Hardere konkurranse på pris",
                    ServiceDepartment = "Revisjonsgruppe 1 Vika",
                    Competition = "RSM gjør det samme",
                    Votes = 4,

                 },       

                    new PostDto()
                    {
                    PostId = 3,
                    Name = "Niklas",
                    SolutionName = "Chatbot",
                    SolutionDescription = "eksempeltekst",
                    IsAnonym = true,
                    UserId = 55,
                    descriptionOfNeed = "Ønsker mer effektiv revisjon",
                    DescriptionValue = "Mer effektiv revisjon, morsomere å revidere",
                    MarketNeed = "Hardere konkurranse på pris",
                    ServiceDepartment = "Revisjonsgruppe 1 Vika",
                    Competition = "RSM gjør det samme",
                    Votes = 11, 

                 },


            };
        }
    }
}
