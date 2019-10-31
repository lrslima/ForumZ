using AutoMapper;
using ForumZ.Api.Models;
using ForumZ.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumZ.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Answers, AnswersViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Topic, TopicViewModel>().ReverseMap();
            CreateMap<Users, UsersViewModel>().ReverseMap();
            CreateMap<CategoryTopic, CategoryTopicViewModel>().ReverseMap();
        }
    }
}
